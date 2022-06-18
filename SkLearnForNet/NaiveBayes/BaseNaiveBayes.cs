using System;
using SkLearn.Base;
using SkLearn.Core.Libraries;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.NaiveBayes
{
    /// <summary>
    /// Abstract base class for naive Bayes estimators
    /// </summary>
    public abstract class BaseNaiveBayes : ClassifierMixin
    {
        /// <summary>
        /// Compute the unnormalized posterior log probability of X.
        /// I.e. ``log P(c) + log P(x|c)`` for all rows x of X, as an array-like of shape
        /// (n_samples, n_classes).
        /// predict, predictProbabilities, and predictLogProbabilities pass the input over to
        /// jointLogLikelihood.
        /// <param name="x">An array-like of shape (n_samples, n_classes).</param>
        /// </summary>
        protected abstract NumpyArray<double> JointLogLikelihood(NumpyArray<double> x);

        /// <summary>
        /// Compute the unnormalized posterior log probability of X.
        /// I.e. ``log P(c) + log P(x|c)`` for all rows x of X, as an array-like of shape
        /// (n_samples, n_classes).
        /// predict, predictProbabilities, and predictLogProbabilities pass the input over to
        /// jointLogLikelihood.
        /// <param name="x">An array-like of shape (n_samples, n_classes).
        /// </param>
        /// </summary>
        public override NumpyArray<long> Predict(NumpyArray<double> x)
        {
            NumpyArray<double> jll = JointLogLikelihood(x);
            return Numpy.Argmax(jll, 1, false);
        }

        /// <summary>
        /// Return log-probability estimates for the test vector X.
        /// <param name="x">array-like of shape (n_samples, n_features) The input samples.
        /// </param>
        /// <returns>array-like of shape (n_samples, n_classes)
        /// Returns the log-probability of the samples for each class in
        /// the model. The columns correspond to the classes in sorted
        /// order, as they appear in the attribute :term:`classes_`.</returns>
        /// </summary>
        public override NumpyArray<double> PredictLogProbabilities(NumpyArray<double> x)
        {
            NumpyArray<double> jll = JointLogLikelihood(x);
            NumpyArray<double> logProbabilityOfX = Scipy.LogSumExponent(jll, 1);

            return Numpy.Subtract<double, double, double>(jll, Numpy.AtLeast2D(logProbabilityOfX).Transpose());
        }

        /// <summary>
        /// Return probability estimates for the test vector X.
        /// <param name="x">array-like of shape (n_samples, n_features) The input samples.
        /// </param>
        /// <returns>array-like of shape (n_samples, n_classes)
        /// Returns the probability of the samples for each class in
        /// the model. The columns correspond to the classes in sorted
        /// order, as they appear in the attribute :term:`classes_`.</returns>
        /// </summary>
        public override NumpyArray<double> PredictProbabilities(NumpyArray<double> x)
        {
            return Numpy.Exp(PredictLogProbabilities(x));
        }
    }
}