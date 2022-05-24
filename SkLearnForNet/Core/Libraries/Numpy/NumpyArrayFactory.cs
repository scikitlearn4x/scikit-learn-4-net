using System;
using SkLearn.Core.Libraries.Numpy.Wrappers;

namespace SkLearn.Core.Libraries.Numpy
{
    public partial class NumpyArrayFactory
    {
        internal static Array WrapInnerSubsetArray(Array source, int[] indices)
        {
            int[] outputShape = new int[source.Rank - indices.Length];
            for (int i = 0; i < outputShape.Length; i++)
            {
                outputShape[i] = source.GetLength(indices.Length + i);
            }

            Array result = Array.CreateInstance(source.GetType().BaseType, outputShape);
            throw new NotImplementedException();
        }

        public static NumpyArray<OutputType> CreateArrayOfShapeAndTypeInfo<OutputType>(bool isFloatingPoint, int size,
            int[] shape) where OutputType : struct
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