using System;
using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Packaging;
using SkLearn.Test.Core.TestTemplate;

namespace SkLearn.Test.Classifiers.Categorical_Naive_Bayes {
[TestFixture]
public class CategoricalNaiveBayesWithExplicitPriorsAndAlphaTests {
	
	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.1.1 on python 3.9
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn1_1_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.1.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn1_1_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.1.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn1_1_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.1.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_6WithSkLearn0_24_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_6WithSkLearn0_24_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_6WithSkLearn0_24_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn0_24_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn0_24_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn0_24_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn0_24_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn0_24_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn0_24_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.1 on python 3.9
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn0_24_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn0_24_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn0_24_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.6
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_6WithSkLearn0_24_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_6WithSkLearn0_24_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_6WithSkLearn0_24_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.6";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn0_24_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn0_24_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn0_24_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn0_24_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn0_24_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn0_24_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 0.24.2 on python 3.9
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn0_24_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn0_24_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn0_24_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "0.24.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.1 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn1_0_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn1_0_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn1_0_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.1 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn1_0_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn1_0_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn1_0_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.1 on python 3.9
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn1_0_1OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn1_0_1OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn1_0_1OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.1";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.7
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn1_0_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn1_0_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_7WithSkLearn1_0_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.7";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.8
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn1_0_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn1_0_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_8WithSkLearn1_0_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.8";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.9
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn1_0_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn1_0_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_9WithSkLearn1_0_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.9";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	// ------------------------------------------------------------------------
	// Test for scikit-learn 1.0.2 on python 3.10
	// ------------------------------------------------------------------------

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_10WithSkLearn1_0_2OnIris() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.10";
		testingTemplate.DataSetName = "iris";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_10WithSkLearn1_0_2OnWine() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.10";
		testingTemplate.DataSetName = "wine";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

	[Test]
	public void TestWithExplicitPriorsAndAlphaOnPython3_10WithSkLearn1_0_2OnBreastCancer() {
		ClassifierTestingTemplateV1 testingTemplate = new ClassifierTestingTemplateV1();
		
		testingTemplate.ScikitLearnVersion = "1.0.2";
		testingTemplate.PythonVersion = "3.10";
		testingTemplate.DataSetName = "breast_cancer";
		testingTemplate.ClassifierName = "Categorical Naive Bayes";
		testingTemplate.ClassifierConfigurationName = "with explicit priors and alpha";
		testingTemplate.SupportProbability = true;
		testingTemplate.FeatureNames = null;
		
		testingTemplate.Test();
	}

}
}