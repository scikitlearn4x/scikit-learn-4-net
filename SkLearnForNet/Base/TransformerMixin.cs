namespace SkLearn.Base
{
    /// <summary>
    /// Mixin class for all transformers in scikit-learn.
    /// </summary>
    /// <typeparam name="InputType">Type of the input for the transformation.</typeparam>
    /// <typeparam name="OutputType">Type of the output for the transformation.</typeparam>
    public abstract class TransformerMixin<InputType, OutputType>
    {
        /// <summary>
        /// Takes the input array and transforms it.
        /// <param name="array">The array to transform.</param>
        /// <returns>The transformed array.</returns>
        /// </summary>
        public abstract OutputType Transform(InputType array);
        
        /// <summary>
        /// Takes a transformed array and reveres the transformation.
        /// <param name="array">The array to apply reveres transform.</param>
        /// <returns>The inversed transform of array.</returns>
        /// </summary>
        public abstract InputType InverseTransform(OutputType array);
    }
}