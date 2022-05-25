using System;

namespace SkLearn.Core.Libraries.Numpy
{
    public delegate OutputType NumpyReduceAxisFunction<InputType, OutputType>(InputType[] values);

    public class NumpyArrayOperationWithAxisReduction<InputType, OutputType> where InputType : struct where OutputType : struct
    {
        private NumpyArray<InputType> array;
        private readonly NumpyReduceAxisFunction<InputType, OutputType> reduceAxisFunction;

        public NumpyArrayOperationWithAxisReduction(NumpyReduceAxisFunction<InputType, OutputType> reduceAxisFunction)
        {
            this.reduceAxisFunction = reduceAxisFunction;
        }

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