using System;
using NUnit.Framework;
using SkLearn.Base;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;
using SkLearn.Test.Core.TestTemplate.Bases;

namespace SkLearn.Test.Core.TestTemplate
{
    public class ClassifierTestingTemplateV1 : BaseTesterV1
    {
        public String DataSetName { get; set; }

        public String[] FeatureNames { get; set; }

        public bool SupportProbability { get; set; }

        private static Dictionary<String, NumpyArray<double>> datasetCache = new Dictionary<String, NumpyArray<double>>();

        protected override string GetBinaryFilePath(String version)
        {
            return String.Format("{0}/{1}/{2}/{3}/{4}_{5}_on_{6}.skx", TestHelper.TEST_FILES_HOME, version, ScikitLearnVersion, PythonVersion, ObjectName.ToLower().Replace(" ", "_"), ConfigurationName.Replace(" ", "_"), DataSetName);
        }

        protected override void PerformUseCaseSpecificTest(IScikitLearnPackage binaryPackage)
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

        protected override void ValidateExtraValues(IScikitLearnPackage binaryPackage)
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
    }
}