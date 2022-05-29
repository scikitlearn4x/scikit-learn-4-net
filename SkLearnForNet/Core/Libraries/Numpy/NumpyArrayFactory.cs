using System;
using SkLearn.Core.Libraries.Numpy.Wrappers;

namespace SkLearn.Core.Libraries.Numpy
{
    public partial class NumpyArrayFactory
    {
        /// <summary>
        /// Number of bytes used to allocate a byte.
        /// </summary>
        public const int SIZE_OF_INT_8 = 1;

        /// <summary>
        /// Number of bytes used to allocate a short.
        /// </summary>
        public const int SIZE_OF_INT_16 = 2;

        /// <summary>
        /// Number of bytes used to allocate an int.
        /// </summary>
        public const int SIZE_OF_INT_32 = 4;
        
        /// <summary>
        /// Number of bytes used to allocate a long.
        /// </summary>
        public const int SIZE_OF_INT_64 = 8;
        
        /// <summary>
        /// Number of bytes used to allocate a float.
        /// </summary>
        public const int SIZE_OF_FLOAT = 4;
        
        /// <summary>
        /// Number of bytes used to allocate a double.
        /// </summary>
        public const int SIZE_OF_DOUBLE = 8;

        /// <summary>
        /// Wraps a subset of the numpy array. This methods works only when slicing the most inner dimensions
        /// of the array. For example, if the shape is [2, 6, 4, 8], WrapInnerSubsetArray(1, 3) is equivalent
        /// to numpy array[1, 3, :, :].
        /// <param name="source">The input array to slice from.</param>
        /// <param name="indices">The indices of the first dimensions to keep.</param>
        /// <returns>A new INumpyArrayWrapper wrapping the inner dimensions. This array doesn't have the same reference.</returns>
        /// </summary>
        internal static Array WrapInnerSubsetArray(Array source, int[] indices)
        {
            int[] outputShape = new int[source.Rank - indices.Length];
            for (int i = 0; i < outputShape.Length; i++)
            {
                outputShape[i] = source.GetLength(indices.Length + i);
            }

            Array result = Array.CreateInstance(source.GetType().GetElementType(), outputShape);

            int[] index = new int[outputShape.Length];
            int[] counter = new int[outputShape.Length + 1];
            int[] inputIndex = new int[source.Rank];

            for (int i = 0; i < indices.Length; i++)
            {
                inputIndex[i] = indices[i];
            }

            counter[0] = -1;

            do
            {
                NumpyArray<int>.AddCounter(counter, outputShape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                    inputIndex[i + indices.Length] = counter[i];
                }

                result.SetValue(source.GetValue(inputIndex), index);
            } while (counter[counter.Length - 1] == 0);

            return result;
        }

        /// <summary>
        /// Creates a numpy array with a specified shape that can store values with specified
        /// characteristics.
        /// <param name="isFloatingPoint">Indicates if the elements are floating point.</param>
        /// <param name="size">Indicates the number of bytes each element should allocate in memory.</param>
        /// <param name="shape">Shape of the desired new array.</param>
        /// <returns>An array of the specified shape and data characteristics.</returns>
        /// </summary>
        public static NumpyArray<OutputType> CreateArrayOfShapeAndTypeInfo<OutputType>(bool isFloatingPoint, int size, int[] shape) where OutputType : struct
        {
            Object result = null;

            if (isFloatingPoint)
            {
                if (size == 8)
                {
                    result = ArrayOfDoubleWithShape(shape);
                }
                else
                {
                    result = ArrayOfFloatWithShape(shape);
                }
            }
            else
            {
                if (size == 8)
                {
                    result = ArrayOfInt64WithShape(shape);
                }
                else if (size == 4)
                {
                    result = ArrayOfInt32WithShape(shape);
                }
                else if (size == 2)
                {
                    result = ArrayOfInt16WithShape(shape);
                }
                else if (size == 1)
                {
                    result = ArrayOfInt8WithShape(shape);
                }
            }

            return (NumpyArray<OutputType>)result;
        }
    }
}