// ==================================================================
// Deserialize RobustScaler
// 
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.RobustScaler.html#sklearn.preprocessing.RobustScaler
// ==================================================================

using SkLearn.Core.Libraries.Numpy;
using SkLearn.Preprocessing.Data;

namespace SkLearn.Core.Packaging.Loaders.Preprocessing.Data
{
    /// <summary>
    /// RobustScaler object loader.
    /// </summary>
    public class RobustScalerContentLoader : BaseScikitLearnContentLoader<RobustScaler>
    {
        /// <summary>
        /// Instantiate a new object of RobustScalerContentLoader.
        /// </summary>
        public RobustScalerContentLoader() : base("pp_robust_scaler")
        {
        }

        /// <summary>
        /// Instantiate an unloaded RobustScaler scikit-learn object.
        /// <returns>The unloaded scikit-learn object.</returns>
        /// </summary>
        protected override RobustScaler CreateResultObject()
        {
            return new RobustScaler();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new RobustScalerContentLoader();
        }

        /// <summary>
        /// Defines the fields that are required to initialize a trained scikit-learn object.
        /// </summary>
        protected override void RegisterSetters()
        {
            // Fields from the documentation
            RegisterNumpyArrayField("center_", SetCenter);
            RegisterNumpyArrayField("scale_", SetScale);
            RegisterLongField("n_features", SetNFeaturesIn);
            RegisterStringArrayField("feature_names", SetFeatureNamesIn);

            // Fields from dir()
            RegisterLongField("with_scaling", SetWithScaling);
            RegisterLongField("with_centering", SetWithCentering);
            RegisterLongField("unit_variance", SetUnitVariance);
            RegisterListField("quantile_range", SetQuantileRange);
        }

        /// <summary>
        /// Sets the value of the field `quantile_range`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetQuantileRange(RobustScaler result, List<Object> value)
        {
            double[] quantilesRange = new double[2];
            quantilesRange[0] = (double)value[0];
            quantilesRange[1] = (double)value[1];

            result.QuantilesRange = quantilesRange;
        }

        /// <summary>
        /// Sets the value of the field `unit_variance`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetUnitVariance(RobustScaler result, long value)
        {
            result.UnitVariance = (value == 1);
        }

        /// <summary>
        /// Sets the value of the field `with_centering`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetWithCentering(RobustScaler result, long value)
        {
            result.WithCentering = (value == 1);
        }

        /// <summary>
        /// Sets the value of the field `with_scaling`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetWithScaling(RobustScaler result, long value)
        {
            result.WithCentering = (value == 1);
        }

        /// <summary>
        /// Sets the The median value for each feature in the training set.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetCenter(RobustScaler result, Object value)
        {
            result.Center = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the The (scaled) interquartile range for each feature in the training
        /// set.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetScale(RobustScaler result, Object value)
        {
            result.Scale = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the Number of features seen during `fit`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNFeaturesIn(RobustScaler result, long value)
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
        private void SetFeatureNamesIn(RobustScaler result, String[] value)
        {
            result.FeatureNames = value;
        }
    }
}