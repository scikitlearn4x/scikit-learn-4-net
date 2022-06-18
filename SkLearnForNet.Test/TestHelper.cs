using System;
using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Test
{
    public static class TestHelper
    {
        private const double DOUBLE_COMPARE_EPSILON = 0.0000001;
        public const String TEST_FILES_HOME = "/Volumes/Files/Projects/scikit-learn4x/Test Files"; // Should not end with '/'

        public static void AreArrayEqual(int[] expected, int[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public static void AreArrayEqual(long[] expected, long[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public static void AssertEqualData(NumpyArray<double> numpyArray, double[] array)
        {
            Assert.AreEqual(1, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);

            for (int i = 0; i < array.Length; i++)
            {
                double diff = Math.Abs(array[i] - numpyArray.Get(i));
                bool check = diff < DOUBLE_COMPARE_EPSILON;

                Assert.True(check);
            }
        }

        public static void AssertEqualData(NumpyArray<long> numpyArray, long[][] array)
        {
            Assert.AreEqual(2, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Assert.AreEqual(array[i][j], numpyArray.Get(i, j));
                }
            }
        }

        public static void AssertEqualData(NumpyArray<int> numpyArray, int[][] array)
        {
            Assert.AreEqual(2, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Assert.AreEqual(array[i][j], numpyArray.Get(i, j));
                }
            }
        }

        public static void AssertEqualData(NumpyArray<short> numpyArray, short[][] array)
        {
            Assert.AreEqual(2, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Assert.AreEqual(array[i][j], numpyArray.Get(i, j));
                }
            }
        }

        public static void AssertEqualData(NumpyArray<Byte> numpyArray, byte[][] array)
        {
            Assert.AreEqual(2, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Assert.AreEqual(array[i][j], numpyArray.Get(i, j));
                }
            }
        }

        public static void AssertEqualData(NumpyArray<double> numpyArray, double[][] array)
        {
            Assert.AreEqual(2, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    double diff = Math.Abs(array[i][j] - numpyArray.Get(i, j));
                    bool check = diff < DOUBLE_COMPARE_EPSILON;

                    Assert.True(check);
                }
            }
        }

        public static void AssertEqualData(NumpyArray<double> numpyArray, double[,] array)
        {
            Assert.AreEqual(2, numpyArray.Shape.Length);
            Assert.AreEqual(array.GetLength(0), numpyArray.Shape[0]);
            Assert.AreEqual(array.GetLength(1), numpyArray.Shape[1]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    double diff = Math.Abs(array[i, j] - numpyArray.Get(i, j));
                    bool check = diff < DOUBLE_COMPARE_EPSILON;

                    Assert.True(check);
                }
            }
        }

        public static void AssertEqualData(NumpyArray<float> numpyArray, float[,] array)
        {
            Assert.AreEqual(2, numpyArray.Shape.Length);
            Assert.AreEqual(array.GetLength(0), numpyArray.Shape[0]);
            Assert.AreEqual(array.GetLength(1), numpyArray.Shape[1]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    double diff = Math.Abs(array[i, j] - numpyArray.Get(i, j));
                    bool check = diff < DOUBLE_COMPARE_EPSILON;

                    Assert.True(check);
                }
            }
        }

        public static void AssertEqualData(NumpyArray<float> numpyArray, float[][] array)
        {
            Assert.AreEqual(2, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    double diff = Math.Abs(array[i][j] - numpyArray.Get(i, j));
                    bool check = diff < DOUBLE_COMPARE_EPSILON;

                    Assert.True(check);
                }
            }
        }

        public static void AssertEqualData(NumpyArray<double> numpyArray, double[][][] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);
            Assert.AreEqual(array[0][0].Length, numpyArray.Shape[2]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        double diff = Math.Abs(array[i][j][k] - numpyArray.Get(i, j, k));
                        bool check = diff < DOUBLE_COMPARE_EPSILON;

                        Assert.True(check);
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<double> numpyArray, double[,,] array)
        {
            AssertEqualData(numpyArray, array, DOUBLE_COMPARE_EPSILON);
        }
        
        public static void AssertEqualData(NumpyArray<double> numpyArray, double[,,] array, double epsilon)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.GetLength(0), numpyArray.Shape[0]);
            Assert.AreEqual(array.GetLength(1), numpyArray.Shape[1]);
            Assert.AreEqual(array.GetLength(2), numpyArray.Shape[2]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        double diff = Math.Abs(array[i, j, k] - numpyArray.Get(i, j, k));
                        bool check = diff < epsilon;

                        Assert.True(check);
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<float> numpyArray, float[][][] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);
            Assert.AreEqual(array[0][0].Length, numpyArray.Shape[2]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        double diff = Math.Abs(array[i][j][k] - numpyArray.Get(i, j, k));
                        bool check = diff < DOUBLE_COMPARE_EPSILON;

                        Assert.True(check);
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<float> numpyArray, float[,,] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.GetLength(0), numpyArray.Shape[0]);
            Assert.AreEqual(array.GetLength(1), numpyArray.Shape[1]);
            Assert.AreEqual(array.GetLength(2), numpyArray.Shape[2]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        double diff = Math.Abs(array[i, j, k] - numpyArray.Get(i, j, k));
                        bool check = diff < DOUBLE_COMPARE_EPSILON;

                        Assert.True(check);
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<byte> numpyArray, byte[,,] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.GetLength(0), numpyArray.Shape[0]);
            Assert.AreEqual(array.GetLength(1), numpyArray.Shape[1]);
            Assert.AreEqual(array.GetLength(2), numpyArray.Shape[2]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Assert.AreEqual(array[i, j, k], numpyArray.Get(i, j, k));
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<long> numpyArray, long[,,] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.GetLength(0), numpyArray.Shape[0]);
            Assert.AreEqual(array.GetLength(1), numpyArray.Shape[1]);
            Assert.AreEqual(array.GetLength(2), numpyArray.Shape[2]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Assert.AreEqual(array[i, j, k], numpyArray.Get(i, j, k));
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<int> numpyArray, int[,,] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.GetLength(0), numpyArray.Shape[0]);
            Assert.AreEqual(array.GetLength(1), numpyArray.Shape[1]);
            Assert.AreEqual(array.GetLength(2), numpyArray.Shape[2]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Assert.AreEqual(array[i, j, k], numpyArray.Get(i, j, k));
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<short> numpyArray, short[,,] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.GetLength(0), numpyArray.Shape[0]);
            Assert.AreEqual(array.GetLength(1), numpyArray.Shape[1]);
            Assert.AreEqual(array.GetLength(2), numpyArray.Shape[2]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Assert.AreEqual(array[i, j, k], numpyArray.Get(i, j, k));
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<Byte> numpyArray, byte[][][] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);
            Assert.AreEqual(array[0][0].Length, numpyArray.Shape[2]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        Assert.AreEqual(array[i][j][k], numpyArray.Get(i, j, k));
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<short> numpyArray, short[][][] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);
            Assert.AreEqual(array[0][0].Length, numpyArray.Shape[2]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        Assert.AreEqual(array[i][j][k], (short)numpyArray.Get(i, j, k));
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<int> numpyArray, int[][][] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);
            Assert.AreEqual(array[0][0].Length, numpyArray.Shape[2]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        Assert.AreEqual(array[i][j][k], numpyArray.Get(i, j, k));
                    }
                }
            }
        }

        public static void AssertEqualData(NumpyArray<long> numpyArray, long[][][] array)
        {
            Assert.AreEqual(3, numpyArray.Shape.Length);
            Assert.AreEqual(array.Length, numpyArray.Shape[0]);
            Assert.AreEqual(array[0].Length, numpyArray.Shape[1]);
            Assert.AreEqual(array[0][0].Length, numpyArray.Shape[2]);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        Assert.AreEqual(array[i][j][k], numpyArray.Get(i, j, k));
                    }
                }
            }
        }

        public static string GetAbsolutePathOfBinaryPackage(String path)
        {
            return "/Users/yektaie/Documents/Unit Test Generation/binaries/" + path;
        }

        public static void AssertEqualPredictions(NumpyArray<long> predictions, long[] rawArray)
        {
            long[] preds = (long[])predictions.GetWrapper().RawArray;

            AreArrayEqual(rawArray, preds);
        }

        public static void AssertCorrectFeatureNames(String[] expected, String[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}