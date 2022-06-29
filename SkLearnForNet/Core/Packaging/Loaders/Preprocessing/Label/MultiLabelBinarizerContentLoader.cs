// ==================================================================
// Deserialize MultiLabelBinarizer
// 
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.MultiLabelBinarizer.html
// ==================================================================

using SkLearn.Preprocessing.Label;

namespace SkLearn.Core.Packaging.Loaders.Preprocessing.Label
{
    /// <summary>
    /// MultiLabelBinarizer object loader.
    /// </summary>
    public class MultiLabelBinarizerContentLoader : BaseScikitLearnContentLoader<MultiLabelBinarizer>
    {
        /// <summary>
        /// Instantiate a new object of MultiLabelBinarizerContentLoader.
        /// </summary>
        public MultiLabelBinarizerContentLoader() : base("pp_multilabel_binarizer")
        {
        }

        /// <summary>
        /// Instantiate an unloaded MultiLabelBinarizer scikit-learn object.
        /// <returns>The unloaded scikit-learn object.</returns>
        /// </summary>
        protected override MultiLabelBinarizer CreateResultObject()
        {
            return new MultiLabelBinarizer();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new MultiLabelBinarizerContentLoader();
        }

        /// <summary>
        /// Defines the fields that are required to initialize a trained scikit-learn object.
        /// </summary>
        protected override void RegisterSetters()
        {
            // Fields from the documentation
            RegisterListField("classes_", SetClasses);

            // Fields from the dir() method
            RegisterDictionaryField("_cached_dict", SetCachedDict);
        }

        /// <summary>
        /// Sets the A copy of the `classes` parameter when provided. Otherwise it
        /// corresponds to the sorted set of classes found when fitting.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetClasses(MultiLabelBinarizer result, List<Object> value)
        {
            result.Classes = value;
        }

        /// <summary>
        /// Sets the _cached_dict field.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetCachedDict(MultiLabelBinarizer result, Dictionary<String, Object> value)
        {
            result.CachedDict = value;
        }
    }
}