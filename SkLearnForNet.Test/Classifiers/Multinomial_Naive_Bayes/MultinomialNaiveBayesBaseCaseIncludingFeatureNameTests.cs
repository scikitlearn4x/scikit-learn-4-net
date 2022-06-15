using System;
using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;
using SkLearn.Test.Core.TestTemplate;

namespace SkLearn.Test.Classifiers.Multinomial_Naive_Bayes {
[TestFixture]
public class MultinomialNaiveBayesBaseCaseIncludingFeatureNameTests {
	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.0 on python 3.5
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_5WithSkLearn0_20_0OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.0";
		testingTemplate.PythonVersion = "3.5";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_5WithSkLearn0_20_0OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.0";
		testingTemplate.PythonVersion = "3.5";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_5WithSkLearn0_20_0OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.0";
		testingTemplate.PythonVersion = "3.5";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.0 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_0OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.0";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_0OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.0";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_0OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.0";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.0 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_0OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.0";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_0OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.0";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_0OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.0";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.1 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.1 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.2 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.2 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.3 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_3OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.3";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_3OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.3";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_20_3OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.3";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.20.3 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_3OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.3";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_3OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.3";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_20_3OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.20.3";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.1 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_21_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_21_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_21_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.1 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_21_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_21_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_21_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.2 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_21_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_21_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_21_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.2 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_21_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_21_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_21_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.3 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_21_3OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.3";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_21_3OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.3";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_21_3OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.3";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.21.3 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_21_3OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.3";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_21_3OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.3";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_21_3OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.21.3";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.22 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_22OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_22OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_22OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.22 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_22OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_22OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_22OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.22.1 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_22_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_22_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_22_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.22.1 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_22_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_22_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_22_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.22.1 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_22_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_22_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_22_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.22.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.1 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_23_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_23_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_23_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.1 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_23_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_23_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_23_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.1 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_23_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_23_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_23_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.2 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_23_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_23_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_23_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.2 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_23_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_23_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_23_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.23.2 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_23_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_23_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_23_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.23.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.1.1 on python 3.9
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn1_1_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.1.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn1_1_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.1.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn1_1_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.1.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_24_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_24_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_24_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_24_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_24_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_24_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_24_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_24_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_24_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.9
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn0_24_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn0_24_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn0_24_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_24_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_24_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_6WithSkLearn0_24_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_24_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_24_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn0_24_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_24_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_24_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn0_24_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.9
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn0_24_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn0_24_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn0_24_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.1 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn1_0_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn1_0_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn1_0_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.1 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn1_0_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn1_0_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn1_0_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.1 on python 3.9
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn1_0_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn1_0_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn1_0_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn1_0_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn1_0_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_7WithSkLearn1_0_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn1_0_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn1_0_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_8WithSkLearn1_0_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.9
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn1_0_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn1_0_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_9WithSkLearn1_0_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.10
	// ------------------------------------------------------------------------

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_10WithSkLearn1_0_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.10";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"SepalLengthCm", "SepalWidthCm", "PetalLengthCm", "PetalWidthCm"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_10WithSkLearn1_0_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.10";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"Class Label", "Alcohol", "Malic acid", "Ash", "Alcalinity of ash", "Magnesium", "Total phenols", "Flavanoids", "Nonflavanoid phenols", "Proanthocyanins", "Color intensity", "Hue", "diluted wines"};
		
		testingTemplate.Test();
	}

	[Test]
	public void TestBaseCaseIncludingFeatureNameOnPython3_10WithSkLearn1_0_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.10";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Multinomial Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "base case including feature name";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = new String[] {"f_1", "f_2", "f_3", "f_4", "f_5", "f_6", "f_7", "f_8", "f_9", "f_10", "f_11", "f_12", "f_13", "f_14", "f_15", "f_16", "f_17", "f_18", "f_19", "f_20", "f_21", "f_22", "f_23", "f_24", "f_25", "f_26", "f_27", "f_28", "f_29", "f_30"};
		
		testingTemplate.Test();
	}

}
}