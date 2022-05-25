using System;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Core.Libraries
{
    public class Scipy
    {
        public static NumpyArray<double> LogSumExponent(NumpyArray<double> data, int axis) {
            // https://docs.scipy.org/doc/scipy/reference/generated/scipy.special.logsumexp.html
            // Calculates np.log(np.sum(np.exp(a)))
            return Numpy.Numpy.Log(Numpy.Numpy.Sum(Numpy.Numpy.Exp(data), axis));
        }
    }
}