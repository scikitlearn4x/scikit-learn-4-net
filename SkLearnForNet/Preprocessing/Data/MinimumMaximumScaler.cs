// ==================================================================
// Inference for MinMaxScaler
// 
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.MinMaxScaler.html#sklearn.preprocessing.MinMaxScaler
// ==================================================================

using SkLearn.Base;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Preprocessing.Data
{
    /// <summary>
    /// Transform features by scaling each feature to a given range.
    /// This estimator scales and translates each feature individually such
    /// that it is in the given range on the training set, e.g. between zero
    /// and one.
    /// The transformation is given by::
    /// X_std = (X - X.min(axis=0)) / (X.max(axis=0) - X.min(axis=0))
    /// X_scaled = X_std * (max - min) + min
    /// where min, max = feature_range.
    /// This transformation is often used as an alternative to zero mean, unit
    /// variance scaling.
    /// </summary>
    public class MinimumMaximumScaler : TransformerMixin<NumpyArray<double>, NumpyArray<double>>
    {
        /// <summary>
        /// Instantiate a new object of MinimumMaximumScaler.
        /// </summary>
        public MinimumMaximumScaler()
        {
        }

        /// <summary>
        /// Per feature adjustment for minimum. Equivalent to `min - X.min(axis=0)
        /// * self.scale_`
        /// </summary>
        public NumpyArray<double> Min { get; internal set; }

        /// <summary>
        /// Per feature relative scaling of the data. Equivalent to `(max - min) /
        /// (X.max(axis=0) - X.min(axis=0))`
        /// </summary>
        public NumpyArray<double> Scale { get; internal set; }

        /// <summary>
        /// Per feature minimum seen in the data
        /// </summary>
        public NumpyArray<double> DataMin { get; internal set; }

        /// <summary>
        /// Per feature maximum seen in the data
        /// </summary>
        public NumpyArray<double> DataMax { get; internal set; }

        /// <summary>
        /// Per feature range `(data_max_ - data_min_)` seen in the data
        /// </summary>
        public NumpyArray<double> DataRange { get; internal set; }

        /// <summary>
        /// Number of features seen during `fit`.
        /// </summary>
        public long NumberOfFeatures { get; internal set; }

        /// <summary>
        /// The number of samples processed by the estimator. It will be reset on
        /// new calls to fit, but increments across `partial_fit` calls.
        /// </summary>
        public long NumberOfSamplesSeen { get; internal set; }

        /// <summary>
        /// Names of features seen during `fit`. Defined only when `X` has feature
        /// names that are all strings.
        /// </summary>
        public String[] FeatureNames { get; internal set; }

        /// <summary>
        /// Internal field of scikit-learn object.
        /// </summary>
        public bool Clip { get; internal set; }

        /// <summary>
        /// Internal field of scikit-learn object.
        /// </summary>
        public double[] FeatureRange { get; internal set; }

        /// <summary>
        /// Takes the input array and transforms it.
        /// <param name="array">The array to transform.</param>
        /// <returns>The transformed array.</returns>
        /// </summary>
        public override NumpyArray<double> Transform(NumpyArray<double> array)
        {
            NumpyArray<double> result = Numpy.Multiply(array, Scale);
            result = Numpy.Add<double, double, double>(result, Min);

            if (Clip)
            {
                result = Numpy.Clip(result, FeatureRange[0], FeatureRange[1]);
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
            NumpyArray<double> result = Numpy.Subtract<double, double, double>(array, Min);
            result = Numpy.Divide(result, Scale);

            return result;
        }
    }
}