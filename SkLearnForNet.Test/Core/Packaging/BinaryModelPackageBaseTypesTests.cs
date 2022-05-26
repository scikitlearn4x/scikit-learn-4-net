using System;
using System.IO;
using NUnit.Framework;
using SkLearn.Core.Packaging;

namespace SkLearn.Test.Core.Packaging
{
    [TestFixture]
    public class BinaryModelPackageBaseTypesTests
    {
        private const double DOUBLE_COMPARE_EPSILON = 0.001;

        [Test]
        public void TestReadFloatNaN()
        {
            byte[] data = { 0 };
            float expected = float.NaN;

            float actual = ReadFloatFromByteArray(data);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReadDoubleNaN()
        {
            byte[] data = { 0 };
            double expected = float.NaN;

            double actual = ReadDoubleFromByteArray(data);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReadFloatPiPositive()
        {
            byte[] data = { 1, 86, 14, 73, 64 };
            float expected = 3.1415f;

            float actual = ReadFloatFromByteArray(data);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReadFloatPiNegative()
        {
            byte[] data = ToByteArray(new sbyte[] { 1, 86, 14, 73, -64 });
            float expected = -3.1415f;

            float actual = ReadFloatFromByteArray(data);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestReadFloatEPositive()
        {
            byte[] data = ToByteArray(new sbyte[]{ 1, 77, -8, 45, 64 });
            float expected = 2.71828f;

            float actual = ReadFloatFromByteArray(data);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReadFloatENegative()
        {
            byte[] data = ToByteArray(new sbyte[]{ 1, 77, -8, 45, -64 });
            float expected = -2.71828f;

            float actual = ReadFloatFromByteArray(data);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReadDoublePiPositive()
        {
            byte[] data = ToByteArray(new sbyte[]{ 1, 111, 18, -125, -64, -54, 33, 9, 64 });
            double expected = 3.1415f;

            double actual = ReadDoubleFromByteArray(data);
            Assert.True(Math.Abs(expected - actual) < DOUBLE_COMPARE_EPSILON);
        }

        [Test]
        public void TestReadDoublePiNegative()
        {
            byte[] data = ToByteArray(new sbyte[]{ 1, 111, 18, -125, -64, -54, 33, 9, -64 });
            double expected = -3.1415f;

            double actual = ReadDoubleFromByteArray(data);
            Assert.True(Math.Abs(expected - actual) < DOUBLE_COMPARE_EPSILON);
        }

        [Test]
        public void TestReadDoubleEPositive()
        {
            byte[] data = ToByteArray(new sbyte[]{ 1, -112, -9, -86, -107, 9, -65, 5, 64 });
            double expected = 2.71828f;

            double actual = ReadDoubleFromByteArray(data);
            Assert.True(Math.Abs(expected - actual) < DOUBLE_COMPARE_EPSILON);
        }

        [Test]
        public void TestReadDoubleENegative()
        {
            byte[] data = ToByteArray(new sbyte[]{ 1, -112, -9, -86, -107, 9, -65, 5, -64 });
            double expected = -2.71828f;

            double actual = ReadDoubleFromByteArray(data);
            Assert.True(Math.Abs(expected - actual) < DOUBLE_COMPARE_EPSILON);
        }

        [Test]
        public void TestReadBytePositive()
        {
            byte[] data = { 23 };
            int expected = 23;

            int actual = ReadByteFromByteArray(data);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReadByteNegative()
        {
            byte[] data = ToByteArray(new sbyte[]{ -8 });
            int expected = data[0];

            int actual = ReadByteFromByteArray(data);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReadShortIntegers()
        {
            TestReadShortInteger(10, new byte[]{10, 0});
            TestReadShortInteger(567, new byte[]{55, 2});
            TestReadShortInteger(16000, ToByteArray(new sbyte[]{-128, 62}));
            TestReadShortInteger(-16000, ToByteArray(new sbyte[]{-128, -63}));
        }

        [Test]
        public void TestReadIntegers()
        {
            TestReadInteger(10, new byte[]{10, 0, 0, 0});
            TestReadInteger(567, new byte[]{55, 2, 0, 0});
            TestReadInteger(16000, ToByteArray(new sbyte[]{-128, 62, 0, 0}));
            TestReadInteger(59, new byte[]{59, 0, 0, 0});
            TestReadInteger(-59, ToByteArray(new sbyte[]{-59, -1, -1, -1}));
            TestReadInteger(300, new byte[]{44, 1, 0, 0});
            TestReadInteger(-300, ToByteArray(new sbyte[]{-44, -2, -1, -1}));
            TestReadInteger(2000000000, ToByteArray(new sbyte[]{0, -108, 53, 119}));
            TestReadInteger(-2000000000, ToByteArray(new sbyte[]{0, 108, -54, -120}));

        }

        [Test]
        public void TestReadLongIntegers()
        {
            TestReadLongInteger(10, new byte[]{10, 0, 0, 0, 0, 0, 0, 0});
            TestReadLongInteger(567, new byte[]{55, 2, 0, 0, 0, 0, 0, 0});
            TestReadLongInteger(16000, ToByteArray(new sbyte[]{-128, 62, 0, 0, 0, 0, 0, 0}));
            TestReadLongInteger(59, new byte[]{59, 0, 0, 0, 0, 0, 0, 0});
            TestReadLongInteger(-59, ToByteArray(new sbyte[]{-59, -1, -1, -1, -1, -1, -1, -1}));
            TestReadLongInteger(300, new byte[]{44, 1, 0, 0, 0, 0, 0, 0});
            TestReadLongInteger(-300, ToByteArray(new sbyte[]{-44, -2, -1, -1, -1, -1, -1, -1}));
            TestReadLongInteger(2000000000, ToByteArray(new sbyte[]{0, -108, 53, 119, 0, 0, 0, 0}));
            TestReadLongInteger(-2000000000, ToByteArray(new sbyte[]{0, 108, -54, -120, -1, -1, -1, -1}));
            TestReadLongInteger(200000000000000000L, ToByteArray(new sbyte[]{0, 0, 20, -69, -16, -118, -58, 2}));
            TestReadLongInteger(-200000000000000000L, ToByteArray(new sbyte[]{0, 0, -20, 68, 15, 117, 57, -3}));

        }

        private void TestReadShortInteger(int expected, byte[] data)
        {
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            int actual = binary.ReadShort();
            Assert.AreEqual(expected, actual);
        }

        private void TestReadInteger(int expected, byte[] data)
        {
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            int actual = binary.ReadInteger();
            Assert.AreEqual(expected, actual);
        }

        private void TestReadLongInteger(long expected, byte[] data)
        {
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            long actual = binary.ReadLongInteger();
            Assert.AreEqual(expected, actual);
        }

        private float ReadFloatFromByteArray(byte[] data)
        {
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            return binary.ReadFloat();
        }

        private double ReadDoubleFromByteArray(byte[] data)
        {
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            return binary.ReadDouble();
        }

        private int ReadByteFromByteArray(byte[] data)
        {
            Stream stream = new MemoryStream(data);
            BinaryModelPackage binary = BinaryModelPackage.FromStream(stream);

            return binary.ReadByte();
        }
        
        private byte[] ToByteArray(sbyte[] data)
        {
            byte[] result = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)data[i];
            }
            
            return result;
        }
    }
}