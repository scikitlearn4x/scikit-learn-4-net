using System;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.NaiveBayes;

namespace SkLearn.NaiveBayes
{
    /// <summary>
    /// Naive Bayes classifier for categorical features.
    /// The categorical Naive Bayes classifier is suitable for classification with discrete features that
    /// are categorically distributed. The categories of each feature are drawn from a categorical
    /// distribution.
    /// </summary>
    public class CategoricalNaiveBayes : BaseNaiveBayes
    {
        /// <summary>
        /// Gets the empirical log probability of features given a class, P(x_i|y).
        /// </summary>
        public List<NumpyArray<double>> FeatureLogProbabilities { get; internal set; }

        /// <summary>
        /// Gets the log probability of each class (smoothed).
        /// </summary>
        public NumpyArray<double> ClassLogPrior { get; internal set; }

        /// <summary>
        /// Holds arrays of shape (n_classes, n_categories of respective feature) for each feature.
        /// Each array provides the number of samples encountered for each class and category of the
        /// specific feature.
        /// </summary>
        public NumpyArray<double> CategoryCounts { get; internal set; }

        /// <summary>
        /// Number of categories for each feature. This value is inferred from the data or set by the
        /// minimum number of categories.
        /// </summary>
        public NumpyArray<long> NumberOfCategories { get; internal set; }

        /// <summary>
        /// Compute the unnormalized posterior log probability of X.
        /// I.e. ``log P(c) + log P(x|c)`` for all rows x of X, as an array-like of shape
        /// (n_samples, n_classes).
        /// predict, predictProbabilities, and predictLogProbabilities pass the input over to
        /// jointLogLikelihood.
        /// <param name="x">An array-like of shape (n_samples, n_classes).
        /// </param>
        /// </summary>
        protected override NumpyArray<double> JointLogLikelihood(NumpyArray<double> x)
        {
            NumpyArray<double> jll = NumpyArrayFactory.ArrayOfDoubleWithShape(new int[] { x.Shape[0], ClassCounts.Shape[0] });
            for (int i = 0; i < NumberOfFeatures; i++)
            {
                int[] indices = GetArrayFirstDimension(x, i);
                NumpyArray<double> logProb = this.FeatureLogProbabilities[i];
                int classCount = Classes.Shape[0];
                double[,] temp = new double[classCount, indices.Length];

                for (int cls = 0; cls < classCount; cls++)
                {
                    for (int j = 0; j < indices.Length; j++)
                    {
                        temp[cls, j] = logProb.Get(cls, indices[j]);
                    }
                }

                NumpyArray<double> t = NumpyArrayFactory.From(temp).Transpose();
                jll = Numpy.Add<double, double, double>(jll, t);
            }

            return Numpy.Add<double, double, double>(jll, ClassLogPrior);
        }

        /// <summary>
        /// Gets the values of the first dimension. Equivalent to numpy data[:, secondDimensionIndex]
        /// <param name="x">Array to be sliced.</param>
        /// <param name="secondDimensionIndex">The value of the second dimension.
        /// </param>
        /// <returns>The sliced first dimension.</returns>
        /// </summary>
        private int[] GetArrayFirstDimension(NumpyArray<double> x, int secondDimensionIndex)
        {
            int[] indices = new int[x.Shape[0]];

            for (int j = 0; j < indices.Length; j++)
            {
                double value = x.Get(j, secondDimensionIndex);
                indices[j] = (int)value;
            }

            return indices;
        }
    }
}