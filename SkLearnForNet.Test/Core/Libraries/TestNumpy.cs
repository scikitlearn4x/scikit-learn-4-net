using NUnit.Framework;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Test.Core.Libraries
{
    [TestFixture]
    public class TestNumpy
    {
        [Test]
        public void TestExp()
        {
            double[] data = { 0.285, 0.342, 0.763, 0.492, 0.962, 0.876, 0.487, 0.605, 0.507, 0.187, 0.051, 0.266, 0.619, 0.748, 0.78, 0.706, 0.881, 0.772, 0.022, 0.057 };
            NumpyArray<double> array = NumpyArrayFactory.From(data);

            NumpyArray<double> actual = Numpy.Exp(array);
            double[] expected = { 1.32976203, 1.4077603, 2.14470068, 1.63558412, 2.61692509, 2.40127537, 1.62742661, 1.83125221, 1.66030281, 1.20562729, 1.05232289, 1.30473506, 1.85707004, 2.11277025, 2.18147227, 2.02587154, 2.41331181, 2.16409011, 1.02224378, 1.05865581 };
            TestHelper.AssertEqualData(actual, expected);
        }

        [Test]
        public void TestLog()
        {
            double[] data = { 0.754, 0.635, 0.754, 0.453, 0.441 };
            NumpyArray<double> array = NumpyArrayFactory.From(data);

            NumpyArray<double> actual = Numpy.Log(array);
            double[] expected = { -0.28236291, -0.45413028, -0.28236291, -0.79186315, -0.8187104 };
            TestHelper.AssertEqualData(actual, expected);
        }

        [Test]
        public void TestAtLeast2D()
        {
            double vd = 10;
            double[][] vda = { new[] { vd } };
            TestHelper.AssertEqualData(Numpy.AtLeast2D(vd), vda);

            float vf = 10;
            float[][] vfa = { new[] { vf } };
            TestHelper.AssertEqualData(Numpy.AtLeast2D(vf), vfa);

            long vl = 10;
            long[][] vla = { new[] { vl } };
            TestHelper.AssertEqualData(Numpy.AtLeast2D(vl), vla);

            int vi = 10;
            int[][] via = { new[] { vi } };
            TestHelper.AssertEqualData(Numpy.AtLeast2D(vi), via);

            short vs = 10;
            short[][] vsa = { new[] { vs } };
            TestHelper.AssertEqualData(Numpy.AtLeast2D(vs), vsa);

            byte vb = 10;
            byte[][] vba = { new[] { vb } };
            TestHelper.AssertEqualData(Numpy.AtLeast2D(vb), vba);

            double[] array = { 0, 1, 2, 3, 4, 5, 6 };
            NumpyArray<double> numpyArray = NumpyArrayFactory.From(array);

            TestHelper.AssertEqualData(Numpy.AtLeast2D(numpyArray), new[] { array });
        }
    }
}