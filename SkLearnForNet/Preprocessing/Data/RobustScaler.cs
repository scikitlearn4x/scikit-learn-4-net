// ==================================================================
// Inference for RobustScaler
// 
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.RobustScaler.html#sklearn.preprocessing.RobustScaler
// ==================================================================

using SkLearn.Base;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Preprocessing.Data
{
    /// <summary>
    /// Scale features using statistics that are robust to outliers.
    /// This Scaler removes the median and scales the data according to the
    /// quantile range (defaults to IQR: Interquartile Range). The IQR is the
    /// range between the 1st quartile (25th quantile) and the 3rd quartile
    /// (75th quantile).
    /// Centering and scaling happen independently on each feature by
    /// computing the relevant statistics on the samples in the training set.
    /// Median and interquartile range are then stored to be used on later
    /// data using the :meth:`transform` method.
    /// Standardization of a dataset is a common requirement for many machine
    /// learning estimators. Typically this is done by removing the mean and
    /// scaling to unit variance. However, outliers can often influence the
    /// sample mean / variance in a negative way. In such cases, the median
    /// and the interquartile range often give better results.
    /// .. versionadded:: 0.17
    /// </summary>
    public class RobustScaler : TransformerMixin<NumpyArray<double>, NumpyArray<double>>
    {
        /// <summary>
        /// Instantiate a new object of RobustScaler.
        /// </summary>
        public RobustScaler()
        {
            UnitVariance = true;
            WithCentering = true;
            WithScaling = true;
        }

        /// <summary>
        /// The median value for each feature in the training set.
        /// </summary>
        public NumpyArray<double> Center { get; internal set; }

        /// <summary>
        /// The (scaled) interquartile range for each feature in the training
        /// set.
        /// </summary>
        public NumpyArray<double> Scale { get; internal set; }

        /// <summary>
        /// If True, center the data before scaling.
        /// </summary>
        public bool WithCentering { get; internal set; }

        /// <summary>
        /// If True, scale the data to interquartile range.
        /// </summary>
        public bool WithScaling { get; internal set; }

        /// <summary>
        /// If True, scale data so that normally distributed features have a variance of 1. In general,
        /// if the difference between the x-values of q_max and q_min for a standard normal distribution
        /// is greater than 1, the dataset will be scaled down. If less than 1, the dataset will be scaled
        /// up.
        /// </summary>
        public bool UnitVariance { get; internal set; }

        /// <summary>
        /// Quantile range used to calculate scale_. By default this is equal to the IQR, i.e., q_min is
        /// the first quantile and q_max is the third quantile.
        /// </summary>
        public double[] QuantilesRange { get; internal set; }

        /// <summary>
        /// Number of features seen during `fit`.
        /// </summary>
        public long NumberOfFeatures { get; internal set; }

        /// <summary>
        /// Names of features seen during `fit`. Defined only when `X` has feature
        /// names that are all strings.
        /// </summary>
        public String[] FeatureNames{ get; internal set; }
        
        /// <summary>
        /// Takes the input array and transforms it.
        /// <param name="array">The array to transform.</param>
        /// <returns>The transformed array.</returns>
        /// </summary>
        public override NumpyArray<double> Transform(NumpyArray<double> array)
        {
            NumpyArray<double> result = array;

            if (WithCentering)
            {
                result = Numpy.Subtract<double, double, double>(result, Center);
            }

            if (WithScaling)
            {
                result = Numpy.Divide(result, Scale);
            }

            return result;
        }

        /// <summary>
        /// Takes a transformed array and reveres the transformation.
        /// <param name="array">The array to apply reveres transform.</param>
        /// <returns>The inversed transform of array.</returns>
        /// </summary>
        public override NumpyArray<double> InverseTransform(NumpyArray<double> array)
        {
            NumpyArray<double> result = array;

            if (WithScaling)
            {
                result = Numpy.Multiply(result, Scale);
            }

            if (WithCentering)
            {
                result = Numpy.Add<double, double, double>(result, Center);
            }

            return result;
        }
    }
}