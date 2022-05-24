using System;
using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Test
{
    public static class TestHelper
    {
        private const double DOUBLE_COMPARE_EPSILON = 0.0000001;

        public static void AreArrayEqual(int[] expected, int[] actual)
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
    }
}