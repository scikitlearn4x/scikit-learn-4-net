using System;

namespace SkLearn.Core.Libraries.Numpy
{
    /// <summary>
    /// The interface for a function that performs the reduction of an axis.
    /// </summary>
    /// <typeparam name="InputType">Type of the input array.</typeparam>
    /// <typeparam name="OutputType">Type of the output array.</typeparam>
    public delegate OutputType NumpyReduceAxisFunction<InputType, OutputType>(InputType[] values);

    /// <summary>
    /// Base class for all the operations that performs an aggregation and reduction on a given
    /// NumpyArray.
    /// <typeparam name="InputType">The element type of the input numpy array.</typeparam>
    /// <typeparam name="OutputType">The element type of the output numpy array.</typeparam>
    /// </summary>
    public class NumpyArrayOperationWithAxisReduction<InputType, OutputType>
        where InputType : struct where OutputType : struct
    {
        /// <summary>
        /// The input numpy array to perform the operation on.
        /// </summary>
        private NumpyArray<InputType> array;
        
        /// <summary>
        /// The callback that performs the reduction operation.
        /// </summary>
        private readonly NumpyReduceAxisFunction<InputType, OutputType> reduceAxisFunction;

        /// <summary>
        /// Instantiate a new object of NumpyArrayOperationWithAxisReduction.
        /// </summary>
        /// <param name="reduceAxisFunction">The callback that performs the reduction operation.</param>
        public NumpyArrayOperationWithAxisReduction(NumpyReduceAxisFunction<InputType, OutputType> reduceAxisFunction)
        {
            this.reduceAxisFunction = reduceAxisFunction;
        }

        /// <summary>
        /// Applies the operation on the numpy array.
        /// <param name="array">Input array to perform operation on.</param>
        /// <param name="axis">The axis that should be reduced on.</param>
        /// <returns>The numpy array that contains the result of the reduction.</returns>
        /// </summary>
        public NumpyArray<OutputType> Apply(NumpyArray<InputType> array, int axis)
        {
            this.array = array;
            int[] inputShape = array.Shape;
            int countInAxis = inputShape[axis];

            int[] outputShape = new int[inputShape.Length - 1];

            int temp = 0;
            for (int i = 0; i < inputShape.Length; i++)
            {
                if (i != axis)
                {
                    outputShape[temp] = inputShape[i];
                    temp++;
                }
            }


            NumpyArray<OutputType> result = CreateInstanceResultNumpyArray(outputShape);
            int[] counter = new int[outputShape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<int>.AddCounter(counter, outputShape);
                int[] indexOnInput = new int[inputShape.Length];
                temp = 0;
                for (int i = 0; i < indexOnInput.Length; i++)
                {
                    if (i != axis)
                    {
                        indexOnInput[i] = counter[temp];
                        temp++;
                    }
                }

                InputType[] valuesInAxis = new InputType[countInAxis];
                for (int i = 0; i < countInAxis; i++)
                {
                    indexOnInput[axis] = i;
                    valuesInAxis[i] = array.Get(indexOnInput);
                }

                result.Set(this.reduceAxisFunction(valuesInAxis), counter);
            } while (counter[counter.Length - 1] == 0);

            return result;
        }

        /// <summary>
        /// Instantiate the result numpy array.
        /// <param name="shape">The shape of the desired array.</param>
        /// <returns>An empty array with the desired specifications.</returns>
        /// </summary>
        public NumpyArray<OutputType> CreateInstanceResultNumpyArray(int[] shape)
        {
            Type type = typeof(OutputType);
            int size = 0;
            bool isFloatingPoint = false;

            if (type == typeof(byte))
            {
                size = 1;
            }
            else if (type == typeof(short))
            {
                size = 2;
            }
            else if (type == typeof(int))
            {
                size = 4;
            }
            else if (type == typeof(long))
            {
                size = 8;
            }
            else if (type == typeof(float))
            {
                size = 4;
                isFloatingPoint = true;
            }
            else if (type == typeof(double))
            {
                size = 8;
                isFloatingPoint = true;
            }


            return NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<OutputType>(isFloatingPoint, size, shape);
        }
    }
}