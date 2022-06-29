// ==================================================================
// Deserialize LabelBinarizer
//
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.LabelBinarizer.html
// ==================================================================

using SkLearn.Preprocessing.Label;

namespace SkLearn.Core.Packaging.Loaders.Preprocessing.Label
{
    /// <summary>
    /// LabelBinarizer object loader.
    /// </summary>
    public class LabelBinarizerContentLoader : BaseScikitLearnContentLoader<LabelBinarizer>
    {
        /// <summary>
        /// Instantiate a new object of LabelBinarizerContentLoader.
        /// </summary>
        public LabelBinarizerContentLoader() : base("pp_label_binarizer")
        {
        }

        /// <summary>
        /// Instantiate an unloaded LabelBinarizer scikit-learn object.
        /// <returns>The unloaded scikit-learn object.</returns>
        /// </summary>
        protected override LabelBinarizer CreateResultObject()
        {
            return new LabelBinarizer();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new LabelBinarizerContentLoader();
        }

        /// <summary>
        /// Defines the fields that are required to initialize a trained scikit-learn object.
        /// </summary>
        protected override void RegisterSetters()
        {
            // Fields from the documentation
            RegisterListField("classes_", SetClasses);
            RegisterStringField("y_type_", SetYType);

            // Fields from the dir() method
            RegisterLongField("neg_label", SetNegLabel);
            RegisterLongField("pos_label", SetPosLabel);
        }

        /// <summary>
        /// Sets the Holds the label for each class.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetClasses(LabelBinarizer result, List<Object> value)
        {
            result.Classes = value;
        }

        /// <summary>
        /// Sets the Represents the type of the target data as evaluated by
        /// utils.multiclass.type_of_target. Possible type are 'continuous',
        /// 'continuous-multioutput', 'binary', 'multiclass',
        /// 'multiclass-multioutput', 'multilabel-indicator', and 'unknown'.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.</param>
        /// </summary>
        private void SetYType(LabelBinarizer result, String value)
        {
            result.YType = value;
        }

        /// <summary>
        /// Sets the neg_label field.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetNegLabel(LabelBinarizer result, long value)
        {
            result.NegativeLabel = value;
        }

        /// <summary>
        /// Sets the pos_label field.
        /// <param name="result">The scikit-learn object to be loaded.</param>
        /// <param name="value">The loaded value from stream.
        /// </param>
        /// </summary>
        private void SetPosLabel(LabelBinarizer result, long value)
        {
            result.PositiveLabel = value;
        }
    }
}