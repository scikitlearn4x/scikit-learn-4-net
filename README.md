![Nuget](https://img.shields.io/nuget/v/ai.scikitlearn4net)

Working with Python and the Machine Learning and Data Science ecosystem is fun, but
when it comes to deployment, you may not want to have to use Python. The goal of this
repository (and its siblings) is to address this need; you can experiment and train models in the rich
Python ecosystem, but deploy your models in other languages and platforms.
**scikit-learn4x** is a free an open source library that allows you to deploy
scikit-learn model in other programming languages. As such, the training codes are not
included in this repository (the fit methods), only the inference of models is
supported (the predict, predict_proba and predict_log_proba).

This repository is the code for the .NET (**scikit-learn 4 .NET**).
You can also use **scikit-learn for JVM** to deploy in Java and other JVM based
languages.

### Important Links

scikit-learn4x Python Library: https://github.com/scikitlearn4x/scikit-learn-4x-python-lib
This is the library that serializes the models into a format that this repository understands.

scikit-learn 4 JVM Repository: https://github.com/scikitlearn4x/scikit-learn-4-jvm
Very similar to this repository, scikit-learn-4-jvm provide the same functionality for JVM
based languages.

## Example Usage

The process of using **scikit-learn4x** is easy, you train your model in Python and
save it into a file using the sklearn4x library. Please find the link to the library
at https://pypi.org/project/sklearn4x/. Then, you use the scikit-learn 4 .NET to load
the saved model in C# or other .NET based languages.

```
from sklearn import datasets
from sklearn.naive_bayes import GaussianNB
from sklearn4x.sklearn4x import save_scikit_learn_model
import pandas as pd

ds = datasets.load_iris()
X = ds.data
y = ds.target

train_data = pd.DataFrame(data=X, index=None, columns=['SepalLengthCm', 'SepalWidthCm', 'PetalLengthCm', 'PetalWidthCm'], dtype=X.dtype, copy=False)

classifier = GaussianNB()
classifier.fit(train_data, y)

predictions = classifier.predict(X)
prediction_probabilities = classifier.predict_proba(X)
prediction_log_probabilities = classifier.predict_log_proba(X)

test_data = {
    "training_data": X,
    "predictions": predictions,
    "prediction_probabilities": prediction_probabilities,
    "prediction_log_probabilities": prediction_log_probabilities,
}

print(f'First data point prediction: {predictions[0]}')
print(f'First data point probabilities: {prediction_probabilities[0, 0]:.3f}, {prediction_probabilities[0, 1]:.3f}')
print(f'First data point log probabilities: {prediction_log_probabilities[0, 0]:.3f}, {prediction_log_probabilities[0, 1]:.3f}')


save_scikit_learn_model({'classifier_to_deploy_in_c#': classifier}, '/some/path/on/disk.skx', test_data)

# You should see the following outputs:
#
# First data point prediction: 0
# First data point probabilities: 1.000, 0.000
# First data point log probabilities: 0.000, -41.141
```

Now, in the .NET side:

```
String path = "/same/path/on/disk.skx";
IScikitLearnPackage binaryPackage = ScikitLearnPackageFactory.LoadFromFile(path);

// Check actual computed values
GaussianNaiveBayes classifier = (GaussianNaiveBayes)binaryPackage.GetModel("classifier_to_deploy_in_c#");

NumpyArray<double> x = (NumpyArray<double>)binaryPackage.ExtraValues["training_data"];

NumpyArray<long> predictions = classifier.Predict(x);
NumpyArray<double> probabilities = classifier.PredictProbabilities(x);
NumpyArray<double> logProbabilities = classifier.PredictLogProbabilities(x);

Console.Writeline($"First data point prediction: {predictions.Get(0)}:N3");
Console.Writeline($"First data point probabilities: {probabilities.Get(0, 0):N3}, {probabilities.Get(0, 1):N3}");
Console.Writeline($"First data point log probabilities: {logProbabilities.Get(0, 0):N3}, {logProbabilities.Get(0, 1):N3}");

/*
    You should see the same outputs as Python's:

    First data point prediction: 0
    First data point probabilities: 1.000, 0.000
    First data point log probabilities: 0.000, -41.141
*/
```

## Support

This is an ongoing project at the moment and only a subset of the scikit-learn APIs
are ported to **scikit-learn for .NET**. The roadmap for the future is porting the
components with the following order:

First, a baseline classifier is ported. In this case, the GaussianNB was selected due
to its simplicity to focus on implementing proper testing and CI/CD pipeline. This step
is already done.

Second, porting the utility classes in scikit-learn such including but not limited to
the LabelEncoder and Pipelines.

Third, porting the rich library of the classifiers with proper testing to .NET and
other languages.

Forth, porting the rich library of the regressors with proper testing to .NET and
other languages.

### Classifiers

The following classifiers are supported:

* Naive Bayes
    - Gaussian Naive Bayes (GaussianNB)

### Regressors

The regressors are not supported yet.

## Installation

scikit-learn for .NET is available as a Nuget package. Simply use the following
package information to add it as a dependency to your project.

```
PM> Install-Package ai.scikitlearn4net -Version 0.0.3
```

## Project Raison d'Être

I have been a softwar enegineer for the better part of the last two decades. C# and
Java has always been my favorite languages. Then, I started working with machine
learning and I got stucked with Python from the design to deployment. In some cases,
I was looking for real time performance or I just didn't have access to an HTTP server
that will host my trained models. At some point, I just decided to remove this limitation
and implement the inference in my preferred language once and for all. The result of this
effort is this repository and its siblings. I hope it will be useful :)

## Credits

To be completed

## Help and Support

Feel free to contact me with my email address:
ma (initials for Mohammad Ali), then underscore and then my last name (Yektaie). Finally,
add at outlook.com.

