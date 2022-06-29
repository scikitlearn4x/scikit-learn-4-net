using System;
using System.CodeDom;
using System.Reflection;
using SkLearn.Core.Libraries.Numpy.Wrappers;

namespace SkLearn.Core.Libraries.Numpy
{
    /// <summary>
    /// Implementation of the Numpy library APIs.
    /// </summary>
    public class Numpy
    {
        /// <summary>
        /// Sums the values of a NumpyArray along a specified axis.
        /// See: https://numpy.org/doc/stable/reference/generated/numpy.sum.html
        /// <param name="array">Input array.</param>
        /// <param name="axis">Axis along which a sum is performed.</param>
        /// <param name="keepDimensions">A flag to specify whether to keep the reduced dimension in the output.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed.</returns>
        /// </summary>
        public static NumpyArray<double> Sum(NumpyArray<double> array, int axis, bool keepDimensions)
        {
            var reducer = new NumpyReduceAxisFunction<double, double>((values) =>
            {
                double result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<double, double> reduction = new NumpyArrayOperationWithAxisReduction<double, double>(reducer);
            return reduction.Apply(array, axis, keepDimensions);
        }

        /// <summary>
        /// Sums the values of a NumpyArray along a specified axis.
        /// See: https://numpy.org/doc/stable/reference/generated/numpy.sum.html
        /// <param name="array">Input array.</param>
        /// <param name="axis">Axis along which a sum is performed.</param>
        /// <param name="keepDimensions">A flag to specify whether to keep the reduced dimension in the output.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed.</returns>
        /// </summary>
        public static NumpyArray<float> Sum(NumpyArray<float> array, int axis, bool keepDimensions)
        {
            var reducer = new NumpyReduceAxisFunction<float, float>((values) =>
            {
                float result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<float, float> reduction = new NumpyArrayOperationWithAxisReduction<float, float>(reducer);
            return reduction.Apply(array, axis, keepDimensions);
        }

        /// <summary>
        /// Sums the values of a NumpyArray along a specified axis.
        /// See: https://numpy.org/doc/stable/reference/generated/numpy.sum.html
        /// <param name="array">Input array.</param>
        /// <param name="axis">Axis along which a sum is performed.</param>
        /// <param name="keepDimensions">A flag to specify whether to keep the reduced dimension in the output.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed.</returns>
        /// </summary>
        public static NumpyArray<long> Sum(NumpyArray<long> array, int axis, bool keepDimensions)
        {
            var reducer = new NumpyReduceAxisFunction<long, long>((values) =>
            {
                long result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<long, long> reduction = new NumpyArrayOperationWithAxisReduction<long, long>(reducer);
            return reduction.Apply(array, axis, keepDimensions);
        }

        /// <summary>
        /// Sums the values of a NumpyArray along a specified axis.
        /// See: https://numpy.org/doc/stable/reference/generated/numpy.sum.html
        /// <param name="array">Input array.</param>
        /// <param name="axis">Axis along which a sum is performed.</param>
        /// <param name="keepDimensions">A flag to specify whether to keep the reduced dimension in the output.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed.</returns>
        /// </summary>
        public static NumpyArray<int> Sum(NumpyArray<int> array, int axis, bool keepDimensions)
        {
            var reducer = new NumpyReduceAxisFunction<int, int>((values) =>
            {
                int result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<int, int> reduction = new NumpyArrayOperationWithAxisReduction<int, int>(reducer);
            return reduction.Apply(array, axis, keepDimensions);
        }

        /// <summary>
        /// Sums the values of a NumpyArray along a specified axis.
        /// See: https://numpy.org/doc/stable/reference/generated/numpy.sum.html
        /// <param name="array">Input array.</param>
        /// <param name="axis">Axis along which a sum is performed.</param>
        /// <param name="keepDimensions">A flag to specify whether to keep the reduced dimension in the output.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed.</returns>
        /// </summary>
        public static NumpyArray<int> Sum(NumpyArray<short> array, int axis, bool keepDimensions)
        {
            var reducer = new NumpyReduceAxisFunction<short, int>((values) =>
            {
                int result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<short, int> reduction = new NumpyArrayOperationWithAxisReduction<short, int>(reducer);
            return reduction.Apply(array, axis, keepDimensions);
        }

        /// <summary>
        /// Sums the values of a NumpyArray along a specified axis.
        /// See: https://numpy.org/doc/stable/reference/generated/numpy.sum.html
        /// <param name="array">Input array.</param>
        /// <param name="axis">Axis along which a sum is performed.</param>
        /// <param name="keepDimensions">A flag to specify whether to keep the reduced dimension in the output.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed.</returns>
        /// </summary>
        public static NumpyArray<int> Sum(NumpyArray<byte> array, int axis, bool keepDimensions)
        {
            var reducer = new NumpyReduceAxisFunction<byte, int>((values) =>
            {
                int result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<byte, int> reduction = new NumpyArrayOperationWithAxisReduction<byte, int>(reducer);
            return reduction.Apply(array, axis, keepDimensions);
        }

        /// <summary>
        /// Returns the indices of the maximum values along an axis.
        /// See: https://numpy.org/doc/stable/reference/generated/numpy.argmax.html
        /// <param name="array">The input multidimensional array.</param>
        /// <param name="axis">The axis which the argmax should reduce to.</param>
        /// <param name="keepDimensions">A flag to specify whether to keep the reduced dimension in the output.</param>
        /// <returns>Array of indices into the array. It has the same shape as a.shape with the dimension along axis removed.</returns>
        /// </summary>
        public static NumpyArray<long> Argmax(NumpyArray<double> array, int axis, bool keepDimensions)
        {
            var reducer = new NumpyReduceAxisFunction<double, long>((values) =>
            {
                long result = 0;
                double max = values[0];

                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i] > max)
                    {
                        result = i;
                        max = values[i];
                    }
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<double, long> reduction = new NumpyArrayOperationWithAxisReduction<double, long>(reducer);
            return reduction.Apply(array, axis, keepDimensions);
        }

        /// <summary>
        /// Calculate the exponential of all elements in the input array.
        /// https://numpy.org/doc/stable/reference/generated/numpy.exp.html
        /// <param name="array">Input values.</param>
        /// <returns>Output array, element-wise exponential of x.</returns>
        /// </summary>
        public static NumpyArray<double> Exp(NumpyArray<double> array)
        {
            NumpyArray<double> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<double>(true, NumpyArrayFactory.SIZE_OF_DOUBLE, array.Shape);

            array.ApplyToEachElementAnsSaveToTarget(result, value => Math.Exp(value));

            return result;
        }

        /// <summary>
        /// Natural logarithm, element-wise.
        /// 
        /// The natural logarithm log is the inverse of the exponential function, so that
        /// log(exp(x)) = x. The natural logarithm is logarithm in base e.
        /// <param name="array">Input values.</param>
        /// <returns>Output array, element-wise log of x.</returns>
        /// </summary>
        public static NumpyArray<Double> Log(NumpyArray<double> array)
        {
            NumpyArray<Double> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<double>(true, NumpyArrayFactory.SIZE_OF_DOUBLE, array.Shape);

            array.ApplyToEachElementAnsSaveToTarget(result, value => Math.Log(value));

            return result;
        }

        /// <summary>
        /// Wraps an atomic double value into a 2 dimensional array.
        /// <param name="value">The value to be wrapped into an array.</param>
        /// <returns>A two dimensional array that wraps the given value.</returns>
        /// </summary>
        public static NumpyArray<double> AtLeast2D(double value)
        {
            NumpyArray<double> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<double>(true, NumpyArrayFactory.SIZE_OF_DOUBLE, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        /// <summary>
        /// Wraps an atomic float value into a 2 dimensional array.
        /// <param name="value">The value to be wrapped into an array.</param>
        /// <returns>A two dimensional array that wraps the given value.</returns>
        /// </summary>
        public static NumpyArray<float> AtLeast2D(float value)
        {
            NumpyArray<float> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<float>(true, NumpyArrayFactory.SIZE_OF_FLOAT, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        /// <summary>
        /// Wraps an atomic long value into a 2 dimensional array.
        /// <param name="value">The value to be wrapped into an array.</param>
        /// <returns>A two dimensional array that wraps the given value.</returns>
        /// </summary>
        public static NumpyArray<long> AtLeast2D(long value)
        {
            NumpyArray<long> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<long>(false, NumpyArrayFactory.SIZE_OF_INT_64, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        /// <summary>
        /// Wraps an atomic int value into a 2 dimensional array.
        /// <param name="value">The value to be wrapped into an array.</param>
        /// <returns>A two dimensional array that wraps the given value.</returns>
        /// </summary>
        public static NumpyArray<int> AtLeast2D(int value)
        {
            NumpyArray<int> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<int>(false, NumpyArrayFactory.SIZE_OF_INT_32, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        /// <summary>
        /// Wraps an atomic short value into a 2 dimensional array.
        /// <param name="value">The value to be wrapped into an array.</param>
        /// <returns>A two dimensional array that wraps the given value.</returns>
        /// </summary>
        public static NumpyArray<short> AtLeast2D(short value)
        {
            NumpyArray<short> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<short>(false, NumpyArrayFactory.SIZE_OF_INT_16, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        /// <summary>
        /// Wraps an atomic byte value into a 2 dimensional array.
        /// <param name="value">The value to be wrapped into an array.</param>
        /// <returns>A two dimensional array that wraps the given value.</returns>
        /// </summary>
        public static NumpyArray<byte> AtLeast2D(byte value)
        {
            NumpyArray<byte> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<byte>(false, NumpyArrayFactory.SIZE_OF_INT_8, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        /// <summary>
        /// Wraps a numpy array into a 2 dimensional array if the number dimensions is less than 2.
        /// <param name="array">The array to be wrapped into a 2 dimensional array.</param>
        /// <returns>A two dimensional array that wraps the given value.</returns>
        /// </summary>
        public static NumpyArray<ElementType> AtLeast2D<ElementType>(NumpyArray<ElementType> array) where ElementType : struct
        {
            // https://github.com/numpy/numpy/blob/v1.22.0/numpy/core/shape_base.py#L81-L132
            NumpyArray<ElementType> result = null;

            if (array.NumberOfDimensions == 1)
            {
                result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<ElementType>(array.IsFloatingPoint, array.NumberOfBytes, new int[] { 1, array.Shape[0] });
                for (int i = 0; i < array.Shape[0]; i++)
                {
                    result.Set(array.Get(i), 0, i);
                }
            }
            else if (array.NumberOfDimensions > 1)
            {
                result = array;
            }
            else
            {
                throw new NumpyOperationException("The input for AtLeast2D is invalid");
            }

            return result;
        }

        /// <summary>
        /// Converts a numpy array to one with double elements.
        /// </summary>
        /// <param name="array">The input array to convert.</param>
        /// <typeparam name="Type">Type of the elements in input array.</typeparam>
        /// <returns>The converted numpy array.</returns>
        public static NumpyArray<double> AsDoubleArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(double), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToDouble(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<double> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1DoubleNumpyWrapper((double[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2DoubleNumpyWrapper((double[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3DoubleNumpyWrapper((double[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4DoubleNumpyWrapper((double[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5DoubleNumpyWrapper((double[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6DoubleNumpyWrapper((double[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7DoubleNumpyWrapper((double[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8DoubleNumpyWrapper((double[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9DoubleNumpyWrapper((double[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10DoubleNumpyWrapper((double[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<double>(wrapper);
        }

        /// <summary>
        /// Converts a numpy array to one with float elements.
        /// </summary>
        /// <param name="array">The input array to convert.</param>
        /// <typeparam name="Type">Type of the elements in input array.</typeparam>
        /// <returns>The converted numpy array.</returns>
        public static NumpyArray<float> AsFloatArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(float), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, array.Shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToSingle(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<float> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1FloatNumpyWrapper((float[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2FloatNumpyWrapper((float[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3FloatNumpyWrapper((float[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4FloatNumpyWrapper((float[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5FloatNumpyWrapper((float[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6FloatNumpyWrapper((float[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7FloatNumpyWrapper((float[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8FloatNumpyWrapper((float[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9FloatNumpyWrapper((float[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10FloatNumpyWrapper((float[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<float>(wrapper);
        }

        /// <summary>
        /// Converts a numpy array to one with long elements.
        /// </summary>
        /// <param name="array">The input array to convert.</param>
        /// <typeparam name="Type">Type of the elements in input array.</typeparam>
        /// <returns>The converted numpy array.</returns>
        public static NumpyArray<long> AsLongArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(long), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToInt64(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<long> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1Int64NumpyWrapper((long[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2Int64NumpyWrapper((long[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3Int64NumpyWrapper((long[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4Int64NumpyWrapper((long[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5Int64NumpyWrapper((long[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6Int64NumpyWrapper((long[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7Int64NumpyWrapper((long[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8Int64NumpyWrapper((long[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9Int64NumpyWrapper((long[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10Int64NumpyWrapper((long[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<long>(wrapper);
        }

        /// <summary>
        /// Converts a numpy array to one with int elements.
        /// </summary>
        /// <param name="array">The input array to convert.</param>
        /// <typeparam name="Type">Type of the elements in input array.</typeparam>
        /// <returns>The converted numpy array.</returns>
        public static NumpyArray<int> AsIntegerArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(int), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToInt32(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<int> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1Int32NumpyWrapper((int[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2Int32NumpyWrapper((int[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3Int32NumpyWrapper((int[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4Int32NumpyWrapper((int[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5Int32NumpyWrapper((int[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6Int32NumpyWrapper((int[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7Int32NumpyWrapper((int[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8Int32NumpyWrapper((int[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9Int32NumpyWrapper((int[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10Int32NumpyWrapper((int[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<int>(wrapper);
        }

        /// <summary>
        /// Converts a numpy array to one with short elements.
        /// </summary>
        /// <param name="array">The input array to convert.</param>
        /// <typeparam name="Type">Type of the elements in input array.</typeparam>
        /// <returns>The converted numpy array.</returns>
        public static NumpyArray<short> AsShortArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(short), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToInt16(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<short> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1Int16NumpyWrapper((short[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2Int16NumpyWrapper((short[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3Int16NumpyWrapper((short[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4Int16NumpyWrapper((short[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5Int16NumpyWrapper((short[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6Int16NumpyWrapper((short[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7Int16NumpyWrapper((short[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8Int16NumpyWrapper((short[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9Int16NumpyWrapper((short[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10Int16NumpyWrapper((short[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<short>(wrapper);
        }

        /// <summary>
        /// Converts a numpy array to one with byte elements.
        /// </summary>
        /// <param name="array">The input array to convert.</param>
        /// <typeparam name="Type">Type of the elements in input array.</typeparam>
        /// <returns>The converted numpy array.</returns>
        public static NumpyArray<byte> AsByteArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(byte), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToByte(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<byte> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1Int8NumpyWrapper((byte[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2Int8NumpyWrapper((byte[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3Int8NumpyWrapper((byte[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4Int8NumpyWrapper((byte[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5Int8NumpyWrapper((byte[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6Int8NumpyWrapper((byte[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7Int8NumpyWrapper((byte[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8Int8NumpyWrapper((byte[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9Int8NumpyWrapper((byte[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10Int8NumpyWrapper((byte[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<byte>(wrapper);
        }

        /// <summary>
        /// Converts a numpy array to one with elements conforming to the element size specified.
        /// </summary>
        /// <param name="array">The input array to convert.</param>
        /// <typeparam name="Type">Type of the elements in input array.</typeparam>
        /// <returns>The converted numpy array.</returns>
        public static Object AsArrayOfType<Type>(NumpyArray<Type> array, bool isFloatingPoint, int size) where Type : struct
        {
            if (isFloatingPoint)
            {
                if (size == 4)
                {
                    return AsFloatArray(array);
                }
                else if (size == 8)
                {
                    return AsDoubleArray(array);
                }
            }
            else
            {
                if (size == 8)
                {
                    return AsLongArray(array);
                }
                else if (size == 4)
                {
                    return AsIntegerArray(array);
                }
                else if (size == 2)
                {
                    return AsShortArray(array);
                }
                else if (size == 1)
                {
                    return AsByteArray(array);
                }
            }

            throw new NumpyOperationException("This conversion type is not supported.");
        }


        /// <summary>
        /// Gets the effective shape of the array. The effective shape is defined as the number of dimensions
        /// on the left that is followed only by ones.
        /// 
        /// Example:
        /// (2, 2) => (2, 2): Will return 2
        /// (1, 4) => (1, 4): Will return 2
        /// (3, 5, 1, 1) => (3, 5): Will return 2
        /// <param name="shape">Shape to evaluate the effective dimensions.</param>
        /// <returns>Number of effective dimensions.</returns>
        /// </summary>
        private static int GetEffectiveShapeWithRemovingEndingDimensions(int[] shape)
        {
            int lastOnes = 0;

            for (int i = 0; i < shape.Length; i++)
            {
                if (shape[shape.Length - i - 1] == 1)
                {
                    lastOnes++;
                }
                else
                {
                    break;
                }
            }

            return shape.Length - lastOnes;
        }

        /// <summary>
        /// Checks if two numpy arrays with the given dimensions could be added. If they are incompatible,
        /// an exception is thrown.
        /// <param name="shape1">Shape of the array on the left hand-side.</param>
        /// <param name="shape2">Shape of the array on the right hand-side.
        /// </param>
        /// </summary>
        private static void ValidateDimensionsForAdd(int[] shape1, int[] shape2)
        {
            int effective1 = GetEffectiveShapeWithRemovingEndingDimensions(shape1);
            int effective2 = GetEffectiveShapeWithRemovingEndingDimensions(shape2);

            if (effective2 == 0)
            {
                // This is the case where a single number is added to NumpyArray. 
                return;
            }

            if (effective1 != effective2 && Math.Abs(effective2 - effective1) != 1)
            {
                throw new NumpyOperationException("The effective shape of the two numpy array has different number of dimensions.");
            }

            // This check is for the case where 2 arrays are added with shapes: a1: [5,3], a2: [3]
            if ((shape1.Length > shape2.Length && IsShapeEndingLike(shape1, shape2)) || (shape2.Length > shape1.Length && IsShapeEndingLike(shape2, shape1)))
            {
                return;
            }

            for (int i = 0; i < effective1; i++)
            {
                if (shape1[i] != shape2[i] && (shape1[i] != 1 && shape2[i] != 1))
                {
                    throw new NumpyOperationException($"Dimension {i + 1} of the two numpy arrays doesn't match.");
                }
            }
        }

        /// <summary>
        /// Check if the shape 1 later dimensions are the shape as the one specified by shape 2.
        /// <param name="shape1">The base shape to check.</param>
        /// <param name="shape2">The shorter shape to check.</param>
        /// <returns>A boolean indicating if shape 1 ends with shape 2.</returns>
        /// </summary>
        private static bool IsShapeEndingLike(int[] shape1, int[] shape2)
        {
            bool result = true;

            for (int i = 0; i < shape2.Length; i++)
            {
                if (shape2[shape2.Length - i - 1] != shape1[shape1.Length - i - 1])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// To ease the add implementation, the code assumes that the array with higher dimensions is
        /// on the left-hand side. In case it is not provided in this format, it should be swapped. This
        /// function checks if it is the case or not.
        /// <param name="a1">Array on the left hand-side of the addition.</param>
        /// <param name="a2">Array on the right hand-side of the addition.</param>
        /// <returns>A boolean indicating if the values should be swapped or not.</returns>
        /// </summary>
        private static bool ShouldSwapForAdd<InputType1, InputType2>(NumpyArray<InputType1> a1, NumpyArray<InputType2> a2) where InputType1 : struct where InputType2 : struct
        {
            bool result = false;
            int[] s1 = a1.Shape;
            int[] s2 = a2.Shape;

            if (GetEffectiveShapeWithRemovingEndingDimensions(s1) < GetEffectiveShapeWithRemovingEndingDimensions(s2))
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Adds two numpy array.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="a2">The array on the right-hand side of the expression.</param>
        /// <typeparam name="InputType1">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="InputType2">Element type of the array on the right-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The addition of the two arrays.</returns>
        public static NumpyArray<OutputType> Add<InputType1, InputType2, OutputType>(NumpyArray<InputType1> a1, NumpyArray<InputType2> a2) where InputType1 : struct where InputType2 : struct where OutputType : struct
        {
            int sign = 1;
            return AddNumpyArraysWithSign<InputType1, InputType2, OutputType>(a1, a2, sign);
        }

        /// <summary>
        /// Adds a numpy array with a byte.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be added to the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The addition of the two values.</returns>
        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, byte value) where InputType : struct where OutputType : struct
        {
            NumpyArray<byte> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, byte, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Adds a numpy array with a short.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be added to the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The addition of the two values.</returns>
        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, short value) where InputType : struct where OutputType : struct
        {
            NumpyArray<short> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, short, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Subtracts a byte from a numpy array.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be subtracted from the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The result of the expression.</returns>
        public static NumpyArray<OutputType> Subtract<InputType, OutputType>(NumpyArray<InputType> a1, short value) where InputType : struct where OutputType : struct
        {
            NumpyArray<short> asArray = NumpyArrayFactory.From(new[] { (short)-value });
            return Add<InputType, short, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Adds a numpy array with a int.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be added to the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The addition of the two values.</returns>
        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, int value) where InputType : struct where OutputType : struct
        {
            NumpyArray<int> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, int, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Subtracts a int from a numpy array.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be subtracted from the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The result of the expression.</returns>
        public static NumpyArray<OutputType> Subtract<InputType, OutputType>(NumpyArray<InputType> a1, int value) where InputType : struct where OutputType : struct
        {
            NumpyArray<int> asArray = NumpyArrayFactory.From(new[] { (int)-value });
            return Add<InputType, int, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Adds a numpy array with a long.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be added to the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The addition of the two values.</returns>
        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, long value) where InputType : struct where OutputType : struct
        {
            NumpyArray<long> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, long, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Subtracts a long from a numpy array.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be subtracted from the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The result of the expression.</returns>
        public static NumpyArray<OutputType> Subtract<InputType, OutputType>(NumpyArray<InputType> a1, long value) where InputType : struct where OutputType : struct
        {
            NumpyArray<long> asArray = NumpyArrayFactory.From(new[] { -value });
            return Add<InputType, long, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Adds a numpy array with a float.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be added to the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The addition of the two values.</returns>
        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, float value) where InputType : struct where OutputType : struct
        {
            NumpyArray<float> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, float, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Subtracts a float from a numpy array.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be subtracted from the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The result of the expression.</returns>
        public static NumpyArray<OutputType> Subtract<InputType, OutputType>(NumpyArray<InputType> a1, float value) where InputType : struct where OutputType : struct
        {
            NumpyArray<float> asArray = NumpyArrayFactory.From(new[] { -value });
            return Add<InputType, float, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Adds a numpy array with a double.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be added to the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The addition of the two values.</returns>
        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, double value) where InputType : struct where OutputType : struct
        {
            NumpyArray<double> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, double, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Subtracts a double from a numpy array.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to be subtracted from the array.</param>
        /// <typeparam name="InputType">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The result of the expression.</returns>
        public static NumpyArray<OutputType> Subtract<InputType, OutputType>(NumpyArray<InputType> a1, double value) where InputType : struct where OutputType : struct
        {
            NumpyArray<double> asArray = NumpyArrayFactory.From(new[] { -value });
            return Add<InputType, double, OutputType>(a1, asArray);
        }

        /// <summary>
        /// Adds two numpy array.
        /// </summary>
        /// <param name="a1">The left-hand side of the expression.</param>
        /// <param name="a2">The right-hand side of the expression.</param>
        /// <param name="sign">The sign is multiplied to the right hand side. The values are either 1 or -1 where -1 is used to implement subtraction.</param>
        /// <typeparam name="InputType1">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="InputType2">Element type of the array on the right-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The addition of the two arrays.</returns>
        private static NumpyArray<OutputType> AddNumpyArraysWithSign<InputType1, InputType2, OutputType>(NumpyArray<InputType1> a1, NumpyArray<InputType2> a2, int sign) where InputType1 : struct where InputType2 : struct where OutputType : struct
        {
            ValidateDimensionsForAdd(a1.Shape, a2.Shape);
            if (ShouldSwapForAdd(a1, a2))
            {
                return Add<InputType2, InputType1, OutputType>(a2, a1);
            }

            bool isFloatingPoint = a1.IsFloatingPoint || a2.IsFloatingPoint;
            int size = Math.Max(a1.NumberOfBytes, a2.NumberOfBytes);

            if (!a1.IsFloatingPoint)
            {
                size = a2.NumberOfBytes;
            }
            else if (!a2.IsFloatingPoint)
            {
                size = a1.NumberOfBytes;
            }

            Object result = null;
            if (isFloatingPoint)
            {
                NumpyArray<double> da1 = AsDoubleArray(a1);
                NumpyArray<double> da2 = AsDoubleArray(a2);
                NumpyArray<double> temp = NumpyArrayFactory.ArrayOfDoubleWithShape(a1.Shape);

                AddInPlace(new int[0], temp, da1, da2, sign);
                result = AsArrayOfType(temp, true, size);
            }
            else
            {
                NumpyArray<long> da1 = AsLongArray(a1);
                NumpyArray<long> da2 = AsLongArray(a2);
                NumpyArray<long> temp = NumpyArrayFactory.ArrayOfInt64WithShape(a1.Shape);

                AddInPlace(new int[0], temp, da1, da2, sign);
                result = AsArrayOfType(temp, false, size);
            }

            return (NumpyArray<OutputType>)result;
        }

        /// <summary>
        /// Subtract an array from another one.
        /// </summary>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="a2">The array on the right-hand side of the expression.</param>
        /// <typeparam name="InputType1">Element type of the array on the left-hand side of the expression.</typeparam>
        /// <typeparam name="InputType2">Element type of the array on the right-hand side of the expression.</typeparam>
        /// <typeparam name="OutputType">Element type of the result array.</typeparam>
        /// <returns>The subtraction of the two arrays.</returns>
        public static NumpyArray<OutputType> Subtract<InputType1, InputType2, OutputType>(NumpyArray<InputType1> a1, NumpyArray<InputType2> a2) where InputType1 : struct where InputType2 : struct where OutputType : struct
        {
            int sign = -1;
            return AddNumpyArraysWithSign<InputType1, InputType2, OutputType>(a1, a2, sign);
        }

        /// <summary>
        /// Adds the elements of two double NumpyArray and store it in another one.
        /// </summary>
        /// <param name="targetBaseIndex">The addition is implemented recursively wrt to the dimensions. Each time that a new method is called, it passes the dimensions it has already processed in this variable.</param>
        /// <param name="target">The array that stores the result.</param>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="a2">The array on the right-hand side of the expression.</param>
        /// <param name="sign">The sign is multiplied to the right hand side. The values are either 1 or -1 where -1 is used to implement subtraction.</param>
        private static void AddInPlace(int[] targetBaseIndex, NumpyArray<double> target, NumpyArray<double> a1, NumpyArray<double> a2, int sign)
        {
            if (a2.IsSingleValueArray())
            {
                double singleValue = a2.GetSingleValue();

                AddInPlace(targetBaseIndex, target, a1, singleValue * sign);
            }
            else if (a1.NumberOfDimensions > 1 && a2.NumberOfDimensions == 1)
            {
                int[] leftNoneCommonShape = new int[a1.NumberOfDimensions - 1];
                int[] index = new int[a1.NumberOfDimensions];
                for (int i = 0; i < leftNoneCommonShape.Length; i++)
                {
                    leftNoneCommonShape[i] = a1.Shape[i];
                }

                int[] counter = new int[leftNoneCommonShape.Length + 1];
                int rightShape = a2.Shape[0];

                do
                {
                    AddCounter(counter, leftNoneCommonShape);

                    for (int i = 0; i < leftNoneCommonShape.Length; i++)
                    {
                        index[i] = counter[i];
                    }

                    for (int i = 0; i < rightShape; i++)
                    {
                        index[index.Length - 1] = i;

                        if (target.IsFloatingPoint)
                        {
                            if (target.NumberOfBytes == NumpyArrayFactory.SIZE_OF_DOUBLE)
                            {
                                double value = (double)a1.Get(index) + sign * (double)a2.Get(i);
                                target.Set(value, index);
                            }
                            else if (target.NumberOfBytes == NumpyArrayFactory.SIZE_OF_FLOAT)
                            {
                                float value = (float)a1.Get(index) + sign * (float)a2.Get(i);
                                target.Set(value, index);
                            }
                        }
                        else
                        {
                            if (target.NumberOfBytes == NumpyArrayFactory.SIZE_OF_INT_8)
                            {
                                byte value = (byte)((byte)a1.Get(index) + sign * (byte)a2.Get(i));
                                target.Set(value, index);
                            }
                            else if (target.NumberOfBytes == NumpyArrayFactory.SIZE_OF_INT_16)
                            {
                                short value = (short)((short)a1.Get(index) + sign * (short)a2.Get(i));
                                target.Set(value, index);
                            }
                            else if (target.NumberOfBytes == NumpyArrayFactory.SIZE_OF_INT_32)
                            {
                                int value = (int)a1.Get(index) + sign * (int)a2.Get(i);
                                target.Set(value, index);
                            }
                            else if (target.NumberOfBytes == NumpyArrayFactory.SIZE_OF_INT_64)
                            {
                                long value = (long)a1.Get(index) + sign * (long)a2.Get(i);
                                target.Set(value, index);
                            }
                        }
                    }
                } while (counter[counter.Length - 1] == 0);
            }
            else if (a1.NumberOfDimensions == 1 && a2.NumberOfDimensions == 1)
            {
                int firstDim = a1.Shape[0];
                double value = 0;
                int[] targetIndex = new int[target.NumberOfDimensions];
                for (int i = 0; i < targetBaseIndex.Length; i++)
                {
                    targetIndex[i] = targetBaseIndex[i];
                }

                for (int i = 0; i < firstDim; i++)
                {
                    value = a1.Get(i) + sign * a2.Get(i);
                    targetIndex[targetIndex.Length - 1] = i;
                    target.Set(value, targetIndex);
                }
            }
            else
            {
                int firstDim = a1.Shape[0];

                int[] newTargetBaseIndex = new int[targetBaseIndex.Length + 1];
                for (int i = 0; i < targetBaseIndex.Length; i++)
                {
                    newTargetBaseIndex[i] = targetBaseIndex[i];
                }

                for (int i = 0; i < firstDim; i++)
                {
                    newTargetBaseIndex[newTargetBaseIndex.Length - 1] = i;
                    NumpyArray<double> leftWrap = a1.WrapInnerSubsetArray(i);
                    NumpyArray<double> rightWrap = null;

                    if (a2.Shape[0] == 1)
                    {
                        rightWrap = a2.WrapInnerSubsetArray(0);
                    }
                    else
                    {
                        rightWrap = a2.WrapInnerSubsetArray(i);
                    }

                    AddInPlace(newTargetBaseIndex, target, leftWrap, rightWrap, sign);
                }
            }
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
        /// Adds a double value to the elements of a NumpyArray and store it in another one.
        /// </summary>
        /// <param name="targetBaseIndex">The addition is implemented recursively wrt to the dimensions. Each time that a new method is called, it passes the dimensions it has already processed in this variable.</param>
        /// <param name="target">The array that stores the result.</param>
        /// <param name="array">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to add.</param>
        private static void AddInPlace(int[] targetBaseIndex, NumpyArray<double> target, NumpyArray<double> array, double value)
        {
            int[] targetIndex = new int[target.NumberOfDimensions];
            for (int i = 0; i < targetBaseIndex.Length; i++)
            {
                targetIndex[i] = targetBaseIndex[i];
            }

            array.IterateOnEachElement((element, currentIndex) =>
            {
                for (int i = 0; i < currentIndex.Length; i++)
                {
                    targetIndex[targetBaseIndex.Length + i] = currentIndex[i];
                }

                target.Set(value + element, targetIndex);
            });
        }

        /// <summary>
        /// Adds the elements of two long NumpyArray and store it in another one.
        /// </summary>
        /// <param name="targetBaseIndex">The addition is implemented recursively wrt to the dimensions. Each time that a new method is called, it passes the dimensions it has already processed in this variable.</param>
        /// <param name="target">The array that stores the result.</param>
        /// <param name="a1">The array on the left-hand side of the expression.</param>
        /// <param name="a2">The array on the right-hand side of the expression.</param>
        /// <param name="sign">The sign is multiplied to the right hand side. The values are either 1 or -1 where -1 is used to implement subtraction.</param>
        private static void AddInPlace(int[] targetBaseIndex, NumpyArray<long> target, NumpyArray<long> a1, NumpyArray<long> a2, int sign)
        {
            if (a2.IsSingleValueArray())
            {
                long singleValue = a2.GetSingleValue();

                AddInPlace(targetBaseIndex, target, a1, singleValue * sign);
            }
            else if (a1.NumberOfDimensions == 1 && a2.NumberOfDimensions == 1)
            {
                int firstDim = a1.Shape[0];
                long value = 0;
                int[] targetIndex = new int[target.NumberOfDimensions];
                for (int i = 0; i < targetBaseIndex.Length; i++)
                {
                    targetIndex[i] = targetBaseIndex[i];
                }

                for (int i = 0; i < firstDim; i++)
                {
                    value = a1.Get(i) + sign * a2.Get(i);
                    targetIndex[targetIndex.Length - 1] = i;
                    target.Set(value, targetIndex);
                }
            }
            else
            {
                int firstDim = a1.Shape[0];

                int[] newTargetBaseIndex = new int[targetBaseIndex.Length + 1];
                for (int i = 0; i < targetBaseIndex.Length; i++)
                {
                    newTargetBaseIndex[i] = targetBaseIndex[i];
                }

                for (int i = 0; i < firstDim; i++)
                {
                    newTargetBaseIndex[newTargetBaseIndex.Length - 1] = i;
                    NumpyArray<long> leftWrap = a1.WrapInnerSubsetArray(i);
                    NumpyArray<long> rightWrap = null;

                    if (a2.Shape[0] == 1)
                    {
                        rightWrap = a2.WrapInnerSubsetArray(0);
                    }
                    else
                    {
                        rightWrap = a2.WrapInnerSubsetArray(i);
                    }

                    AddInPlace(newTargetBaseIndex, target, leftWrap, rightWrap, sign);
                }
            }
        }

        /// <summary>
        /// Adds a long value to the elements of a NumpyArray and store it in another one.
        /// </summary>
        /// <param name="targetBaseIndex">The addition is implemented recursively wrt to the dimensions. Each time that a new method is called, it passes the dimensions it has already processed in this variable.</param>
        /// <param name="target">The array that stores the result.</param>
        /// <param name="array">The array on the left-hand side of the expression.</param>
        /// <param name="value">The numerical value to add.</param>
        private static void AddInPlace(int[] targetBaseIndex, NumpyArray<long> target, NumpyArray<long> array, long value)
        {
            int[] targetIndex = new int[target.NumberOfDimensions];
            for (int i = 0; i < targetBaseIndex.Length; i++)
            {
                targetIndex[i] = targetBaseIndex[i];
            }

            array.IterateOnEachElement((element, currentIndex) =>
            {
                for (int i = 0; i < currentIndex.Length; i++)
                {
                    targetIndex[targetBaseIndex.Length + i] = currentIndex[i];
                }

                target.Set(value + element, targetIndex);
            });
        }

        /// <summary>
        /// Updates the memory layout needed for the multiplication of two numpy array and numerical value.
        /// </summary>
        /// <param name="type">Type of the numpy array elements'</param>
        /// <param name="size">Number of bytes needed for the numerical factor.</param>
        /// <param name="floatingPoint">A bool indicating if the numerical factor is floating point or not.</param>
        private static void UpdateLayoutInfoForMultiplication(Type type, ref int size, ref bool floatingPoint)
        {
            if (floatingPoint || type == typeof(float) || type == typeof(double))
            {
                floatingPoint = true;
                if (type == typeof(double))
                {
                    size = NumpyArrayFactory.SIZE_OF_DOUBLE;
                }
            }
            else
            {
                if (type == typeof(long)) size = NumpyArrayFactory.SIZE_OF_INT_64;
                if (type == typeof(int)) size = Math.Max(NumpyArrayFactory.SIZE_OF_INT_32, size);
                if (type == typeof(short)) size = Math.Max(NumpyArrayFactory.SIZE_OF_INT_16, size);
                if (type == typeof(byte)) size = Math.Max(NumpyArrayFactory.SIZE_OF_INT_8, size);
            }
        }

        /// <summary>
        /// Multiplies two numpy arrays.
        /// <param name="a1">Left-hand side of the expression.</param>
        /// <param name="a2">Right-hand side of the expression.</param>
        /// <returns>The multiplication result.</returns>
        /// </summary>
        public static NumpyArray<double> Multiply(NumpyArray<double> a1, NumpyArray<double> a2)
        {
            ValidateDimensionsForAdd(a1.Shape, a2.Shape);
            if (ShouldSwapForAdd(a1, a2))
            {
                return Multiply(a2, a1);
            }

            NumpyArray<double> result = NumpyArrayFactory.ArrayOfDoubleWithShape(a1.Shape);
            MultiplyInPlace(result, a1, a2);
            return result;
        }

        /// <summary>
        /// Multiplies two numpy array and stores the result into a target array.
        /// <param name="target">The target array that stores the results.</param>
        /// <param name="a1">The left-hand side of the expression.</param>
        /// <param name="a2">The right-hand side of the expression.
        /// </param>
        /// </summary>
        private static void MultiplyInPlace(NumpyArray<double> target, NumpyArray<double> a1, NumpyArray<double> a2)
        {
            if (a2.IsSingleValueArray())
            {
                double singleValue = a2.GetSingleValue();
                MultiplyInPlace(target, a1, singleValue);
            }
            else if (a1.NumberOfDimensions > 1 && a2.NumberOfDimensions == 1)
            {
                int[] leftNoneCommonShape = new int[a1.NumberOfDimensions - 1];
                int[] index = new int[a1.NumberOfDimensions];
                for (int i = 0; i < leftNoneCommonShape.Length; i++)
                {
                    leftNoneCommonShape[i] = a1.Shape[i];
                }

                int[] counter = new int[leftNoneCommonShape.Length + 1];
                int rightShape = a2.Shape[0];

                do
                {
                    AddCounter(counter, leftNoneCommonShape);

                    for (int i = 0; i < leftNoneCommonShape.Length; i++)
                    {
                        index[i] = counter[i];
                    }

                    for (int i = 0; i < rightShape; i++)
                    {
                        index[index.Length - 1] = i;
                        double value = a1.Get(index) * a2.Get(i);

                        target.Set(value, index);
                    }
                } while (counter[counter.Length - 1] == 0);
            }
            else if (a1.NumberOfDimensions == 1 && a2.NumberOfDimensions == 1)
            {
                int firstDim = target.Shape[0];

                for (int i = 0; i < firstDim; i++)
                {
                    double value = a1.Get(i) * a2.Get(i);

                    target.Set(value, i);
                }
            }
            else
            {
                int firstDim = target.Shape[0];

                for (int i = 0; i < firstDim; i++)
                {
                    NumpyArray<double> leftWrap = a1.WrapInnerSubsetArray(i);
                    NumpyArray<double> rightWrap = null;

                    if (a2.Shape[0] == 1)
                    {
                        rightWrap = a2.WrapInnerSubsetArray(0);
                    }
                    else
                    {
                        rightWrap = a2.WrapInnerSubsetArray(i);
                    }

                    NumpyArray<double> tempTarget = target.WrapInnerSubsetArray(i); 
                    MultiplyInPlace(tempTarget, leftWrap, rightWrap);
                    CopySubArray(target, i, tempTarget);
                }
            }
        }

        /// <summary>
        /// Multiplies a double value by a numpy array.
        /// <param name="target">The array that stores the calculation.</param>
        /// <param name="array">The left-hand side of the expression.</param>
        /// <param name="value">The value to be multiplied by.
        /// </param>
        /// </summary>
        private static void MultiplyInPlace(NumpyArray<double> target, NumpyArray<double> array, double value)
        {
            array.ApplyToEachElementAnsSaveToTarget(target, element => value * (double)element);
        }

        /// <summary>
        /// Multiplies a numpy array by a byte value.
        /// </summary>
        /// <param name="numpyArray">The numpy array to be multiplied.</param>
        /// <param name="value">The numerical value to be multiplied.</param>
        /// <typeparam name="InputType">Type of the elements of the input.</typeparam>
        /// <typeparam name="OutputType">Types of the elements of the result.</typeparam>
        /// <returns>The multiplication of the two values.</returns>
        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, byte value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_INT_8;
            bool floatingPoint = false;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        /// <summary>
        /// Multiplies a numpy array by a short value.
        /// </summary>
        /// <param name="numpyArray">The numpy array to be multiplied.</param>
        /// <param name="value">The numerical value to be multiplied.</param>
        /// <typeparam name="InputType">Type of the elements of the input.</typeparam>
        /// <typeparam name="OutputType">Types of the elements of the result.</typeparam>
        /// <returns>The multiplication of the two values.</returns>
        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, short value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_INT_16;
            bool floatingPoint = false;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        /// <summary>
        /// Multiplies a numpy array by a int value.
        /// </summary>
        /// <param name="numpyArray">The numpy array to be multiplied.</param>
        /// <param name="value">The numerical value to be multiplied.</param>
        /// <typeparam name="InputType">Type of the elements of the input.</typeparam>
        /// <typeparam name="OutputType">Types of the elements of the result.</typeparam>
        /// <returns>The multiplication of the two values.</returns>
        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, int value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_INT_32;
            bool floatingPoint = false;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        /// <summary>
        /// Multiplies a numpy array by a long value.
        /// </summary>
        /// <param name="numpyArray">The numpy array to be multiplied.</param>
        /// <param name="value">The numerical value to be multiplied.</param>
        /// <typeparam name="InputType">Type of the elements of the input.</typeparam>
        /// <typeparam name="OutputType">Types of the elements of the result.</typeparam>
        /// <returns>The multiplication of the two values.</returns>
        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, long value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_INT_64;
            bool floatingPoint = false;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        /// <summary>
        /// Multiplies a numpy array by a float value.
        /// </summary>
        /// <param name="numpyArray">The numpy array to be multiplied.</param>
        /// <param name="value">The numerical value to be multiplied.</param>
        /// <typeparam name="InputType">Type of the elements of the input.</typeparam>
        /// <typeparam name="OutputType">Types of the elements of the result.</typeparam>
        /// <returns>The multiplication of the two values.</returns>
        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, float value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_FLOAT;
            bool floatingPoint = true;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        /// <summary>
        /// Multiplies a numpy array by a double value.
        /// </summary>
        /// <param name="numpyArray">The numpy array to be multiplied.</param>
        /// <param name="value">The numerical value to be multiplied.</param>
        /// <typeparam name="InputType">Type of the elements of the input.</typeparam>
        /// <typeparam name="OutputType">Types of the elements of the result.</typeparam>
        /// <returns>The multiplication of the two values.</returns>
        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, double value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_DOUBLE;
            bool floatingPoint = true;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        /// <summary>
        /// Multiplies a numpy array by a numerical value and cast to proper types specified by the memory layout information.
        /// </summary>
        /// <param name="numpyArray">The numpy array to be multiplied.</param>
        /// <param name="value">The factor for multiplication.</param>
        /// <param name="floatingPoint">A bool indicating if the output should be floating point or not.</param>
        /// <param name="size">Number of bytes the output data type should allocate for each element.</param>
        /// <typeparam name="InputType">Type of the elements in the input numpy array.</typeparam>
        /// <typeparam name="OutputType">Type of the elements in the result numpy array.</typeparam>
        /// <returns>A numpy array of the multiplication with the element types specified.</returns>
        private static NumpyArray<OutputType> MultiplyNumpyArrayByNumber<InputType, OutputType>(NumpyArray<InputType> numpyArray, double value, bool floatingPoint, int size) where InputType : struct where OutputType : struct
        {
            Object result = null;
            if (floatingPoint)
            {
                NumpyArray<double> temp = NumpyArrayFactory.ArrayOfDoubleWithShape(numpyArray.Shape);
                numpyArray.IterateOnEachElement((element, index) =>
                {
                    double e = Convert.ToDouble(element) * value;
                    temp.Set(e, index);
                });

                result = AsArrayOfType(temp, true, size);
            }
            else
            {
                NumpyArray<long> temp = NumpyArrayFactory.ArrayOfInt64WithShape(numpyArray.Shape);
                long coeff = (long)value;
                numpyArray.IterateOnEachElement((element, index) =>
                {
                    long e = Convert.ToInt64(element) * coeff;
                    temp.Set(e, index);
                });

                result = AsArrayOfType(temp, false, size);
            }

            return (NumpyArray<OutputType>)result;
        }

        /// <summary>
        /// Divides two numpy arrays.
        /// <param name="a1">Left-hand side of the expression.</param>
        /// <param name="a2">Right-hand side of the expression.</param>
        /// <returns>The multiplication result.</returns>
        /// </summary>
        public static NumpyArray<double> Divide(NumpyArray<double> a1, NumpyArray<double> a2)
        {
            ValidateDimensionsForAdd(a1.Shape, a2.Shape);
            if (ShouldSwapForAdd(a1, a2))
            {
                throw new NumpyOperationException("This division is not supported.");
            }

            bool isFloatingPoint = a1.IsFloatingPoint || a2.IsFloatingPoint;
            int size = Math.Max(a1.NumberOfBytes, a2.NumberOfBytes);

            if (!a1.IsFloatingPoint)
            {
                size = a2.NumberOfBytes;
            }
            else if (!a2.IsFloatingPoint)
            {
                size = a1.NumberOfBytes;
            }

            NumpyArray<double> result = NumpyArrayFactory.ArrayOfDoubleWithShape(a1.Shape);
            DivideInPlace(result, a1, a2);
            return result;
        }

        /// <summary>
        /// Divides two numpy array and stores the result into a target array.
        /// <param name="target">The target array that stores the results.</param>
        /// <param name="a1">The left-hand side of the expression.</param>
        /// <param name="a2">The right-hand side of the expression.</param>
        /// </summary>
        private static void DivideInPlace(NumpyArray<double> target, NumpyArray<double> a1, NumpyArray<double> a2)
        {
            if (a2.IsSingleValueArray())
            {
                double singleValue = a2.GetSingleValue();
                DivideInPlace(target, a1, singleValue);
            }
            else if (a1.NumberOfDimensions > 1 && a2.NumberOfDimensions == 1)
            {
                int[] leftNoneCommonShape = new int[a1.NumberOfDimensions - 1];
                int[] index = new int[a1.NumberOfDimensions];
                for (int i = 0; i < leftNoneCommonShape.Length; i++)
                {
                    leftNoneCommonShape[i] = a1.Shape[i];
                }

                int[] counter = new int[leftNoneCommonShape.Length + 1];
                int rightShape = a2.Shape[0];

                do
                {
                    AddCounter(counter, leftNoneCommonShape);

                    for (int i = 0; i < leftNoneCommonShape.Length; i++)
                    {
                        index[i] = counter[i];
                    }

                    for (int i = 0; i < rightShape; i++)
                    {
                        index[index.Length - 1] = i;
                        double value = 0;
                        value = a1.Get(index) / a2.Get(i);

                        target.Set(value, index);
                    }
                } while (counter[counter.Length - 1] == 0);
            }
            else if (a1.NumberOfDimensions == 1 && a2.NumberOfDimensions == 1)
            {
                int firstDim = target.Shape[0];

                for (int i = 0; i < firstDim; i++)
                {
                    double value = a1.Get(i) / a2.Get(i);

                    target.Set(value, i);
                }
            }
            else
            {
                int firstDim = target.Shape[0];

                for (int i = 0; i < firstDim; i++)
                {
                    NumpyArray<double> leftWrap = a1.WrapInnerSubsetArray(i);
                    NumpyArray<double> rightWrap = null;

                    if (a2.Shape[0] == 1)
                    {
                        rightWrap = a2.WrapInnerSubsetArray(0);
                    }
                    else
                    {
                        rightWrap = a2.WrapInnerSubsetArray(i);
                    }

                    NumpyArray<double> tempTarget = target.WrapInnerSubsetArray(i);
                    DivideInPlace(tempTarget, leftWrap, rightWrap);
                    CopySubArray(target, i, tempTarget);
                }
            }
        }

        /// <summary>
        /// Copies the temporary array into the target as a sub array.
        /// </summary>
        /// <param name="target">The final target to save.</param>
        /// <param name="firstDim">The value of the first dimension in the target array.</param>
        /// <param name="temp">The temporary sub array.</param>
        private static void CopySubArray(NumpyArray<double> target, int firstDim, NumpyArray<double> temp)
        {
            int[] targetIndex = new int[target.NumberOfDimensions];
            targetIndex[0] = firstDim;
            temp.IterateOnEachElement((value, index) =>
            {
                for (int i = 0; i < index.Length; i++)
                {
                    targetIndex[i + 1] = index[i];
                }
                target.Set(value, targetIndex);
            });
        }

        /// <summary>
        /// Divides a double value by a numpy array.
        /// <param name="target">The array that stores the calculation.</param>
        /// <param name="array">The left-hand side of the expression.</param>
        /// <param name="value">The value to be divided by.
        /// </param>
        /// </summary>
        private static void DivideInPlace(NumpyArray<double> target, NumpyArray<double> array, double value)
        {
            array.ApplyToEachElementAnsSaveToTarget(target, element => ((double)element) / value);
        }

        /// <summary>
        /// Divides the double elements of a numpy array by a long given value.
        /// </summary>
        /// <param name="numpyArray">Numpy array to divide values.</param>
        /// <param name="value">The value on the right hand side of the expression.</param>
        /// <returns>The result of calculation</returns>
        public static NumpyArray<double> Divide(NumpyArray<double> numpyArray, long value)
        {
            return Multiply<double, double>(numpyArray, 1.0 / value);
        }

        /// <summary>
        /// Divides the double elements of a numpy array by a double given value.
        /// </summary>
        /// <param name="numpyArray">Numpy array to divide values.</param>
        /// <param name="value">The value on the right hand side of the expression.</param>
        /// <returns>The result of calculation</returns>
        public static NumpyArray<double> Divide(NumpyArray<double> numpyArray, double value)
        {
            return Multiply<double, double>(numpyArray, 1.0 / value);
        }

        /// <summary>
        /// Divides the float elements of a numpy array by a long given value.
        /// </summary>
        /// <param name="numpyArray">Numpy array to divide values.</param>
        /// <param name="value">The value on the right hand side of the expression.</param>
        /// <returns>The result of calculation</returns>
        public static NumpyArray<float> Divide(NumpyArray<float> numpyArray, long value)
        {
            return Multiply<float, float>(numpyArray, 1.0f / value);
        }

        /// <summary>
        /// Divides the float elements of a numpy array by a float given value.
        /// </summary>
        /// <param name="numpyArray">Numpy array to divide values.</param>
        /// <param name="value">The value on the right hand side of the expression.</param>
        /// <returns>The result of calculation</returns>
        public static NumpyArray<float> Divide(NumpyArray<float> numpyArray, float value)
        {
            return Multiply<float, float>(numpyArray, 1.0f / value);
        }

        /// <summary>
        /// Divides the float elements of a numpy array by a double given value.
        /// </summary>
        /// <param name="numpyArray">Numpy array to divide values.</param>
        /// <param name="value">The value on the right hand side of the expression.</param>
        /// <returns>The result of calculation</returns>
        public static NumpyArray<double> Divide(NumpyArray<float> numpyArray, double value)
        {
            return Multiply<float, double>(numpyArray, 1.0 / value);
        }

        /// <summary>
        /// Returns the maximum values along an axis.
        /// See: https://numpy.org/doc/stable/reference/generated/numpy.amax.html
        /// <param name="array">The input multidimensional array.</param>
        /// <param name="axis">The axis which the amax should reduce to.</param>
        /// <param name="keepDimensions">A flag to specify whether to keep the reduced dimension in the output.</param>
        /// <returns>Array of maximum into the array. It has the same shape as a.shape with the dimension along axis removed.</returns>
        /// </summary>
        public static NumpyArray<double> ArrayMax(NumpyArray<double> array, int axis, bool keepDimensions)
        {
            var reducer = new NumpyReduceAxisFunction<double, double>((values) =>
            {
                double max = values[0];

                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i] > max)
                    {
                        max = values[i];
                    }
                }

                return max;
            });

            NumpyArrayOperationWithAxisReduction<double, double> reduction = new NumpyArrayOperationWithAxisReduction<double, double>(reducer);
            return reduction.Apply(array, axis, keepDimensions);
        }

        /// <summary>
        /// Remove axes of length one from the array.
        /// </summary>
        /// <param name="array">The array to squeeze.</param>
        /// <returns>An array without any dimension of length 1.</returns>
        public static NumpyArray<double> Squeeze(NumpyArray<double> array)
        {
            int desiredDimensions = 0;
            for (int i = 0; i < array.Shape.Length; i++)
            {
                int dim = array.Shape[i];
                if (dim > 1)
                {
                    desiredDimensions++;
                }
            }

            int[] shape = new int[desiredDimensions];
            int[] mapper = new int[desiredDimensions];
            int indexOnShape = 0;
            for (int i = 0; i < array.Shape.Length; i++)
            {
                int dim = array.Shape[i];
                if (dim > 1)
                {
                    shape[indexOnShape] = dim;
                    mapper[indexOnShape] = i;
                    indexOnShape++;
                }
            }

            NumpyArray<double> result = NumpyArrayFactory.ArrayOfDoubleWithShape(shape);
            int[] counter = new int[shape.Length + 1];
            int[] indexOnInput = new int[array.Shape.Length];

            do
            {
                AddCounter(counter, shape);
                for (int i = 0; i < mapper.Length; i++)
                {
                    indexOnInput[mapper[i]] = counter[i];
                }

                result.Set(array.Get(indexOnInput), counter);
            } while (counter[counter.Length - 1] == 0);

            return result;
        }

        /// <summary>
        /// Clip (limit) the values in an array.
        /// Given an interval, values outside the interval are clipped to the interval edges.
        /// For example, if an interval of [0, 1] is specified, values smaller than 0 become 0,
        /// and values larger than 1 become 1.
        /// Equivalent to but faster than np.minimum(a_max, np.maximum(a, a_min)).
        /// <param name="array">Array containing elements to clip.</param>
        /// <param name="min">The minimum value to clip.</param>
        /// <param name="max">The maximum value to clip.</param>
        /// <returns>An array with the elements of array, but where values less than min are
        /// replaced with min, and those larger than max with max.</returns>
        /// </summary>
        public static NumpyArray<double> Clip(NumpyArray<double> array, double min, double max)
        {
            NumpyArray<double> result = NumpyArrayFactory.ArrayOfDoubleWithShape(array.Shape);

            array.ApplyToEachElementAnsSaveToTarget(result, value =>
            {
                if (value > max)
                {
                    return max;
                }
                else if (value < min)
                {
                    return min;
                }

                return value;
            });

            return result;
        }

        /// <summary>
        /// Calculate the absolute value element-wise.
        /// <param name="array">Input array.</param>
        /// <returns>An ndarray containing the absolute value of each element in x.</returns>
        /// </summary>
        public static NumpyArray<DataType> Abs<DataType>(NumpyArray<DataType> array) where DataType : struct
        {
            NumpyArray<DataType> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<DataType>(array.IsFloatingPoint, array.NumberOfBytes, array.Shape);
            NumpyArrayElementOperation<DataType> absOperation = null;
            MethodInfo abs = typeof(Math).GetMethod("Abs", BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(DataType) }, null);

            absOperation = value => (DataType)abs.Invoke(null, new object?[] {value});
            array.ApplyToEachElementAnsSaveToTarget(result, absOperation);

            return result;
        }

        /// <summary>
        /// Return the non-negative square-root of an array, element-wise.
        /// <param name="array">The values whose square-roots are required.</param>
        /// <returns>An array of the same shape as x, containing the positive square-root
        /// of each element in x.</returns>
        /// </summary>
        public static NumpyArray<DataType> Sqrt<DataType>(NumpyArray<DataType> array) where DataType : struct
        {
            NumpyArray<DataType> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<DataType>(array.IsFloatingPoint, array.NumberOfBytes, array.Shape);
            NumpyArrayElementOperation<DataType> absOperation = null;
            MethodInfo sqrt = typeof(Math).GetMethod("Sqrt", BindingFlags.Public | BindingFlags.Static);

            absOperation = value => (DataType)sqrt.Invoke(null, new object?[] { value } );
            array.ApplyToEachElementAnsSaveToTarget(result, absOperation);

            return result;
        }
    }
}