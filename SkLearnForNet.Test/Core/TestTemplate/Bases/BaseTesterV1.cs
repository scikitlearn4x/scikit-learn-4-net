using NUnit.Framework;
using SkLearn.Base;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;

namespace SkLearn.Test.Core.TestTemplate.Bases
{
    public abstract class BaseTesterV1
    {
        public const int BINARY_PACKAGE_FILE_FORMAT = 1;

        public String ObjectName { get; set; }

        public String ScikitLearnVersion { get; set; }

        public String PythonVersion { get; set; }

        public String ConfigurationName { get; set; }

        private static Dictionary<String, NumpyArray<double>> datasetCache = new Dictionary<String, NumpyArray<double>>();

        protected static Dictionary<String, List<String>> versionContent = new Dictionary<String, List<String>>();

        static BaseTesterV1()
        {
            String[] versions = Directory.GetDirectories(TestHelper.TEST_FILES_HOME);

            foreach (String folder in versions)
            {
                String version = folder;
                version = version.Substring(version.LastIndexOf("/") + 1);

                String[] files = Directory.GetFiles(folder);
                List<String> items = new List<String>();

                foreach (String file in files)
                {
                    if (file.EndsWith(".txt"))
                    {
                        items.AddRange(File.ReadAllLines(file));
                    }
                }

                versionContent.Add(version, items);
            }
        }

        public void Test()
        {
            String classifierId = this.ObjectName.Replace(" ", "_").ToLower();

            foreach (KeyValuePair<String, List<String>> version in versionContent)
            {
                List<String> classifiersSupported = version.Value;
                if (classifiersSupported.Contains(classifierId))
                {
                    String path = GetBinaryFilePath(version.Key);
                    IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

                    ValidateHeaderValues(binaryPackage);
                    ValidateExtraValues(binaryPackage);
                    PerformUseCaseSpecificTest(binaryPackage);
                }
            }
        }

        protected abstract String GetBinaryFilePath(String version);
        
        protected abstract void PerformUseCaseSpecificTest(IScikitLearnPackage binaryPackage);

        protected abstract void ValidateExtraValues(IScikitLearnPackage binaryPackage);

        private void ValidateHeaderValues(IScikitLearnPackage binaryPackage)
        {
            Assert.AreEqual(BINARY_PACKAGE_FILE_FORMAT, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual(ScikitLearnVersion, binaryPackage.PackageHeader.ScikitLearnVersion);
        }
    }
}