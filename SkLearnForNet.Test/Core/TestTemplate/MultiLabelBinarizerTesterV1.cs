using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;
using SkLearn.Preprocessing.Label;
using SkLearn.Test.Core.TestTemplate.Bases;

namespace SkLearn.Test.Core.TestTemplate
{
    public class MultiLabelBinarizerTesterV1 : BaseTesterV1
    {
        public MultiLabelBinarizer objectUnderTest;

        protected override string GetBinaryFilePath(string version)
        {
            return String.Format("{0}/{1}/{2}/{3}/{4}_{5}.skx", TestHelper.TEST_FILES_HOME, version, ScikitLearnVersion, PythonVersion, ObjectName.ToLower().Replace(" ", "_"), ConfigurationName.Replace(" ", "_"));
        }

        protected override void PerformUseCaseSpecificTest(IScikitLearnPackage binaryPackage)
        {
            objectUnderTest = (MultiLabelBinarizer)binaryPackage.GetModel("preprocessing_to_test");

            long[,] transformed = (long[,])((NumpyArray<long>)binaryPackage.ExtraValues["transformed"]).GetWrapper().RawArray;
            Object _raw = binaryPackage.ExtraValues["raw"];
            List<ISet<Object>> raw = null;

            if (_raw is List<Object>)
            {
                Object value = ((List<Object>)_raw)[0];
                List<ISet<Object>> tmp = new List<ISet<Object>>();

                foreach (Object l in ((List<Object>)_raw))
                {
                    List<Object> list = (List<Object>)l;
                    ISet<Object> s = new HashSet<Object>(list);
                    tmp.Add(s);
                }

                MultiLabelBinarizer encoder = (MultiLabelBinarizer)binaryPackage.GetModel("preprocessing_to_test");

                NumpyArray<long> encoderTransformOutput = encoder.Transform(tmp);
                TestHelper.AssertEqualData(encoderTransformOutput, transformed);

                List<ISet<Object>> encoderInverseTransformOutput = encoder.InverseTransform(NumpyArrayFactory.From(transformed));
                AssertEqualData(encoderInverseTransformOutput, tmp);
            }
            else
            {
                Assert.Fail();
            }
        }

        protected override void ValidateExtraValues(IScikitLearnPackage binaryPackage)
        {
        }

        private static void AssertEqualData(List<ISet<Object>> l1, List<ISet<Object>> l2)
        {
            Assert.That(l2, Has.Count.EqualTo(l1.Count));
            
            for (var i = 0; i < l1.Count; i++)
            {
                Assert.True(l1[i].SetEquals(l2[i]));
            }
        }
    }
}