using System;
using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;
using SkLearn.NaiveBayes;

namespace SkLearn.Test.Classifiers.Gaussian_Naive_Bayes {
[TestFixture]
public class GaussianNaiveBayesWithExplicitVarSmoothingTests {
	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.0 on python 3.5.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_5_6WithSkLearn0_20_0OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.0/3.5/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.0", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_5_6WithSkLearn0_20_0OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.0/3.5/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.0", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_5_6WithSkLearn0_20_0OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.0/3.5/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.0", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.0 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_0OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.0/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.0", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_0OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.0/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.0", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_0OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.0/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.0", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.0 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_0OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.0/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.0", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_0OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.0/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.0", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_0OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.0/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.0", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.1 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.1 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.2 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.2 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.3 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_3OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.3/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_3OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.3/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_20_3OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.3/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.3 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_3OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.3/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_3OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.3/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_20_3OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.20.3/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.20.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.1 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_21_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_21_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_21_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.1 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_21_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_21_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_21_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.2 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_21_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_21_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_21_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.2 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_21_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_21_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_21_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.3 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_21_3OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.3/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_21_3OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.3/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_21_3OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.3/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.3 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_21_3OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.3/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_21_3OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.3/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_21_3OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.21.3/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.21.3", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.22 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_22OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_22OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_22OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.22 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_22OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_22OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_22OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.22.1 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_22_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_22_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_22_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.22.1 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_22_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_22_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_22_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.22.1 on python 3.8.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_22_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_22_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_22_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.22.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.22.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.1 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_23_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_23_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_23_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.1 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_23_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_23_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_23_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.1 on python 3.8.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_23_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_23_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_23_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.2 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_23_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_23_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_23_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.2 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_23_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_23_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_23_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.2 on python 3.8.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_23_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.2/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_23_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.2/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_23_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.23.2/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.23.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.1.1 on python 3.9.12
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn1_1_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.1.1/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn1_1_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.1.1/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn1_1_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.1.1/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.1.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_24_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_24_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_24_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_24_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_24_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_24_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.8.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_24_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_24_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_24_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.9.12
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn0_24_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn0_24_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn0_24_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.1/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.6.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_24_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_24_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_6_13WithSkLearn0_24_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.6/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_24_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_24_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn0_24_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.8.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_24_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_24_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn0_24_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.9.12
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn0_24_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn0_24_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn0_24_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("0.24.2/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("0.24.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.1 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn1_0_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn1_0_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn1_0_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.1/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.1 on python 3.8.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn1_0_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn1_0_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn1_0_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.1/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.1 on python 3.9.12
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn1_0_1OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.1/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn1_0_1OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.1/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn1_0_1OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.1/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.1", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.7.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn1_0_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn1_0_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_7_13WithSkLearn1_0_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.7/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.8.13
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn1_0_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn1_0_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_8_13WithSkLearn1_0_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.8/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.9.12
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn1_0_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn1_0_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_9_12WithSkLearn1_0_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.9/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.10.4
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_10_4WithSkLearn1_0_2OnIris() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.10/gaussian_naive_bayes_with_explicit_var_smoothing_on_iris.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("iris", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_10_4WithSkLearn1_0_2OnWine() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.10/gaussian_naive_bayes_with_explicit_var_smoothing_on_wine.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("wine", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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

	[Test]
	public void TestWithExplicitVarSmoothingOnPython3_10_4WithSkLearn1_0_2OnBreastCancer() {
		String path = TestHelper.GetAbsolutePathOfBinaryPackage("1.0.2/3.10/gaussian_naive_bayes_with_explicit_var_smoothing_on_breast_cancer.skx");
		IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

		// Check header values
		Assert.AreEqual(1, binaryPackage.PackageHeader.FileFormatVersion);
		Assert.AreEqual("1.0.2", binaryPackage.PackageHeader.ScikitLearnVersion);

		// Check extra values
		Assert.AreEqual("breast_cancer", binaryPackage.ExtraValues["dataset_name"]);

		// Check actual computed values
		GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_test");

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