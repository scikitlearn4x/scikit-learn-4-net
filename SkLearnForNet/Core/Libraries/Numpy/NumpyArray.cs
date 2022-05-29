using System;
using SkLearn.Core.Libraries.Numpy.Wrappers;

namespace SkLearn.Core.Libraries.Numpy
{
    /// <summary>
    /// An interface to provide a unified view of the operations that can be performed on the elements of a NumpyArray.
    /// </summary>
    /// <typeparam name="ElementType">Type of the array element's type.</typeparam>
    public delegate ElementType NumpyArrayElementOperation<ElementType>(ElementType value);

    /// <summary>
    /// An interface to provide a unified view of the operations that can be performed by iterating on the elements of a NumpyArray.
    /// </summary>
    /// <typeparam name="ElementType">Type of the array element's type.</typeparam>
    public delegate void NumpyArrayElementIterateOperation<in ElementType>(ElementType value, int[] index);

    /// <summary>
    /// Provide the functionality of the Numpy arrays and an abstraction over the element types.
    /// </summary>
    /// <typeparam name="ElementType">Type of the elements of the array.</typeparam>
    public class NumpyArray<ElementType> : INumpyArray where ElementType : struct
    {
        /// <summary>
        /// The internal data of the array.
        /// </summary>
        private INumpyArrayWrapper<ElementType> data = null;

        /// <summary>
        /// Instantiate new object of NumpyArray.
        /// </summary>
        /// <param name="data">The content of the numpy array.</param>
        public NumpyArray(INumpyArrayWrapper<ElementType> data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets the shape of the numpy array.
        /// </summary>
        public int[] Shape
        {
            get { return data.Shape; }
        }

        /// <summary>
        /// Gets an element in the array specified by it index.
        /// <param name="indices">The index of the element to be retrieved.</param>
        /// <returns>The element value in the array specified by its index.</returns>
        /// </summary>
        public ElementType Get(params int[] indices)
        {
            if (indices.Length != Shape.Length)
            {
                throw new NumpyOperationException("The number of indices provided doesn't match the number of dimensions.");
            }

            return data.Get(indices);
        }

        /// <summary>
        /// Applies a provided operation on every element of the array and stores it in the
        /// same array.
        /// <param name="operation">The operation to be applied on the elements.</param>
        /// </summary>
        public void ApplyToEachElement(NumpyArrayElementOperation<ElementType> operation)
        {
            int[] shape = data.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                data.Set(operation((ElementType)data.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);
        }

        /// <summary>
        /// Applies a provided operation on every element of the array and stores it in a
        /// specified target array.
        /// <param name="target">The array that the result should be stored into.</param>
        /// <param name="operation">The operation to be applied on the elements.</param>
        /// </summary>
        public void ApplyToEachElementAnsSaveToTarget(NumpyArray<ElementType> target, NumpyArrayElementOperation<ElementType> operation)
        {
            int[] shape = data.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                target.Set(operation(data.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);
        }

        /// <summary>
        /// Iterates on each element of the array and calls a callback.
        /// </summary>
        /// <param name="operation">The callback to be called for each element.</param>
        public void IterateOnEachElement(NumpyArrayElementIterateOperation<ElementType> operation)
        {
            int[] shape = data.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                operation(data.Get(index), index);
            } while (counter[counter.Length - 1] == 0);
        }

        /// <summary>
        /// The numpy array could be multidimensional. To iterate over the element given that the
        /// dimension is dynamic, a counter is used. This method increase the value of the counter
        /// to move the index to the next element.
        /// <param name="counter">The current index.</param>
        /// <param name="shape">The shape of the array.</param>
        /// </summary>
        internal static void AddCounter(int[] counter, int[] shape)
        {
            counter[0]++;

            for (int i = 0; i < shape.Length; i++)
            {
                if (counter[i] == shape[i])
                {
                    counter[i] = 0;
                    counter[i + 1]++;
                }
                else
                {
                    break;
                }
            }
        }


        /// <summary>
        /// Sets an element in the array specified by it index.
        /// <param name="value">The value to be set.</param>
        /// <param name="indices">The index of the element to be modified.</param>
        /// </summary>
        public void Set(ElementType value, params int[] indices)
        {
            data.Set(value, indices);
        }

        /// <summary>
        /// Returns a boolean indicating if the underlying data type is floating numbers or not.
        /// </summary>
        public bool IsFloatingPoint
        {
            get { return data.IsFloatingPoint; }
        }

        /// <summary>
        /// Gets the number of bytes allocated in memory for each element.
        /// </summary>
        public int NumberOfBytes
        {
            get { return data.NumberOfBits / 8; }
        }

        /// <summary>
        /// Transposes an array by reversing the order of its dimensions.
        /// <returns>The transposed array.</returns>
        /// </summary>
        public NumpyArray<ElementType> Transpose()
        {
            return data.Transpose();
        }

        /// <summary>
        /// Returns a boolean indicating if the array contains only a single element.
        /// <returns>A boolean indicating if the array contains only a single element.</returns>
        /// </summary>
        public bool IsSingleValueArray()
        {
            int count = 1;
            int[] shape = Shape;

            for (int i = 0; i < shape.Length; i++)
            {
                count *= shape[i];
            }

            return count == 1;
        }

        /// <summary>
        /// Gets the first element of the numpy array from its memory layout.
        /// <returns>The first element of the array.</returns>
        /// </summary>
        public ElementType GetSingleValue()
        {
            int[] shape = Shape;
            int[] index = new int[shape.Length];

            return data.Get(index);
        }

        /// <summary>
        /// Wraps a subset of the numpy array. This methods works only when slicing the most inner dimensions
        /// of the array. For example, if the shape is [2, 6, 4, 8], wrapInnerSubsetArray(1, 3) is equivalent
        /// to numpy array[1, 3, :, :].
        /// <param name="indices">The indices of the first dimensions to keep.</param>
        /// <returns>A new INumpyArrayWrapper wrapping the inner dimensions. This array has the same reference.</returns>
        /// </summary>
        public NumpyArray<ElementType> WrapInnerSubsetArray(params int[] indices)
        {
            return data.WrapInnerSubsetArray(indices);
        }

        /// <summary>
        /// Gets the number of dimensions of the numpy array.
        /// </summary>
        public int NumberOfDimensions
        {
            get { return Shape.Length; }
        }

        /// <summary>
        /// Gets the object that wraps the underlying array.
        /// <returns>The object that wraps the underlying array.</returns>
        /// </summary>
        public INumpyArrayWrapper<ElementType> GetWrapper()
        {
            return data;
        }

        /// <summary>
        /// Implementation of INumpyArray to get the underlying array.
        /// </summary>
        /// <returns>The underlying array.</returns>
        Array INumpyArray.GetUnderlyingArray()
        {
            return (Array)GetWrapper().RawArray;
        }
    }
}