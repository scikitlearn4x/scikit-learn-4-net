using System;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Utils;

namespace SkLearn.NaiveBayes
{
    /// <summary>
    /// Naive Bayes classifier for complement distributed models.
    /// </summary>
    public class ComplementNaiveBayes : BaseNaiveBayes
    {
        /// <summary>
        /// Gets the empirical log probability of features given a class, P(x_i|y).
        /// </summary>
        public NumpyArray<double> FeatureLogProbabilities
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the log probability of each class (smoothed).
        /// </summary>
        public NumpyArray<double> ClassLogPrior
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the number of samples encountered for each (class, feature) during fitting. This value is weighted by the sample weight when provided.
        /// </summary>
        public NumpyArray<double> FeatureCounts
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the value of the feature_all_ field.
        /// </summary>
        public NumpyArray<double> FeatureAll
        {
            get;
            internal set;
        }

        /// <summary>
        /// Compute the unnormalized posterior log probability of X.
        /// I.e. ``log P(c) + log P(x|c)`` for all rows x of X, as an array-like of shape
        /// (n_samples, n_classes).
        /// predict, predictProbabilities, and predictLogProbabilities pass the input over to
        /// jointLogLikelihood.
        /// <param name="x">An array-like of shape (n_samples, n_classes).</param>
        /// <returns>The unnormalized posterior log probability of X.</returns>
        /// </summary>
        protected override NumpyArray<double> JointLogLikelihood(NumpyArray<double> x)
        {
/*
        jll = safe_sparse_dot(X, self.Feature_log_prob_.T)
        if len(self.Classes_) == 1:
            jll += self.Class_log_prior_
        return jll
 */
            NumpyArray<double> jll = ExtMath.Dot(x, FeatureLogProbabilities.Transpose());

            if (Classes.Shape[0] == 1)
            {
                jll = Numpy.Add<double, double, double>(jll, ClassLogPrior);
            }

            return jll;
        }
    }
}