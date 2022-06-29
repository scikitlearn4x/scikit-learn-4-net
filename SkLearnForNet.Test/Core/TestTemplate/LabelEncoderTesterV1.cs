using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;
using SkLearn.Preprocessing.Label;
using SkLearn.Test.Core.TestTemplate.Bases;

namespace SkLearn.Test.Core.TestTemplate
{
    public class LabelEncoderTesterV1 : BaseTesterV1
    {
        protected override string GetBinaryFilePath(string version)
        {
            return String.Format("{0}/{1}/{2}/{3}/{4}_{5}.skx", TestHelper.TEST_FILES_HOME, version, ScikitLearnVersion, PythonVersion, ObjectName.ToLower().Replace(" ", "_"), ConfigurationName.Replace(" ", "_"));
        }

        protected override void PerformUseCaseSpecificTest(IScikitLearnPackage binaryPackage)
        {
            long[] transformed = (long[]) ((NumpyArray<long>) binaryPackage.ExtraValues["transformed"]).GetWrapper().RawArray;
            Object _raw = binaryPackage.ExtraValues["raw"];
            List<Object> raw = null;

            if (_raw is String[]) {
                raw = new List<object>((String[]) _raw);
            } else if (_raw is INumpyArray) {
                NumpyArray<long> np = (NumpyArray<long>) _raw;
                if (np.NumberOfDimensions == 1) {
                    raw = new List<object>();
                    for (int i = 0; i < np.Shape[0]; i++) {
                        raw.Add(np.Get(i));
                    }
                } else {
                    // Not implemented yet
                    throw new NotImplementedException();
                }
            } else {
                raw = (List<Object>) _raw;
            }

            LabelEncoder encoder = (LabelEncoder) binaryPackage.GetModel("preprocessing_to_test");

            NumpyArray<long> encoderTransformOutput = encoder.Transform(raw);
            TestHelper.AssertEqualData(encoderTransformOutput, transformed);

            List<Object> encoderInverseTransformOutput = encoder.InverseTransform(NumpyArrayFactory.From(transformed));
            AssertEqualData(encoderInverseTransformOutput, raw);
        }

        private void AssertEqualData(List<Object> l1, List<Object> l2) {
            Assert.AreEqual(l1.Count, l2.Count);

            for (int i = 0; i < l1.Count; i++) {
                Assert.AreEqual(l1[i], l2[i]);
            }
        }

        protected override void ValidateExtraValues(IScikitLearnPackage binaryPackage)
        {
            
        }
    }
}