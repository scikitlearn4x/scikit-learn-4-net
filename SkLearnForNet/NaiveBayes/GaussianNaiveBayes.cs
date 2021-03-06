using System;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Core.Libraries.Numpy.Wrappers;

namespace SkLearn.NaiveBayes
{
    /// <summary>
    /// Naive Bayes classifier for normal distributed models.
    /// </summary>
    public class GaussianNaiveBayes : BaseNaiveBayes
    {
        /// <summary>
        /// The frequency of each class in the training set.
        /// Dimension: (class_count)
        /// </summary>
        private NumpyArray<double> classCounts = null;

        /// <summary>
        /// The frequency of each class in the training set.
        /// Dimension: (class_count)
        /// </summary>
        public NumpyArray<double> ClassCounts
        {
            get { return classCounts; }
            internal set { classCounts = value; }
        }

        /// <summary>
        /// The prior probability of each class.
        /// Dimension: (class_count)
        /// </summary>
        private NumpyArray<double> classPriors = null;

        /// <summary>
        /// The prior probability of each class.
        /// Dimension: (class_count)
        /// </summary>
        public NumpyArray<double> ClassPriors
        {
            get { return classPriors; }
            internal set { classPriors = value; }
        }

        /// <summary>
        /// The list of class IDs.
        /// Dimension: (class_count)
        /// </summary>
        private NumpyArray<long> classes = null;

        /// <summary>
        /// The list of class IDs.
        /// Dimension: (class_count)
        /// </summary>
        public NumpyArray<long> Classes
        {
            get { return classes; }
            internal set { classes = value; }
        }

        /// <summary>
        /// The user provided class priors. If specified, the priors are not adjusted according to the data.
        /// Dimension: (class_count)
        /// </summary>
        private NumpyArray<double> priors = null;

        /// <summary>
        /// The user provided class priors. If specified, the priors are not adjusted according to the data.
        /// Dimension: (class_count)
        /// </summary>
        public NumpyArray<double> Priors
        {
            get { return priors; }
            internal set { priors = value; }
        }

        /// <summary>
        /// Variance of each feature per class.
        /// Dimension: (n_classes, n_features)
        /// </summary>
        private NumpyArray<double> sigma = null;

        /// <summary>
        /// Variance of each feature per class.
        /// Dimension: (n_classes, n_features)
        /// </summary>
        public NumpyArray<double> Sigma
        {
            get { return sigma; }
            internal set { sigma = value; }
        }

        /// <summary>
        /// Mean of each feature per class.
        /// Dimension: (n_classes, n_features)
        /// </summary>
        private NumpyArray<Double> theta = null;

        /// <summary>
        /// Mean of each feature per class.
        /// Dimension: (n_classes, n_features)
        /// </summary>
        public NumpyArray<Double> Theta
        {
            get { return theta; }
            internal set { theta = value; }
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
        protected override NumpyArray<Double> JointLogLikelihood(NumpyArray<Double> x)
        {
            int count = x.Shape[0];
            int classCount = classCounts.Shape[0];
            int featureCount = sigma.Shape[1];
            double[,] jointLogLikelihood = new double[count, classCount];

            double[,] variance = (double[,])((Dim2DoubleNumpyWrapper)sigma.GetWrapper()).RawArray;
            double[,] mean = (double[,])((Dim2DoubleNumpyWrapper)theta.GetWrapper()).RawArray;


            for (int cls = 0; cls < classCount; cls++)
            {
                double sumOfLogVariance = 0;

                for (int feature = 0; feature < featureCount; feature++)
                {
                    sumOfLogVariance += Math.Log(2.0 * Math.PI * variance[cls, feature]);
                }

                double jointi = Math.Log(classPriors.Get(cls));

                for (int i = 0; i < count; i++)
                {
                    double value = 0;

                    for (int feature = 0; feature < featureCount; feature++)
                    {
                        double diff = x.Get(i, feature) - mean[cls, feature];
                        value += (Math.Pow(x.Get(i, feature) - mean[cls, feature], 2) / variance[cls, feature]);
                    }

                    value = -0.5 * (sumOfLogVariance + value);
                    jointLogLikelihood[i, cls] = value + jointi;
                }
            }

            return NumpyArrayFactory.From(jointLogLikelihood);
        }
    }
}