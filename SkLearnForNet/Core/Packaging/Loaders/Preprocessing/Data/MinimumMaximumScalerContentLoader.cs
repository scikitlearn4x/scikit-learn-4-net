// ==================================================================
// Deserialize MinMaxScaler
// 
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.MinMaxScaler.html#sklearn.preprocessing.MinMaxScaler
// ==================================================================

using SkLearn.Core.Libraries.Numpy;
using SkLearn.Preprocessing.Data;

namespace SkLearn.Core.Packaging.Loaders.Preprocessing.Data
{
    /// <summary>
    /// MinimumMaximumScaler object loader.
    /// </summary>
    public class MinimumMaximumScalerContentLoader : BaseScikitLearnContentLoader<MinimumMaximumScaler>
    {
        /// <summary>
        /// Instantiate a new object of MinimumMaximumScalerContentLoader.
        /// </summary>
        public MinimumMaximumScalerContentLoader() : base("pp_min_max_scaler")
        {
        }

        /// <summary>
        /// Instantiate an unloaded MinimumMaximumScaler scikit-learn object.
        /// <returns>The unloaded scikit-learn object.</returns>
        /// </summary>
        protected override MinimumMaximumScaler CreateResultObject()
        {
            return new MinimumMaximumScaler();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new MinimumMaximumScalerContentLoader();
        }

        /// <summary>
        /// Defines the fields that are required to initialize a trained scikit-learn object.
        /// </summary>
        protected override void RegisterSetters()
        {
// Fields from the documentation
            RegisterNumpyArrayField("min_", SetMin);
            RegisterNumpyArrayField("scale_", SetScale);
            RegisterNumpyArrayField("data_min_", SetDataMin);
            RegisterNumpyArrayField("data_max_", SetDataMax);
            RegisterNumpyArrayField("data_range_", SetDataRange);
            RegisterLongField("n_features", SetNFeaturesIn);
            RegisterLongField("n_samples_seen_", SetNSamplesSeen);
            RegisterStringArrayField("feature_names", SetFeatureNamesIn);

            // Fields from the dir() method
            RegisterLongField("clip", SetClip);
            RegisterListField("feature_range", SetFeatureRange);
        }

        /// <summary>
        /// Sets the Per feature adjustment for minimum. Equivalent to `min - X.min(axis=0)
        /// * self.scale_`
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetMin(MinimumMaximumScaler result, Object value)
        {
            result.Min = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the Per feature relative scaling of the data. Equivalent to `(max - min) /
        /// (X.max(axis=0) - X.min(axis=0))`
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetScale(MinimumMaximumScaler result, Object value)
        {
            result.Scale = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the Per feature minimum seen in the data
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetDataMin(MinimumMaximumScaler result, Object value)
        {
            result.DataMin = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the Per feature maximum seen in the data
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetDataMax(MinimumMaximumScaler result, Object value)
        {
            result.DataMax = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the Per feature range `(data_max_ - data_min_)` seen in the data
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetDataRange(MinimumMaximumScaler result, Object value)
        {
            result.DataRange = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the Number of features seen during `fit`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNFeaturesIn(MinimumMaximumScaler result, long value)
        {
            result.NumberOfFeatures = value;
        }

        /// <summary>
        /// Sets the The number of samples processed by the estimator. It will be reset on
        /// new calls to fit, but increments across `partial_fit` calls.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNSamplesSeen(MinimumMaximumScaler result, long value)
        {
            result.NumberOfSamplesSeen = value;
        }

        /// <summary>
        /// Sets the Names of features seen during `fit`. Defined only when `X` has feature
        /// names that are all strings.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetFeatureNamesIn(MinimumMaximumScaler result, String[] value)
        {
            result.FeatureNames = value;
        }

        /// <summary>
        /// Sets the clip field.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetClip(MinimumMaximumScaler result, long value)
        {
            result.Clip = (value == 1);
        }

        /// <summary>
        /// Sets the feature_range field.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetFeatureRange(MinimumMaximumScaler result, List<Object> value)
        {
            double[] data = new double[value.Count];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = double.Parse(value[i].ToString()); // WTF C#?!
            }

            result.FeatureRange = data;
        }
    }
}