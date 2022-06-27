// ==================================================================
// Deserialize Normalizer
//
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.Normalizer.html#sklearn.preprocessing.Normalizer
// ==================================================================

using SkLearn.Preprocessing.Data;

namespace SkLearn.Core.Packaging.Loaders.Preprocessing.Data
{
    /// <summary>
    /// Normalizer object loader.
    /// </summary>
    public class NormalizerContentLoader : BaseScikitLearnContentLoader<Normalizer>
    {
        /// <summary>
        /// Instantiate a new object of NormalizerContentLoader.
        /// </summary>
        public NormalizerContentLoader() : base("pp_normalizer")
        {
        }

        /// <summary>
        /// Instantiate an unloaded Normalizer scikit-learn object.
        /// <returns>The unloaded scikit-learn object.</returns>
        /// </summary>
        protected override Normalizer CreateResultObject()
        {
            return new Normalizer();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new NormalizerContentLoader();
        }

        /// <summary>
        /// Defines the fields that are required to initialize a trained scikit-learn object.
        /// </summary>
        protected override void RegisterSetters()
        {
            // Fields from the documentation
            RegisterLongField("n_features", SetNFeaturesIn);
            RegisterStringArrayField("feature_names", SetFeatureNamesIn);

            // Fields from the dir() method
            RegisterStringField("norm", SetNorm);
        }

        /// <summary>
        /// Sets the method for calculating the vectors norm.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNorm(Normalizer result, String value)
        {
            result.Norm = value;
        }

        /// <summary>
        /// Sets the Number of features seen during `fit`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNFeaturesIn(Normalizer result, long value)
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
        private void SetFeatureNamesIn(Normalizer result, String[] value)
        {
            result.FeatureNames = value;
        }
    }
}