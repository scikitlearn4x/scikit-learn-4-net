using System;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Core.Libraries
{
    /// <summary>
    /// Function of the scipy library that was used in scikit-learn.
    /// </summary>
    public class Scipy
    {
        /// <summary>
        /// Compute the log of the sum of exponentials of input elements.
        /// See https://docs.scipy.org/doc/scipy/reference/generated/scipy.special.logsumexp.html
        /// <param name="data">Input array to apply the calculations on.</param>
        /// <param name="axis">The axis used by sum for reduction.</param>
        /// <returns>The result, np.log(np.sum(np.exp(a))) calculated in a numerically more stable way.</returns>
        /// </summary>
        public static NumpyArray<double> LogSumExponent(NumpyArray<double> data, int axis)
        {
            // https://docs.scipy.org/doc/scipy/reference/generated/scipy.special.logsumexp.html
            // Calculates np.log(np.sum(np.exp(a)))
            return Numpy.Numpy.Log(Numpy.Numpy.Sum(Numpy.Numpy.Exp(data), axis));
        }
    }
}