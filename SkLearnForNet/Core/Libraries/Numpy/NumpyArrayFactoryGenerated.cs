using System;
using SkLearn.Core.Libraries.Numpy.Wrappers;

namespace SkLearn.Core.Libraries.Numpy
{
    public partial class NumpyArrayFactory
    {
        public static NumpyArray<byte> From(byte[] array)
        {
            return new NumpyArray<byte>(new Dim1Int8NumpyWrapper(array));
        }

        public static NumpyArray<byte> From(byte[,] array)
        {
            return new NumpyArray<byte>(new Dim2Int8NumpyWrapper(array));
        }

        public static NumpyArray<byte> From(byte[,,] array)
        {
            return new NumpyArray<byte>(new Dim3Int8NumpyWrapper(array));
        }

        public static NumpyArray<byte> From(byte[,,,] array)
        {
            return new NumpyArray<byte>(new Dim4Int8NumpyWrapper(array));
        }

        public static NumpyArray<byte> From(byte[,,,,] array)
        {
            return new NumpyArray<byte>(new Dim5Int8NumpyWrapper(array));
        }

        public static NumpyArray<byte> From(byte[,,,,,] array)
        {
            return new NumpyArray<byte>(new Dim6Int8NumpyWrapper(array));
        }

        public static NumpyArray<byte> From(byte[,,,,,,] array)
        {
            return new NumpyArray<byte>(new Dim7Int8NumpyWrapper(array));
        }

        public static NumpyArray<byte> From(byte[,,,,,,,] array)
        {
            return new NumpyArray<byte>(new Dim8Int8NumpyWrapper(array));
        }

        public static NumpyArray<byte> From(byte[,,,,,,,,] array)
        {
            return new NumpyArray<byte>(new Dim9Int8NumpyWrapper(array));
        }

        public static NumpyArray<byte> From(byte[,,,,,,,,,] array)
        {
            return new NumpyArray<byte>(new Dim10Int8NumpyWrapper(array));
        }

        public static NumpyArray<short> From(short[] array)
        {
            return new NumpyArray<short>(new Dim1Int16NumpyWrapper(array));
        }

        public static NumpyArray<short> From(short[,] array)
        {
            return new NumpyArray<short>(new Dim2Int16NumpyWrapper(array));
        }

        public static NumpyArray<short> From(short[,,] array)
        {
            return new NumpyArray<short>(new Dim3Int16NumpyWrapper(array));
        }

        public static NumpyArray<short> From(short[,,,] array)
        {
            return new NumpyArray<short>(new Dim4Int16NumpyWrapper(array));
        }

        public static NumpyArray<short> From(short[,,,,] array)
        {
            return new NumpyArray<short>(new Dim5Int16NumpyWrapper(array));
        }

        public static NumpyArray<short> From(short[,,,,,] array)
        {
            return new NumpyArray<short>(new Dim6Int16NumpyWrapper(array));
        }

        public static NumpyArray<short> From(short[,,,,,,] array)
        {
            return new NumpyArray<short>(new Dim7Int16NumpyWrapper(array));
        }

        public static NumpyArray<short> From(short[,,,,,,,] array)
        {
            return new NumpyArray<short>(new Dim8Int16NumpyWrapper(array));
        }

        public static NumpyArray<short> From(short[,,,,,,,,] array)
        {
            return new NumpyArray<short>(new Dim9Int16NumpyWrapper(array));
        }

        public static NumpyArray<short> From(short[,,,,,,,,,] array)
        {
            return new NumpyArray<short>(new Dim10Int16NumpyWrapper(array));
        }

        public static NumpyArray<int> From(int[] array)
        {
            return new NumpyArray<int>(new Dim1Int32NumpyWrapper(array));
        }

        public static NumpyArray<int> From(int[,] array)
        {
            return new NumpyArray<int>(new Dim2Int32NumpyWrapper(array));
        }

        public static NumpyArray<int> From(int[,,] array)
        {
            return new NumpyArray<int>(new Dim3Int32NumpyWrapper(array));
        }

        public static NumpyArray<int> From(int[,,,] array)
        {
            return new NumpyArray<int>(new Dim4Int32NumpyWrapper(array));
        }

        public static NumpyArray<int> From(int[,,,,] array)
        {
            return new NumpyArray<int>(new Dim5Int32NumpyWrapper(array));
        }

        public static NumpyArray<int> From(int[,,,,,] array)
        {
            return new NumpyArray<int>(new Dim6Int32NumpyWrapper(array));
        }

        public static NumpyArray<int> From(int[,,,,,,] array)
        {
            return new NumpyArray<int>(new Dim7Int32NumpyWrapper(array));
        }

        public static NumpyArray<int> From(int[,,,,,,,] array)
        {
            return new NumpyArray<int>(new Dim8Int32NumpyWrapper(array));
        }

        public static NumpyArray<int> From(int[,,,,,,,,] array)
        {
            return new NumpyArray<int>(new Dim9Int32NumpyWrapper(array));
        }

        public static NumpyArray<int> From(int[,,,,,,,,,] array)
        {
            return new NumpyArray<int>(new Dim10Int32NumpyWrapper(array));
        }

        public static NumpyArray<long> From(long[] array)
        {
            return new NumpyArray<long>(new Dim1Int64NumpyWrapper(array));
        }

        public static NumpyArray<long> From(long[,] array)
        {
            return new NumpyArray<long>(new Dim2Int64NumpyWrapper(array));
        }

        public static NumpyArray<long> From(long[,,] array)
        {
            return new NumpyArray<long>(new Dim3Int64NumpyWrapper(array));
        }

        public static NumpyArray<long> From(long[,,,] array)
        {
            return new NumpyArray<long>(new Dim4Int64NumpyWrapper(array));
        }

        public static NumpyArray<long> From(long[,,,,] array)
        {
            return new NumpyArray<long>(new Dim5Int64NumpyWrapper(array));
        }

        public static NumpyArray<long> From(long[,,,,,] array)
        {
            return new NumpyArray<long>(new Dim6Int64NumpyWrapper(array));
        }

        public static NumpyArray<long> From(long[,,,,,,] array)
        {
            return new NumpyArray<long>(new Dim7Int64NumpyWrapper(array));
        }

        public static NumpyArray<long> From(long[,,,,,,,] array)
        {
            return new NumpyArray<long>(new Dim8Int64NumpyWrapper(array));
        }

        public static NumpyArray<long> From(long[,,,,,,,,] array)
        {
            return new NumpyArray<long>(new Dim9Int64NumpyWrapper(array));
        }

        public static NumpyArray<long> From(long[,,,,,,,,,] array)
        {
            return new NumpyArray<long>(new Dim10Int64NumpyWrapper(array));
        }

        public static NumpyArray<float> From(float[] array)
        {
            return new NumpyArray<float>(new Dim1FloatNumpyWrapper(array));
        }

        public static NumpyArray<float> From(float[,] array)
        {
            return new NumpyArray<float>(new Dim2FloatNumpyWrapper(array));
        }

        public static NumpyArray<float> From(float[,,] array)
        {
            return new NumpyArray<float>(new Dim3FloatNumpyWrapper(array));
        }

        public static NumpyArray<float> From(float[,,,] array)
        {
            return new NumpyArray<float>(new Dim4FloatNumpyWrapper(array));
        }

        public static NumpyArray<float> From(float[,,,,] array)
        {
            return new NumpyArray<float>(new Dim5FloatNumpyWrapper(array));
        }

        public static NumpyArray<float> From(float[,,,,,] array)
        {
            return new NumpyArray<float>(new Dim6FloatNumpyWrapper(array));
        }

        public static NumpyArray<float> From(float[,,,,,,] array)
        {
            return new NumpyArray<float>(new Dim7FloatNumpyWrapper(array));
        }

        public static NumpyArray<float> From(float[,,,,,,,] array)
        {
            return new NumpyArray<float>(new Dim8FloatNumpyWrapper(array));
        }

        public static NumpyArray<float> From(float[,,,,,,,,] array)
        {
            return new NumpyArray<float>(new Dim9FloatNumpyWrapper(array));
        }

        public static NumpyArray<float> From(float[,,,,,,,,,] array)
        {
            return new NumpyArray<float>(new Dim10FloatNumpyWrapper(array));
        }

        public static NumpyArray<double> From(double[] array)
        {
            return new NumpyArray<double>(new Dim1DoubleNumpyWrapper(array));
        }

        public static NumpyArray<double> From(double[,] array)
        {
            return new NumpyArray<double>(new Dim2DoubleNumpyWrapper(array));
        }

        public static NumpyArray<double> From(double[,,] array)
        {
            return new NumpyArray<double>(new Dim3DoubleNumpyWrapper(array));
        }

        public static NumpyArray<double> From(double[,,,] array)
        {
            return new NumpyArray<double>(new Dim4DoubleNumpyWrapper(array));
        }

        public static NumpyArray<double> From(double[,,,,] array)
        {
            return new NumpyArray<double>(new Dim5DoubleNumpyWrapper(array));
        }

        public static NumpyArray<double> From(double[,,,,,] array)
        {
            return new NumpyArray<double>(new Dim6DoubleNumpyWrapper(array));
        }

        public static NumpyArray<double> From(double[,,,,,,] array)
        {
            return new NumpyArray<double>(new Dim7DoubleNumpyWrapper(array));
        }

        public static NumpyArray<double> From(double[,,,,,,,] array)
        {
            return new NumpyArray<double>(new Dim8DoubleNumpyWrapper(array));
        }

        public static NumpyArray<double> From(double[,,,,,,,,] array)
        {
            return new NumpyArray<double>(new Dim9DoubleNumpyWrapper(array));
        }

        public static NumpyArray<double> From(double[,,,,,,,,,] array)
        {
            return new NumpyArray<double>(new Dim10DoubleNumpyWrapper(array));
        }

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

            throw new NotImplementedException();
        }

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

            throw new NotImplementedException();
        }

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

            throw new NotImplementedException();
        }

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

            throw new NotImplementedException();
        }

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

            throw new NotImplementedException();
        }

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

            throw new NotImplementedException();
        }
    }
}