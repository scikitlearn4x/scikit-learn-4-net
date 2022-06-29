using SkLearn.Core.Packaging.Loaders;
using SkLearn.Preprocessing.Label;

/// <summary>
/// LabelEncoder object loader.
/// </summary>
public class LabelEncoderContentLoader : BaseScikitLearnContentLoader<LabelEncoder>
{
    /// <summary>
    /// Instantiate a new object of LabelEncoderContentLoader.
    /// </summary>
    public LabelEncoderContentLoader() : base("pp_label_encoder")
    {
    }

    /// <summary>
    /// Instantiate an unloaded LabelEncoder scikit-learn object.
    /// <returns>The unloaded scikit-learn object.</returns>
    /// </summary>
    protected override LabelEncoder CreateResultObject()
    {
        return new LabelEncoder();
    }

    /// <summary>
    /// Create a clean instance of the loader.
    /// <returns>A clean instance of the loader.</returns>
    /// </summary>
    public override IScikitLearnContentLoader Duplicate()
    {
        return new LabelEncoderContentLoader();
    }

    /// <summary>
    /// Defines the fields that are required to initialize a trained scikit-learn object.
    /// </summary>
    protected override void RegisterSetters()
    {
        // Fields from the documentation
        RegisterListField("classes_", SetClasses);
    }

    /// <summary>
    /// Sets the Holds the label for each class.
    /// <param name="result">The scikit-learn object to be loaded.</param>
    /// <param name="value">The loaded value from stream.
    /// </param>
    /// </summary>
    private void SetClasses(LabelEncoder result, List<Object> value)
    {
        result.Classes = value;
    }
}