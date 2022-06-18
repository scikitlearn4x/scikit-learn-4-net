using SkLearn.Core;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Utils;

namespace SkLearn.NaiveBayes
{
    /// <summary>
    /// Naive Bayes classifier for bernoulli distributed models.
    /// </summary>
    public class BernoulliNaiveBayes : BaseNaiveBayes
    {
        /// <summary>
        /// Empirical log probability of features given a class, P(x_i|y).
        /// </summary>
        private NumpyArray<double> featureLogProbabilities = null;

        /// <summary>
        /// Log probability of each class (smoothed).
        /// </summary>
        private NumpyArray<double> classLogPrior = null;

        /// <summary>
        /// Number of samples encountered for each (class, feature) during fitting. This value is weighted by the sample weight when provided.
        /// </summary>
        private NumpyArray<double> featureCounts = null;

        /// <summary>
        /// Threshold for binarizing (mapping to booleans) of sample features. If None, input is presumed to already consist of binary vectors.
        /// </summary>
        private double binarizationThreshold = 0.0;
        
        /// <summary>
        /// Gets the empirical log probability of features given a class, P(x_i|y).
        /// </summary>
        public NumpyArray<double> FeatureLogProbabilities
        {
            get { return featureLogProbabilities;}
            internal set { featureLogProbabilities = value; }
        }

        /// <summary>
        /// Gets the log probability of each class (smoothed).
        /// </summary>
        public NumpyArray<double> ClassLogPrior
        {
            get { return classLogPrior;}
            internal set { classLogPrior = value; }
        }

        /// <summary>
        /// Gets the number of samples encountered for each (class, feature) during fitting. This value is weighted by the sample weight when provided. 
        /// </summary>
        public NumpyArray<double> FeatureCounts
        {
            get { return featureCounts;}
            internal set { featureCounts = value; }
        }

        /// <summary>
        /// Gets the threshold for binarizing (mapping to booleans) of sample features. If None, input is presumed to already consist of binary vectors. 
        /// </summary>
        public double BinarizationThreshold
        {
            get { return binarizationThreshold;}
            internal set { binarizationThreshold = value; }
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
             """Calculate the posterior log probability of the samples X"""
             n_features = self.Feature_log_prob_.Shape[1]
             n_features_X = X.Shape[1]
            
             if n_features_X != n_features:
             raise ValueError(
             "Expected input with %d features, got %d instead"
             % (n_features, n_features_X)
             )
            
             neg_prob = np.Log(1 - np.Exp(self.Feature_log_prob_))
             # Compute  neg_prob · (1 - X).T  as  ∑neg_prob - X · neg_prob
             jll = safe_sparse_dot(X, (self.Feature_log_prob_ - neg_prob).T)
             jll += self.Class_log_prior_ + neg_prob.Sum(axis=1)
            
             return jll
             */
            x = Preprocessing.BinarizeInput(x, binarizationThreshold);

            int n_features = this.featureLogProbabilities.Shape[1];
            int n_features_X = x.Shape[1];

            if (n_features != n_features_X)
            {
                throw new ScikitLearnCoreException(String.Format("Expected input with {0} features, got {1} instead.", n_features, n_features_X));
            }

            NumpyArray<double> featureProbabilities = Numpy.Exp(featureLogProbabilities);
            NumpyArray<double> negProb = Numpy.Log(Numpy.Add<double, double>(Numpy.Multiply<double, double>(featureProbabilities, -1), 1.0));
            // Compute  neg_prob · (1 - X).T  as  ∑neg_prob - X · neg_prob
            NumpyArray<double> jll = ExtMath.Dot(x, Numpy.Subtract<double, double, double>(featureLogProbabilities, negProb).Transpose());

            jll = Numpy.Add<double, double, double>(jll, Numpy.Add<double, double, double>(this.classLogPrior, Numpy.Sum(negProb, 1, false)));

            return jll;
        }
    }
}