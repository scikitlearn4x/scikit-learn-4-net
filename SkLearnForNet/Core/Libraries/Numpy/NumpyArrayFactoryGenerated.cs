using System;
using SkLearn.Core.Libraries.Numpy.Wrappers;

namespace SkLearn.Core.Libraries.Numpy
{
    /// <summary>
    /// A factory class that facilitate the creation of NumpyArrays.
    /// </summary>
    public partial class NumpyArrayFactory
    {
        /// <summary>
        /// Create a numpy array wrapper over a 1 dimension byte array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<byte> From(byte[] array)
        {
            return new NumpyArray<byte>(new Dim1Int8NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 2 dimension byte array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<byte> From(byte[,] array)
        {
            return new NumpyArray<byte>(new Dim2Int8NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 3 dimension byte array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<byte> From(byte[,,] array)
        {
            return new NumpyArray<byte>(new Dim3Int8NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 4 dimension byte array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<byte> From(byte[,,,] array)
        {
            return new NumpyArray<byte>(new Dim4Int8NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 5 dimension byte array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<byte> From(byte[,,,,] array)
        {
            return new NumpyArray<byte>(new Dim5Int8NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 6 dimension byte array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<byte> From(byte[,,,,,] array)
        {
            return new NumpyArray<byte>(new Dim6Int8NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 7 dimension byte array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<byte> From(byte[,,,,,,] array)
        {
            return new NumpyArray<byte>(new Dim7Int8NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 8 dimension byte array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<byte> From(byte[,,,,,,,] array)
        {
            return new NumpyArray<byte>(new Dim8Int8NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 9 dimension byte array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<byte> From(byte[,,,,,,,,] array)
        {
            return new NumpyArray<byte>(new Dim9Int8NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 10 dimension byte array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<byte> From(byte[,,,,,,,,,] array)
        {
            return new NumpyArray<byte>(new Dim10Int8NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 1 dimension short array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<short> From(short[] array)
        {
            return new NumpyArray<short>(new Dim1Int16NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 2 dimension short array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<short> From(short[,] array)
        {
            return new NumpyArray<short>(new Dim2Int16NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 3 dimension short array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<short> From(short[,,] array)
        {
            return new NumpyArray<short>(new Dim3Int16NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 4 dimension short array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<short> From(short[,,,] array)
        {
            return new NumpyArray<short>(new Dim4Int16NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 5 dimension short array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<short> From(short[,,,,] array)
        {
            return new NumpyArray<short>(new Dim5Int16NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 6 dimension short array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<short> From(short[,,,,,] array)
        {
            return new NumpyArray<short>(new Dim6Int16NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 7 dimension short array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<short> From(short[,,,,,,] array)
        {
            return new NumpyArray<short>(new Dim7Int16NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 8 dimension short array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<short> From(short[,,,,,,,] array)
        {
            return new NumpyArray<short>(new Dim8Int16NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 9 dimension short array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<short> From(short[,,,,,,,,] array)
        {
            return new NumpyArray<short>(new Dim9Int16NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 10 dimension short array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<short> From(short[,,,,,,,,,] array)
        {
            return new NumpyArray<short>(new Dim10Int16NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 1 dimension int array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<int> From(int[] array)
        {
            return new NumpyArray<int>(new Dim1Int32NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 2 dimension int array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<int> From(int[,] array)
        {
            return new NumpyArray<int>(new Dim2Int32NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 3 dimension int array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<int> From(int[,,] array)
        {
            return new NumpyArray<int>(new Dim3Int32NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 4 dimension int array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<int> From(int[,,,] array)
        {
            return new NumpyArray<int>(new Dim4Int32NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 5 dimension int array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<int> From(int[,,,,] array)
        {
            return new NumpyArray<int>(new Dim5Int32NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 6 dimension int array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<int> From(int[,,,,,] array)
        {
            return new NumpyArray<int>(new Dim6Int32NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 7 dimension int array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<int> From(int[,,,,,,] array)
        {
            return new NumpyArray<int>(new Dim7Int32NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 8 dimension int array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<int> From(int[,,,,,,,] array)
        {
            return new NumpyArray<int>(new Dim8Int32NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 9 dimension int array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<int> From(int[,,,,,,,,] array)
        {
            return new NumpyArray<int>(new Dim9Int32NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 10 dimension int array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<int> From(int[,,,,,,,,,] array)
        {
            return new NumpyArray<int>(new Dim10Int32NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 1 dimension long array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<long> From(long[] array)
        {
            return new NumpyArray<long>(new Dim1Int64NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 2 dimension long array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<long> From(long[,] array)
        {
            return new NumpyArray<long>(new Dim2Int64NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 3 dimension long array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<long> From(long[,,] array)
        {
            return new NumpyArray<long>(new Dim3Int64NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 4 dimension long array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<long> From(long[,,,] array)
        {
            return new NumpyArray<long>(new Dim4Int64NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 5 dimension long array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<long> From(long[,,,,] array)
        {
            return new NumpyArray<long>(new Dim5Int64NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 6 dimension long array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<long> From(long[,,,,,] array)
        {
            return new NumpyArray<long>(new Dim6Int64NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 7 dimension long array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<long> From(long[,,,,,,] array)
        {
            return new NumpyArray<long>(new Dim7Int64NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 8 dimension long array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<long> From(long[,,,,,,,] array)
        {
            return new NumpyArray<long>(new Dim8Int64NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 9 dimension long array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<long> From(long[,,,,,,,,] array)
        {
            return new NumpyArray<long>(new Dim9Int64NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 10 dimension long array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<long> From(long[,,,,,,,,,] array)
        {
            return new NumpyArray<long>(new Dim10Int64NumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 1 dimension float array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<float> From(float[] array)
        {
            return new NumpyArray<float>(new Dim1FloatNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 2 dimension float array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<float> From(float[,] array)
        {
            return new NumpyArray<float>(new Dim2FloatNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 3 dimension float array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<float> From(float[,,] array)
        {
            return new NumpyArray<float>(new Dim3FloatNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 4 dimension float array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<float> From(float[,,,] array)
        {
            return new NumpyArray<float>(new Dim4FloatNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 5 dimension float array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<float> From(float[,,,,] array)
        {
            return new NumpyArray<float>(new Dim5FloatNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 6 dimension float array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<float> From(float[,,,,,] array)
        {
            return new NumpyArray<float>(new Dim6FloatNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 7 dimension float array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<float> From(float[,,,,,,] array)
        {
            return new NumpyArray<float>(new Dim7FloatNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 8 dimension float array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<float> From(float[,,,,,,,] array)
        {
            return new NumpyArray<float>(new Dim8FloatNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 9 dimension float array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<float> From(float[,,,,,,,,] array)
        {
            return new NumpyArray<float>(new Dim9FloatNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 10 dimension float array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<float> From(float[,,,,,,,,,] array)
        {
            return new NumpyArray<float>(new Dim10FloatNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 1 dimension double array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<double> From(double[] array)
        {
            return new NumpyArray<double>(new Dim1DoubleNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 2 dimension double array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<double> From(double[,] array)
        {
            return new NumpyArray<double>(new Dim2DoubleNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 3 dimension double array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<double> From(double[,,] array)
        {
            return new NumpyArray<double>(new Dim3DoubleNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 4 dimension double array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<double> From(double[,,,] array)
        {
            return new NumpyArray<double>(new Dim4DoubleNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 5 dimension double array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<double> From(double[,,,,] array)
        {
            return new NumpyArray<double>(new Dim5DoubleNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 6 dimension double array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<double> From(double[,,,,,] array)
        {
            return new NumpyArray<double>(new Dim6DoubleNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 7 dimension double array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<double> From(double[,,,,,,] array)
        {
            return new NumpyArray<double>(new Dim7DoubleNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 8 dimension double array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<double> From(double[,,,,,,,] array)
        {
            return new NumpyArray<double>(new Dim8DoubleNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 9 dimension double array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<double> From(double[,,,,,,,,] array)
        {
            return new NumpyArray<double>(new Dim9DoubleNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array wrapper over a 10 dimension double array.
        /// </summary>
        /// <param name="array">The array to be wrapped.</param>
        /// <returns>The wrapped numpy array.</returns>
        public static NumpyArray<double> From(double[,,,,,,,,,] array)
        {
            return new NumpyArray<double>(new Dim10DoubleNumpyWrapper(array));
        }

        /// <summary>
        /// Create a numpy array of byte with specified shape.
        /// <param name="shape">The shape of the new array.</param>
        /// <returns>The new numpy array with desired shape.</returns>
        /// </summary>
        public static NumpyArray<byte> ArrayOfInt8WithShape(int[] shape)
        {
            if (shape.Length == 1)
            {
                return From(new byte[shape[0]]);
            }
            else if (shape.Length == 2)
            {
                return From(new byte[shape[0], shape[1]]);
            }
            else if (shape.Length == 3)
            {
                return From(new byte[shape[0], shape[1], shape[2]]);
            }
            else if (shape.Length == 4)
            {
                return From(new byte[shape[0], shape[1], shape[2], shape[3]]);
            }
            else if (shape.Length == 5)
            {
                return From(new byte[shape[0], shape[1], shape[2], shape[3], shape[4]]);
            }
            else if (shape.Length == 6)
            {
                return From(new byte[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5]]);
            }
            else if (shape.Length == 7)
            {
                return From(new byte[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6]]);
            }
            else if (shape.Length == 8)
            {
                return From(new byte[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7]]);
            }
            else if (shape.Length == 9)
            {
                return From(new byte[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8]]);
            }
            else if (shape.Length == 10)
            {
                return From(new byte[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8], shape[9]]);
            }

            throw new NumpyOperationException("The shape specified is not supported; only arrays less than 10 dimensions are supported.");
        }

        /// <summary>
        /// Create a numpy array of short with specified shape.
        /// <param name="shape">The shape of the new array.</param>
        /// <returns>The new numpy array with desired shape.</returns>
        /// </summary>
        public static NumpyArray<short> ArrayOfInt16WithShape(int[] shape)
        {
            if (shape.Length == 1)
            {
                return From(new short[shape[0]]);
            }
            else if (shape.Length == 2)
            {
                return From(new short[shape[0], shape[1]]);
            }
            else if (shape.Length == 3)
            {
                return From(new short[shape[0], shape[1], shape[2]]);
            }
            else if (shape.Length == 4)
            {
                return From(new short[shape[0], shape[1], shape[2], shape[3]]);
            }
            else if (shape.Length == 5)
            {
                return From(new short[shape[0], shape[1], shape[2], shape[3], shape[4]]);
            }
            else if (shape.Length == 6)
            {
                return From(new short[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5]]);
            }
            else if (shape.Length == 7)
            {
                return From(new short[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6]]);
            }
            else if (shape.Length == 8)
            {
                return From(new short[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7]]);
            }
            else if (shape.Length == 9)
            {
                return From(new short[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8]]);
            }
            else if (shape.Length == 10)
            {
                return From(new short[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8], shape[9]]);
            }

            throw new NumpyOperationException("The shape specified is not supported; only arrays less than 10 dimensions are supported.");
        }

        /// <summary>
        /// Create a numpy array of int with specified shape.
        /// <param name="shape">The shape of the new array.</param>
        /// <returns>The new numpy array with desired shape.</returns>
        /// </summary>
        public static NumpyArray<int> ArrayOfInt32WithShape(int[] shape)
        {
            if (shape.Length == 1)
            {
                return From(new int[shape[0]]);
            }
            else if (shape.Length == 2)
            {
                return From(new int[shape[0], shape[1]]);
            }
            else if (shape.Length == 3)
            {
                return From(new int[shape[0], shape[1], shape[2]]);
            }
            else if (shape.Length == 4)
            {
                return From(new int[shape[0], shape[1], shape[2], shape[3]]);
            }
            else if (shape.Length == 5)
            {
                return From(new int[shape[0], shape[1], shape[2], shape[3], shape[4]]);
            }
            else if (shape.Length == 6)
            {
                return From(new int[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5]]);
            }
            else if (shape.Length == 7)
            {
                return From(new int[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6]]);
            }
            else if (shape.Length == 8)
            {
                return From(new int[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7]]);
            }
            else if (shape.Length == 9)
            {
                return From(new int[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8]]);
            }
            else if (shape.Length == 10)
            {
                return From(new int[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8], shape[9]]);
            }

            throw new NumpyOperationException("The shape specified is not supported; only arrays less than 10 dimensions are supported.");
        }

        /// <summary>
        /// Create a numpy array of long with specified shape.
        /// <param name="shape">The shape of the new array.</param>
        /// <returns>The new numpy array with desired shape.</returns>
        /// </summary>
        public static NumpyArray<long> ArrayOfInt64WithShape(int[] shape)
        {
            if (shape.Length == 1)
            {
                return From(new long[shape[0]]);
            }
            else if (shape.Length == 2)
            {
                return From(new long[shape[0], shape[1]]);
            }
            else if (shape.Length == 3)
            {
                return From(new long[shape[0], shape[1], shape[2]]);
            }
            else if (shape.Length == 4)
            {
                return From(new long[shape[0], shape[1], shape[2], shape[3]]);
            }
            else if (shape.Length == 5)
            {
                return From(new long[shape[0], shape[1], shape[2], shape[3], shape[4]]);
            }
            else if (shape.Length == 6)
            {
                return From(new long[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5]]);
            }
            else if (shape.Length == 7)
            {
                return From(new long[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6]]);
            }
            else if (shape.Length == 8)
            {
                return From(new long[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7]]);
            }
            else if (shape.Length == 9)
            {
                return From(new long[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8]]);
            }
            else if (shape.Length == 10)
            {
                return From(new long[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8], shape[9]]);
            }

            throw new NumpyOperationException("The shape specified is not supported; only arrays less than 10 dimensions are supported.");
        }

        /// <summary>
        /// Create a numpy array of float with specified shape.
        /// <param name="shape">The shape of the new array.</param>
        /// <returns>The new numpy array with desired shape.</returns>
        /// </summary>
        public static NumpyArray<float> ArrayOfFloatWithShape(int[] shape)
        {
            if (shape.Length == 1)
            {
                return From(new float[shape[0]]);
            }
            else if (shape.Length == 2)
            {
                return From(new float[shape[0], shape[1]]);
            }
            else if (shape.Length == 3)
            {
                return From(new float[shape[0], shape[1], shape[2]]);
            }
            else if (shape.Length == 4)
            {
                return From(new float[shape[0], shape[1], shape[2], shape[3]]);
            }
            else if (shape.Length == 5)
            {
                return From(new float[shape[0], shape[1], shape[2], shape[3], shape[4]]);
            }
            else if (shape.Length == 6)
            {
                return From(new float[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5]]);
            }
            else if (shape.Length == 7)
            {
                return From(new float[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6]]);
            }
            else if (shape.Length == 8)
            {
                return From(new float[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7]]);
            }
            else if (shape.Length == 9)
            {
                return From(new float[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8]]);
            }
            else if (shape.Length == 10)
            {
                return From(new float[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8], shape[9]]);
            }

            throw new NumpyOperationException("The shape specified is not supported; only arrays less than 10 dimensions are supported.");
        }

        /// <summary>
        /// Create a numpy array of double with specified shape.
        /// <param name="shape">The shape of the new array.</param>
        /// <returns>The new numpy array with desired shape.</returns>
        /// </summary>
        public static NumpyArray<double> ArrayOfDoubleWithShape(int[] shape)
        {
            if (shape.Length == 1)
            {
                return From(new double[shape[0]]);
            }
            else if (shape.Length == 2)
            {
                return From(new double[shape[0], shape[1]]);
            }
            else if (shape.Length == 3)
            {
                return From(new double[shape[0], shape[1], shape[2]]);
            }
            else if (shape.Length == 4)
            {
                return From(new double[shape[0], shape[1], shape[2], shape[3]]);
            }
            else if (shape.Length == 5)
            {
                return From(new double[shape[0], shape[1], shape[2], shape[3], shape[4]]);
            }
            else if (shape.Length == 6)
            {
                return From(new double[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5]]);
            }
            else if (shape.Length == 7)
            {
                return From(new double[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6]]);
            }
            else if (shape.Length == 8)
            {
                return From(new double[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7]]);
            }
            else if (shape.Length == 9)
            {
                return From(new double[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8]]);
            }
            else if (shape.Length == 10)
            {
                return From(new double[shape[0], shape[1], shape[2], shape[3], shape[4], shape[5], shape[6], shape[7],
                    shape[8], shape[9]]);
            }

            throw new NumpyOperationException("The shape specified is not supported; only arrays less than 10 dimensions are supported.");
        }
    }
}