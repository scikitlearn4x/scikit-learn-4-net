using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using SkLearn.Core.Packaging;

namespace SkLearn.Test.Core.Packaging
{
    [TestFixture]
    public class BinaryModelPackageComplexTypesTests
    {
        [Test]
        public void TestReadingNullString()
        {
            byte[] data = new byte[] { 0 };

            String actual = readStringFromByteArray(data);
            Assert.Null(actual);
        }

        [Test]
        public void TestReadingASCIIString()
        {
            byte[] data = new byte[] { 1, 4, 0, 0, 0, 116, 101, 115, 116 };
            String expected = "test";

            String actual = readStringFromByteArray(data);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReadingUTF8String()
        {
            byte[] data = new byte[]
            {
                1, 10, 0, 0, 0, (byte)217, (byte)134, (byte)217, (byte)133, (byte)217, (byte)136, (byte)217, (byte)134,
                (byte)217, (byte)135
            };
            String expected = "نمونه";

            String actual = readStringFromByteArray(data);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReadSimpleNullNumpyArray()
        {
            byte[] data = new byte[] { 0 };

            Object actual = readNumpyArrayFromByteArray(data);
            Assert.Null(actual);
        }

        [Test]
        public void TestReadSimpleUint8NumpyArray()
        {
            byte[] data = new byte[] { 1, 1, 0, 0, 0, 17, 2, 0, 0, 0, 6, 7 };
            byte[] expected = new byte[] { 6, 7 };

            byte[] actual = (byte[])readNumpyArrayFromByteArray(data);
            checkArraySimilarity(expected, actual);
        }

        [Test]
        public void TestReadSimpleUint16NumpyArray()
        {
            byte[] data = new byte[] { 1, 1, 0, 0, 0, 18, 2, 0, 0, 0, 6, 0, 7, 0 };
            short[] expected = new short[] { 6, 7 };

            short[] actual = (short[])readNumpyArrayFromByteArray(data);
            checkArraySimilarity(expected, actual);
        }

        [Test]
        public void TestReadSimpleUint32NumpyArray()
        {
            byte[] data = new byte[] { 1, 1, 0, 0, 0, 20, 2, 0, 0, 0, 6, 0, 0, 0, 7, 0, 0, 0 };
            int[] expected = new int[] { 6, 7 };

            int[] actual = (int[])readNumpyArrayFromByteArray(data);
            checkArraySimilarity(expected, actual);
        }

        [Test]
        public void TestReadSimpleUint64NumpyArray()
        {
            byte[] data = new byte[] { 1, 1, 0, 0, 0, 24, 2, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 0 };
            long[] expected = new long[] { 6, 7 };

            long[] actual = (long[])readNumpyArrayFromByteArray(data);
            checkArraySimilarity(expected, actual);
        }

        [Test]
        public void TestReadSimpleFloatNumpyArray()
        {
            byte[] data = new byte[]
                { 1, 1, 0, 0, 0, 32, 3, 0, 0, 0, 1, 0, 0, (byte)192, 64, 1, 0, 0, (byte)224, 64, 0 };
            float[] expected = new float[] { 6, 7, float.NaN };

            float[] actual = (float[])readNumpyArrayFromByteArray(data);
            checkArraySimilarity(expected, actual);
        }

        [Test]
        public void TestReadSimpleDoubleNumpyArray()
        {
            byte[] data = new byte[]
                { 1, 1, 0, 0, 0, 33, 3, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 24, 64, 1, 0, 0, 0, 0, 0, 0, 28, 64, 0 };
            double[] expected = new double[] { 6, 7, Double.NaN };

            double[] actual = (double[])readNumpyArrayFromByteArray(data);
            checkArraySimilarity(expected, actual);
        }

        [Test]
        public void TestReadVerticalUint8NumpyArray()
        {
            byte[] data = new byte[] { 1, 2, 0, 0, 0, 17, 2, 0, 0, 0, 1, 0, 0, 0, 6, 7 };
            byte[][] expected = new byte[][] { new byte[] { 6 }, new byte[] { 7 } };

            byte[,] actual = (byte[,])readNumpyArrayFromByteArray(data);
            checkArraySimilarity(expected, actual);
        }

        [Test]
        public void TestReadVerticalUint32NumpyArray()
        {
            byte[] data = new byte[] { 1, 2, 0, 0, 0, 4, 2, 0, 0, 0, 1, 0, 0, 0, 6, 0, 0, 0, 7, 0, 0, 0 };
            int[][] expected = new int[][] { new int[] { 6 }, new int[] { 7 } };

            int[,] actual = (int[,])readNumpyArrayFromByteArray(data);
            checkArraySimilarity(expected, actual);
        }

        [Test]
        public void TestRead3DimensionTensorUint32NumpyArray()
        {
            byte[] data = new byte[]
            {
                1, 3, 0, 0, 0, 4, 2, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 6, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 9, 0, 0, 0
            };
            int[][][] expected = new int[][][]
                { new int[][] { new int[] { 6 }, new int[] { 7 } }, new int[][] { new int[] { 8 }, new int[] { 9 } } };

            int[,,] actual = (int[,,])readNumpyArrayFromByteArray(data);
            checkArraySimilarity(expected, actual);
        }

        [Test]
        public void TestReadingNullDictionary()
        {
            byte[] data = new byte[] { 0 };
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            Dictionary<String, Object> actual = binary.ReadDictionary();
            Assert.Null(actual);
        }

        [Test]
        public void TestReadingEmptyDictionary()
        {
            byte[] data = new byte[] { 1, 0, 0, 0, 0 };
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            Dictionary<String, Object> actual = binary.ReadDictionary();
            Assert.AreEqual(0, actual.Count);
        }

        [Test]
        public void TestReadingDictionary()
        {
            byte[] data = new byte[]
            {
                1, 6, 0, 0, 0, 1, 7, 0, 0, 0, 107, 101, 121, 95, 105, 110, 116, 8, 15, 0, 0, 0, 0, 0, 0, 0, 1, 18, 0, 0,
                0, 107, 101, 121, 95, 102, 108, 111, 97, 116, 105, 110, 103, 95, 112, 111, 105, 110, 116, 33, 1, 31,
                (byte)133, (byte)235, 81, (byte)184, 30, 9, 64, 1, 10, 0, 0, 0, 107, 101, 121, 95, 115, 116, 114, 105,
                110, 103, 48, 1, 16, 0, 0, 0, 84, 104, 105, 115, 32, 105, 115, 32, 97, 32, 115, 116, 114, 105, 110, 103,
                1, 8, 0, 0, 0, 107, 101, 121, 95, 108, 105, 115, 116, 64, 1, 5, 0, 0, 0, 8, 1, 0, 0, 0, 0, 0, 0, 0, 33,
                1, 31, (byte)133, (byte)235, 81, (byte)184, 30, 9, 64, 48, 1, 14, 0, 0, 0, 97, 110, 111, 116, 104, 101,
                114, 95, 115, 116, 114, 105, 110, 103, 65, 1, 2, 0, 0, 0, 1, 6, 0, 0, 0, 115, 97, 109, 112, 108, 101,
                48, 1, 3, 0, 0, 0, 111, 110, 101, 1, 7, 0, 0, 0, 97, 110, 111, 116, 104, 101, 114, 33, 1, 92, (byte)143,
                (byte)194, (byte)245, 40, 92, 27, (byte)192, 16, 1, 14, 0, 0, 0, 107, 101, 121, 95, 100, 105, 99, 116,
                105, 111, 110, 97, 114, 121, 65, 1, 2, 0, 0, 0, 1, 8, 0, 0, 0, 111, 112, 116, 105, 111, 110, 95, 49, 48,
                1, 4, 0, 0, 0, 74, 97, 118, 97, 1, 8, 0, 0, 0, 111, 112, 116, 105, 111, 110, 95, 50, 48, 1, 2, 0, 0, 0,
                67, 35, 1, 8, 0, 0, 0, 110, 117, 108, 108, 95, 107, 101, 121, 16
            };
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            Dictionary<String, Object> actual = binary.ReadDictionary();
            Assert.AreEqual(6, actual.Count);

            Assert.AreEqual(15, actual["key_int"]);
            Assert.AreEqual(3.14, actual["key_floating_point"]);
            Assert.AreEqual("This is a string", actual["key_string"]);
            Assert.Null(actual["null_key"]);

            Dictionary<String, Object> subDictionary = (Dictionary<String, Object>)actual["key_dictionary"];
            Assert.AreEqual(2, subDictionary.Count);
            Assert.AreEqual("Java", subDictionary["option_1"]);
            Assert.AreEqual("C#", subDictionary["option_2"]);

            List<Object> subList = (List<Object>)actual["key_list"];
            Assert.AreEqual(5, subList.Count);
            Assert.AreEqual(1, (long)subList[0]);
            Assert.AreEqual(3.14, (double)subList[1]);
            Assert.AreEqual("another_string", subList[2]);
            Assert.Null(subList[4]);

            Dictionary<String, Object> listDictionary = (Dictionary<String, Object>)subList[3];
            Assert.AreEqual(2, listDictionary.Count);
            Assert.AreEqual("one", listDictionary["sample"]);
            Assert.AreEqual(-6.84, listDictionary["another"]);
        }

        private void checkArraySimilarity(byte[] expected, byte[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        private void checkArraySimilarity(byte[][] expected, byte[,] actual)
        {
            Assert.AreEqual(expected.Length, actual.GetLength(0));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].Length, actual.GetLength(1));
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i, j]);
                }
            }
        }

        private void checkArraySimilarity(short[] expected, short[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        private void checkArraySimilarity(int[] expected, int[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        private void checkArraySimilarity(int[][] expected, int[,] actual)
        {
            Assert.AreEqual(expected.Length, actual.GetLength(0));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].Length, actual.GetLength(1));
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i, j]);
                }
            }
        }

        private void checkArraySimilarity(int[][][] expected, int[,,] actual)
        {
            Assert.AreEqual(expected.Length, actual.GetLength(0));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].Length, actual.GetLength(1));
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j].Length, actual.GetLength(2));
                    for (int k = 0; k < expected[i][j].Length; k++)
                    {
                        Assert.AreEqual(expected[i][j][k], actual[i, j, k]);
                    }
                }
            }
        }

        private void checkArraySimilarity(long[] expected, long[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        private void checkArraySimilarity(float[] expected, float[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        private void checkArraySimilarity(double[] expected, double[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        private String readStringFromByteArray(byte[] data)
        {
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            return binary.ReadString();
        }

        private Object readNumpyArrayFromByteArray(byte[] data)
        {
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            return binary.ReadNumpyArray();
        }
    }
}