using System;
using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;
using SkLearn.NaiveBayes;

namespace SkLearn.Test.Classifiers.Gaussian_Naive_Bayes
{
    [TestFixture]
    public class GaussianNaiveBayesBaseCaseIncludingFeatureNameTests
    {
        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.0 on python 3.8.13
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_0OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_0OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_0OnBreastCancer()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.0 on python 3.9.12
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_0OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_0OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_0OnBreastCancer()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.0.1 on python 3.8.13
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_0_1OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.1/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_0_1OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.1/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_0_1OnBreastCancer()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.1/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.0.1 on python 3.9.12
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_0_1OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.1/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_0_1OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.1/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_0_1OnBreastCancer()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.1/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.0.1 on python 3.10.4
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_0_1OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.1/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_0_1OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.1/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_0_1OnBreastCancer()
        {
            String path = TestHelper.GetAbsolutePathOfBinaryPackage(
                "1.0.1/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.0.2 on python 3.8.13
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_0_2OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.2/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_0_2OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.2/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_0_2OnBreastCancer()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.2/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.0.2 on python 3.9.12
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_0_2OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.2/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_0_2OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.2/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_0_2OnBreastCancer()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.2/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.0.2 on python 3.10.4
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_0_2OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.2/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_0_2OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.0.2/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_0_2OnBreastCancer()
        {
            String path = TestHelper.GetAbsolutePathOfBinaryPackage(
                "1.0.2/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.1.0 on python 3.8.13
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_1_0OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.0/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_1_0OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.0/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_1_0OnBreastCancer()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.0/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.1.0 on python 3.9.12
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_1_0OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.0/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_1_0OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.0/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_1_0OnBreastCancer()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.0/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.1.0 on python 3.10.4
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_1_0OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.0/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_1_0OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.0/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_1_0OnBreastCancer()
        {
            String path = TestHelper.GetAbsolutePathOfBinaryPackage(
                "1.1.0/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.0", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.1.1 on python 3.8.13
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_1_1OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.1/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_1_1OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.1/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_8_13WithSkLearn1_1_1OnBreastCancer()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.1/3.8/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.1.1 on python 3.9.12
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_1_1OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.1/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_1_1OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.1/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_9_12WithSkLearn1_1_1OnBreastCancer()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.1/3.9/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        // ------------------------------------------------------------------------
        // Test for scikit-learn 1.1.1 on python 3.10.4
        // ------------------------------------------------------------------------

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_1_1OnIris()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.1/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_iris.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[] { "SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm" },
                (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_1_1OnWine()
        {
            String path =
                TestHelper.GetAbsolutePathOfBinaryPackage(
                    "1.1.1/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_wine.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols",
                    "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }

        [Test]
        public void TestBaseCaseIncludingFeatureNameOnPython3_10_4WithSkLearn1_1_1OnBreastCancer()
        {
            String path = TestHelper.GetAbsolutePathOfBinaryPackage(
                "1.1.1/3.10/gaussian_naive_bayes_base_case_including_feature_name_on_breast_cancer.skx");
            IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

            // Check header values
            Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
            Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

            // Check extra values
            Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);
            TestHelper.AssertCorrectFeatureNames(
                new String[]
                {
                    "f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13",
                    "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25",
                    "f_26", "f_27", "f_28", "f_29", "f_30"
                }, (String[])binaryPackage.ExtraValues["feature_names"]);

            // Check actual computed values
            GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

            NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];
            NumpyArray<long> gtPredictions = (NumpyArray<long>)binaryPackage.ExtraValues["predictions"];
            NumpyArray<long> predictions = classifier.Predict(x);
            TestHelper.AssertEqualPredictions(predictions, (long[])gtPredictions.GetWrapper().RawArray);

            NumpyArray<double> gtProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_probabilities"];
            NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
            TestHelper.AssertEqualData(probabilities, (double[,])gtProbabilities.GetWrapper().RawArray);

            NumpyArray<double> gtLogProbabilities =
                (NumpyArray<double>)binaryPackage.ExtraValues["prediction_log_probabilities"];
            NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);
            TestHelper.AssertEqualData(logProbabilities, (double[,])gtLogProbabilities.GetWrapper().RawArray);
        }
    }
}