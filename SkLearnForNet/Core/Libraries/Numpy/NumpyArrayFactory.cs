using System;
using SkLearn.Core.Libraries.Numpy.Wrappers;

namespace SkLearn.Core.Libraries.Numpy
{
    public partial class NumpyArrayFactory
    {
        public const int SIZE_OF_INT_8 = 1;
        public const int SIZE_OF_INT_16 = 2;
        public const int SIZE_OF_INT_32 = 4;
        public const int SIZE_OF_INT_64 = 8;
        public const int SIZE_OF_FLOAT = 4;
        public const int SIZE_OF_DOUBLE = 8;

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