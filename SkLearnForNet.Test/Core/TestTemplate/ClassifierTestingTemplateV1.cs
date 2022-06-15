using System;
using NUnit.Framework;
using SkLearn.Base;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;

namespace SkLearn.Test.Core.TestTemplate
{
    public class ClassifierTestingTemplateV1
    {
        public const int BINARY_PACKAGE_FILE_FORMAT = 1;

        public String ScikitLearnVersion
        {
            get;
            set;
        }

        public String PythonVersion
        {
            get;
            set;
        }

        public String ClassifierName
        {
            get;
            set;
        }

        public String ClassifierConfigurationName
        {
            get;
            set;
        }

        public String DataSetName
        {
            get;
            set;
        }

        public String[] FeatureNames
        {
            get;
            set;
        }
        
        public bool SupportProbability
        {
            get;
            set;
        }

        private static Dictionary<String, NumpyArray<double>> datasetCache = new Dictionary<String, NumpyArray<double>>();

        private static Dictionary<String, List<String>> versionContent = new Dictionary<String, List<String>>();

        static ClassifierTestingTemplateV1()
        {
            String[] versions = Directory.GetDirectories(TestHelper.TEST_FILES_HOME);

            foreach (String folder in versions)
            {
                String version = folder.Substring(folder.LastIndexOf("/") + 1);

                List<String> classifiers = new List<String>(File.ReadAllLines(folder + "/classifiers.txt"));

                versionContent.Add(version, classifiers);
            }
        }

        public void Test()
        {
            String classifierId = this.ClassifierName.Replace(" ", "_").ToLower();

            foreach (KeyValuePair<String, List<String>> version in versionContent)
            {
                List<String> classifiersSupported = version.Value;
                if (classifiersSupported.Contains(classifierId))
                {
                    String path = String.Format("{0}/{1}/{2}/{3}/{4}_{5}_on_{6}.skx", TestHelper.TEST_FILES_HOME, version.Key, ScikitLearnVersion, PythonVersion, ClassifierName.ToLower().Replace(" ", "_"), ClassifierConfigurationName.Replace(" ", "_"), DataSetName);
                    IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

                    ValidateHeaderValues(binaryPackage);
                    ValidateExtraValues(binaryPackage);
                    ValidateClassifierData(binaryPackage);
                }
            }
        }

        private void ValidateClassifierData(IScikitLearnPackage binaryPackage)
        {
            ClassifierMixin classifier = (ClassifierMixin)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<Double> x = LoadDataSet((String)binaryPackage.ExtraValues["dataset_name"]);
            NumpyArray<Double> gtProbabilities = (NumpyArray<Double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<Double> gtLogProbabilities = (NumpyArray<Double>)binaryPackage.ExtraValues["prediction_log_probabilities"];

            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<Double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<Double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        private NumpyArray<Double> LoadDataSet(String datasetName)
        {
            lock (datasetCache)
            {
                if (datasetCache.ContainsKey(datasetName))
                {
                    return datasetCache[datasetName];
                }
                
                String currentDirectory = Environment.CurrentDirectory;
                currentDirectory = currentDirectory.Substring(0, currentDirectory.IndexOf("SkLearnForNet.Test"));
                String[] lines = File.ReadAllLines(currentDirectory + "Test Data/" + datasetName + "_x.txt");
                int featureCount = lines[0].Split(' ').Length;

                double[,] data = new double[lines.Length, featureCount];

                for (int i = 0; i < lines.Length; i++)
                {
                    String[] items = lines[i].Split(' ');

                    for (int j = 0; j < items.Length; j++)
                    {
                        data[i, j] = double.Parse(items[j]);
                    }
                }

                NumpyArray<double> result = NumpyArrayFactory.From(data);
                datasetCache.Add(datasetName, result);
                return result;
            }
        }

        private void ValidateExtraValues(IScikitLearnPackage binaryPackage)
        {
            Assert.AreEqual(DataSetName, binaryPackage.ExtraValues["dataset_name"]);
            String[] actualFeatures = null;

            if (binaryPackage.ExtraValues.ContainsKey("feature_names"))
            {
                actualFeatures = (String[])binaryPackage.ExtraValues["feature_names"];
            }

            if (actualFeatures != null && FeatureNames == null)
            {
                Assert.Fail("The binary package provides feature names but the test doesn't specify them.");
            }
            else if (actualFeatures == null && FeatureNames != null)
            {
                Assert.Fail("The binary package is missing feature names while the test specifies them.");
            }
            else if (actualFeatures != null && FeatureNames != null)
            {
                TestHelper.AssertCorrectFeatureNames(FeatureNames, actualFeatures);
            }
        }

        private void ValidateHeaderValues(IScikitLearnPackage binaryPackage)
        {
            Assert.AreEqual(BINARY_PACKAGE_FILE_FORMAT, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual(ScikitLearnVersion, binaryPackage.PackageHeader.ScikitLearnVersion);
        }
    }
}