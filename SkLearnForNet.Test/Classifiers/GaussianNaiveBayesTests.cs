using System;
using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;
using SkLearn.NaiveBayes;

namespace SkLearn.Test.Classifiers
{
    [TestFixture]
    public class GaussianNaiveBayesTests
    {
        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.0 on python 3.8.13
        // ------------------------------------------------------------------------

        [Test]
        public void TestSimplestBaseCaseWithoutCustomizationOnPython3_8_13WithSkLearn1_0OnIris()
        {
            String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0/3.8/gaussian_naive_bayes_simplest_base_case_without_customization_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel(0);

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities = (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities = (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        
    }
}