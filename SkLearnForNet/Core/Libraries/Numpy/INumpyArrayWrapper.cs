using System;

namespace SkLearn.Core.Libraries.Numpy
{
    /// <summary>
    /// Unlike python, C# is a strongly typed language and all the fields should have a predefined type.
    /// This fact complicates the handling of data structures like Numpy arrays where the same interface
    /// is used for all data types. The INumpyArrayWrapper provide a unified view of the underlying data
    /// types.
    /// </summary>
    public interface INumpyArrayWrapper<ElementType> where ElementType: struct
    {
        /// <summary>
        /// Gets the shape of the underlying Numpy array.
        /// <returns>The shape of the array as an int[].</returns>
        /// </summary>
        int[] Shape
        {
            get;
        }

        /// <summary>
        /// Gets the value of a single element in the numpy array denoted by its indices.
        /// <param name="indices">The index of the element to be retrieved.</param>
        /// <returns>An object-wrapped instance of the element in the Numpy array.</returns>
        /// </summary>
        ElementType Get(params int[] indices);

        /// <summary>
        /// Sets the value of a single element in the numpy array denoted by its indices.
        /// <param name="value">The new value to be assigned to the numpy element.</param>
        /// <param name="index">The index of the element to be set.
        /// </param>
        /// </summary>
        void Set(ElementType value, params int[] index);

        /// <summary>
        /// Returns a boolean indicating that the underlying array type is a floating point one or not.
        /// </summary>
        bool IsFloatingPoint
        {
            get;
        }

        /// <summary>
        /// The space allocated by each element of the numpy array in terms of bits.
        /// </summary>
        int NumberOfBits
        {
            get;
        }

        /// <summary>
        /// Transposes a numpy array by reversing its dimensions.
        /// <returns>The transposed numpy array.</returns>
        /// </summary>
        NumpyArray<ElementType> Transpose();

        /// <summary>
        /// Wraps a subset of the numpy array. This methods works only when slicing the most inner dimensions
        /// of the array. For example, if the shape is [2, 6, 4, 8], WrapInnerSubsetArray(1, 3) is equivalent
        /// to numpy array[1, 3, :, :].
        /// <param name="indices">The indices of the first dimensions to keep.</param>
        /// <returns>A new INumpyArrayWrapper wrapping the inner dimensions. This array doesn't have the same reference.</returns>
        /// </summary>
        NumpyArray<ElementType> WrapInnerSubsetArray(params int[] indices);

        /// <summary>
        /// Gets the native array containing the numpy array data.
        /// </summary>
        Object RawArray
        {
            get;
        }
    }
}