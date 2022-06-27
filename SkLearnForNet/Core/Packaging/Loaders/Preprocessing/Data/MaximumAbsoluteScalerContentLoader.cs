// ==================================================================
// Deserialize MaxAbsScaler
//
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.MaxAbsScaler.html#sklearn.preprocessing.MaxAbsScaler
// ==================================================================

using SkLearn.Core.Libraries.Numpy;
using SkLearn.Preprocessing.Data;

namespace SkLearn.Core.Packaging.Loaders.Preprocessing.Data
{
    /// <summary>
    /// MaximumAbsoluteScaler object loader.
    /// </summary>
    public class MaximumAbsoluteScalerContentLoader : BaseScikitLearnContentLoader<MaximumAbsoluteScaler>
    {
        /// <summary>
        /// Instantiate a new object of MaximumAbsoluteScalerContentLoader.
        /// </summary>
        public MaximumAbsoluteScalerContentLoader() : base("pp_max_abs_scaler")
        {
        }

        /// <summary>
        /// Instantiate an unloaded MaximumAbsoluteScaler scikit-learn object.
        /// <returns>The unloaded scikit-learn object.</returns>
        /// </summary>
        protected override MaximumAbsoluteScaler CreateResultObject()
        {
            return new MaximumAbsoluteScaler();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new MaximumAbsoluteScalerContentLoader();
        }

        /// <summary>
        /// Defines the fields that are required to initialize a trained scikit-learn object.
        /// </summary>
        protected override void RegisterSetters()
        {
            // Fields from the documentation
            RegisterNumpyArrayField("scale_", SetScale);
            RegisterNumpyArrayField("max_abs_", SetMaxAbs);
            RegisterLongField("n_features", SetNFeaturesIn);
            RegisterStringArrayField("feature_names", SetFeatureNamesIn);
            RegisterLongField("n_samples_seen_", SetNSamplesSeen);
        }

        /// <summary>
        /// Sets the Per feature relative scaling of the data.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetScale(MaximumAbsoluteScaler result, Object value)
        {
            result.Scale = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the Per feature maximum absolute value.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetMaxAbs(MaximumAbsoluteScaler result, Object value)
        {
            result.MaxAbsolute = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the Number of features seen during `fit`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNFeaturesIn(MaximumAbsoluteScaler result, long value)
        {
            result.NumberOfFeatures = value;
        }

        /// <summary>
        /// Sets the Names of features seen during `fit`. Defined only when `X` has feature
        /// names that are all strings.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetFeatureNamesIn(MaximumAbsoluteScaler result, String[] value)
        {
            result.FeatureNames = value;
        }

        /// <summary>
        /// Sets the The number of samples processed by the estimator. Will be reset on new
        /// calls to fit, but increments across `partial_fit` calls.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNSamplesSeen(MaximumAbsoluteScaler result, long value)
        {
            result.NumberOfSamplesSeen = value;
        }
    }
}