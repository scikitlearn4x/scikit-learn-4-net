using SkLearn.Core.Libraries;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Base
{
    /// <summary>
    /// Mixin class for all classifiers in scikit-learn.
    /// </summary>
    public abstract class ClassifierMixin
    {
        /// <summary>
        /// Compute the unnormalized posterior log probability of X.
        /// I.e. ``log P(c) + log P(x|c)`` for all rows x of X, as an array-like of shape
        /// (n_samples, n_classes).
        /// predict, predictProbabilities, and predictLogProbabilities pass the input over to
        /// jointLogLikelihood.
        /// <param name="x">An array-like of shape (n_samples, n_classes).
        /// </param>
        /// </summary>
        public abstract NumpyArray<long> Predict(NumpyArray<double> x);

        /// <summary>
        /// Return log-probability estimates for the test vector X.
        /// <param name="x">array-like of shape (n_samples, n_features) The input samples.
        /// </param>
        /// <returns>array-like of shape (n_samples, n_classes)
        /// Returns the log-probability of the samples for each class in
        /// the model. The columns correspond to the classes in sorted
        /// order, as they appear in the attribute :term:`classes_`.</returns>
        /// </summary>
        public abstract NumpyArray<double> PredictLogProbabilities(NumpyArray<double> x);

        /// <summary>
        /// Return probability estimates for the test vector X.
        /// <param name="x">array-like of shape (n_samples, n_features) The input samples.
        /// </param>
        /// <returns>array-like of shape (n_samples, n_classes)
        /// Returns the probability of the samples for each class in
        /// the model. The columns correspond to the classes in sorted
        /// order, as they appear in the attribute :term:`classes_`.</returns>
        /// </summary>
        public abstract NumpyArray<double> PredictProbabilities(NumpyArray<double> x);
    }
}