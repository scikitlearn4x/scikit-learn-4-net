// ==================================================================
// Deserialize Binarizer
//
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.Binarizer.html#sklearn.preprocessing.Binarizer
// ==================================================================

using SkLearn.Preprocessing.Data;

namespace SkLearn.Core.Packaging.Loaders.Preprocessing.Data
{
    /// <summary>
    /// Binarizer object loader.
    /// </summary>
    public class BinarizerContentLoader : BaseScikitLearnContentLoader<Binarizer>
    {
        /// <summary>
        /// Instantiate a new object of BinarizerContentLoader.
        /// </summary>
        public BinarizerContentLoader() : base("pp_binarizer")
        {
        }

        /// <summary>
        /// Instantiate an unloaded Binarizer scikit-learn object.
        /// <returns>The unloaded scikit-learn object.</returns>
        /// </summary>
        protected override Binarizer CreateResultObject()
        {
            return new Binarizer();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new BinarizerContentLoader();
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
            RegisterDoubleField("threshold", SetThreshold);
        }

        /// <summary>
        /// Feature values below or equal to this are replaced by 0, above it by 1. Threshold may not be
        /// less than 0 for operations on sparse matrices.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetThreshold(Binarizer result, double value)
        {
            result.Threshold = value;
        }

        /// <summary>
        /// Sets the Number of features seen during `fit`.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNFeaturesIn(Binarizer result, long value)
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
        private void SetFeatureNamesIn(Binarizer result, String[] value)
        {
            result.FeatureNames = value;
        }
    }
}