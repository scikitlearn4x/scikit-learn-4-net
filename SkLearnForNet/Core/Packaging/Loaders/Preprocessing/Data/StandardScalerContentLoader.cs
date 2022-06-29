// ==================================================================
// Deserialize StandardScaler
//
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.StandardScaler.html#sklearn.preprocessing.StandardScaler
// ==================================================================

using SkLearn.Core.Libraries.Numpy;
using SkLearn.Preprocessing.Data;

namespace SkLearn.Core.Packaging.Loaders.Preprocessing.Data
{
    /// <summary>
    /// StandardScaler object loader.
    /// </summary>
    public class StandardScalerContentLoader : BaseScikitLearnContentLoader<StandardScaler>
    {
        /// <summary>
        /// Instantiate a new object of StandardScalerContentLoader.
        /// </summary>
        public StandardScalerContentLoader()
            :base("pp_standard_scaler")
        {
        }

        /// <summary>
        /// Instantiate an unloaded StandardScaler scikit-learn object.
        /// <returns>The unloaded scikit-learn object.</returns>
        /// </summary>
        protected override StandardScaler CreateResultObject()
        {
            return new StandardScaler();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new StandardScalerContentLoader();
        }

        /// <summary>
        /// Defines the fields that are required to initialize a trained scikit-learn object.
        /// </summary>
        protected override void RegisterSetters()
        {
// Fields from the documentation
            RegisterNumpyArrayField("scale_", SetScale);
            RegisterNumpyArrayField("mean_", SetMean);
            RegisterNumpyArrayField("var_", SetVar);
            RegisterLongField("n_features", SetNFeaturesIn);
            RegisterStringArrayField("feature_names", SetFeatureNamesIn);
            RegisterNumpyArrayField("n_samples_seen_", SetNSamplesSeen);

            // Fields from the dir() method
            RegisterLongField("with_mean", SetWithMean);
            RegisterLongField("with_std", SetWithStd);
        }

        /// <summary>
        /// Sets the Per feature relative scaling of the data to achieve zero mean and unit
        /// variance. Generally this is calculated using `np.sqrt(var_)`. If a
        /// variance is zero, we can't achieve unit variance, and the data is left
        /// as-is, giving a scaling factor of 1. `scale_` is equal to `None` when
        /// `with_std=False`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetScale(StandardScaler result, Object value)
        {
            result.Scale = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the The mean value for each feature in the training set. Equal to `None`
        /// when `with_mean=False`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetMean(StandardScaler result, Object value)
        {
            result.Mean = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the The variance for each feature in the training set. Used to compute
        /// `scale_`. Equal to `None` when `with_std=False`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetVar(StandardScaler result, Object value)
        {
            result.Variance = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the Number of features seen during `fit`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNFeaturesIn(StandardScaler result, long value)
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
        private void SetFeatureNamesIn(StandardScaler result, String[] value)
        {
            result.FeatureNames = value;
        }

        /// <summary>
        /// Sets the The number of samples processed by the estimator for each feature. If
        /// there are no missing samples, the `n_samples_seen` will be an integer,
        /// otherwise it will be an array of dtype int. If `sample_weights` are
        /// used it will be a float (if no missing data) or an array of dtype
        /// float that sums the weights seen so far. Will be reset on new calls to
        /// fit, but increments across `partial_fit` calls.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNSamplesSeen(StandardScaler result, Object value)
        {
            result.NumberOfSamplesSeen = (NumpyArray<long>)value;
        }

        /// <summary>
        /// Sets the with_mean field.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetWithMean(StandardScaler result, long value)
        {
            result.WithMean = (value == 1);
        }

        /// <summary>
        /// Sets the with_std field.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetWithStd(StandardScaler result, long value)
        {
            result.WithStandardDeviation = (value == 1);
        }
    }
}