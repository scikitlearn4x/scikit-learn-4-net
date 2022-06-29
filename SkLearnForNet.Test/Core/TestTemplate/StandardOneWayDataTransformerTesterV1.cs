using SkLearn.Base;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;
using SkLearn.Test.Core.TestTemplate.Bases;

namespace SkLearn.Test.Core.TestTemplate
{
    public class StandardOneWayDataTransformerTesterV1 : BaseTesterV1
    {
        protected override string GetBinaryFilePath(string version)
        {
            return String.Format("{0}/{1}/{2}/{3}/{4}_{5}.skx", TestHelper.TEST_FILES_HOME, version, ScikitLearnVersion, PythonVersion, ObjectName.ToLower().Replace(" ", "_"), ConfigurationName.Replace(" ", "_"));
        }

        protected override void PerformUseCaseSpecificTest(IScikitLearnPackage binaryPackage)
        {
            NumpyArray<double> transformed = (NumpyArray<double>)binaryPackage.ExtraValues["transformed"];
            NumpyArray<double> raw = (NumpyArray<double>)binaryPackage.ExtraValues["raw"];

            TransformerMixin<NumpyArray<double>, NumpyArray<double>> transformerMixin = (TransformerMixin<NumpyArray<double>, NumpyArray<double>>)binaryPackage.GetModel("preprocessing_to_test");

            NumpyArray<double> encoderTransformOutput = transformerMixin.Transform(raw);
            TestHelper.AssertEqualData(encoderTransformOutput, (double[,])transformed.GetWrapper().RawArray);
        }

        protected override void ValidateExtraValues(IScikitLearnPackage binaryPackage)
        {
        }
    }
}