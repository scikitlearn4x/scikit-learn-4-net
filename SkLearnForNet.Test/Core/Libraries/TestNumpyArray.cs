using System;
using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Test.Core.Libraries
{
    [TestFixture]
    public class TestNumpyArray
    {
        [Test]
        public void TestArgmax()
        {
            double[,,] data = new[,,]
            {
                {
                    { 0.34207587, 0.59631829, 0.59525696, 0.95059543, 0.39912264 },
                    { 0.85464008, 0.90788009, 0.82057904, 0.43492519, 0.43897654 },
                    { 0.80624335, 0.80625582, 0.04637509, 0.21079158, 0.2956869 }
                },
                {
                    { 0.53870154, 0.54324711, 0.86099808, 0.21863662, 0.2951117 },
                    { 0.45954226, 0.1318496, 0.94744519, 0.95518557, 0.16132475 },
                    { 0.67286602, 0.2399391, 0.40854949, 0.8254005, 0.47404008 }
                }
            };
            NumpyArray<double> array = NumpyArrayFactory.From(data);

            NumpyArray<long> axis0 = Numpy.Argmax(array, 0);
            long[][] axis0Expected = new long[][]
                { new long[] { 1, 0, 1, 0, 0 }, new long[] { 0, 0, 1, 1, 0, }, new long[] { 0, 0, 1, 1, 1 } };
            TestHelper.AssertEqualData(axis0, axis0Expected);

            NumpyArray<long> axis1 = Numpy.Argmax(array, 1);
            long[][] axis1Expected = new long[][] { new long[] { 1, 1, 1, 0, 1 }, new long[] { 2, 0, 1, 1, 2 } };
            TestHelper.AssertEqualData(axis1, axis1Expected);

            NumpyArray<long> axis2 = Numpy.Argmax(array, 2);
            long[][] axis2Expected = new long[][] { new long[] { 3, 1, 1 }, new long[] { 2, 3, 3 } };
            TestHelper.AssertEqualData(axis2, axis2Expected);
        }

        [Test]
        public void TestSum()
        {
            double[,] data = new double[,]
                { { 0.817, 0.721, 0.67, 0.3 }, { 0.524, 0.935, 0.883, 0.866 }, { 0.134, 0.849, 0.578, 0.142 } };

            NumpyArray<double> array = NumpyArrayFactory.From(data);

            double[] axis0Expected = { 1.475, 2.505, 2.131, 1.308 };
            NumpyArray<double> axis0 = Numpy.Sum(array, 0);
            TestHelper.AssertEqualData(axis0, axis0Expected);

            double[] axis1Expected = { 2.508, 3.208, 1.703 };
            NumpyArray<double> axis1 = Numpy.Sum(array, 1);
            TestHelper.AssertEqualData(axis1, axis1Expected);
        }

        [Test]
        public void TestOneDimensionIntegerArray()
        {
            int dim1 = 10;
            int[] data = new int[dim1];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            NumpyArray<int> np = NumpyArrayFactory.From(data);
            TestHelper.AreArrayEqual(new int[] { dim1 }, np.Shape);

            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(i, np.Get(i));
            }

            np.ApplyToEachElement((value) => value * 2);

            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(i * 2, np.Get(i));
            }
        }

        [Test]
        public void TestTwoDimensionIntegerArray()
        {
            int dim1 = 10;
            int dim2 = 5;
            int[,] data = new int[dim1, dim2];
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    data[i, j] = i * dim2 + j;
                }
            }

            NumpyArray<int> np = NumpyArrayFactory.From(data);
            TestHelper.AreArrayEqual(new int[] { dim1, dim2 }, np.Shape);

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    Assert.AreEqual(i * dim2 + j, np.Get(i, j));
                }
            }

            np.ApplyToEachElement((value) => value * 2);

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    Assert.AreEqual(2 * (i * dim2 + j), np.Get(i, j));
                }
            }
        }

        [Test]
        public void TestOneDimensionDoubleArray()
        {
            int dim1 = 10;
            double[] data = new double[dim1];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            NumpyArray<Double> np = NumpyArrayFactory.From(data);
            TestHelper.AreArrayEqual(new int[] { dim1 }, np.Shape);

            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(i, np.Get(i));
            }

            np.ApplyToEachElement((value) => value * 2);

            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(i * 2, np.Get(i));
            }
        }

        [Test]
        public void TestTwoDimensionDoubleArray()
        {
            int dim1 = 10;
            int dim2 = 5;
            double[,] data = new double[dim1, dim2];
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    data[i, j] = i * dim2 + j;
                }
            }

            NumpyArray<double> np = NumpyArrayFactory.From(data);
            TestHelper.AreArrayEqual(new int[] { dim1, dim2 }, np.Shape);

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    Assert.AreEqual(i * dim2 + j, np.Get(i, j));
                }
            }

            np.ApplyToEachElement(value => value * 2);

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    Assert.AreEqual(2 * (i * dim2 + j), np.Get(i, j));
                }
            }
        }

        [Test]
        public void TestWrapSubArray()
        {
            int[,,] data = new int[,,] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
            NumpyArray<int> np = NumpyArrayFactory.From(data);

            NumpyArray<int> sub = np.WrapInnerSubsetArray(1);
            Assert.AreEqual(2, sub.NumberOfDimensions);
            Assert.AreEqual(2, sub.Shape[0]);
            Assert.AreEqual(2, sub.Shape[1]);
            Assert.AreEqual(5, sub.Get(0, 0));
            Assert.AreEqual(6, sub.Get(0, 1));
            Assert.AreEqual(7, sub.Get(1, 0));
            Assert.AreEqual(8, sub.Get(1, 1));
        }
    }
}