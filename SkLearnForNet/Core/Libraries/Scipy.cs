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
            // return Numpy.Numpy.Log(Numpy.Numpy.Sum(Numpy.Numpy.Exp(data), axis));
            
            NumpyArray<double> aMax = Numpy.Numpy.ArrayMax(data, axis, true);
            aMax.ApplyToEachElement(value => {
                if (!double.IsFinite(value)) {
                    return 0.0;
                } else {
                    return value;
                }
            });

            NumpyArray<double> tmp = Numpy.Numpy.Exp(Numpy.Numpy.Subtract<double, double, double>(data, aMax));
            tmp = Numpy.Numpy.Sum(tmp, axis, false);
            tmp = Numpy.Numpy.Log(tmp);
            tmp = Numpy.Numpy.Add<double, double, double>(tmp, Numpy.Numpy.Squeeze(aMax));

            return tmp;
        }
        
        /// <summary>
        /// Reshapes the array for supporting arithmetic.
        /// <param name="np">Numpy array to be changed.</param>
        /// <returns>The changed NumpyArray.</returns>
        /// </summary>
        private static NumpyArray<double> To2DArrayShape(NumpyArray<double> np) {
            double[] values = (double[]) np.GetWrapper().RawArray;
            double[,] result = new double[values.Length, 1];

            for (int i = 0; i < result.Length; i++) {
                result[i,0] = values[i];
            }

            return NumpyArrayFactory.From(result);
//        int[] targetShape = new int[np.getShape().length + 1];
//        for (int i = 0; i < targetShape.length - 1; i++) {
//            targetShape[i] = np.getShape()[i];
//        }
//        targetShape[targetShape.length - 1] = 1;
//
//        NumpyArray<double> result = NumpyArrayFactory.arrayOfDoubleWithShape(targetShape);
//
//        int[] counter = new int[targetShape.length+1];
//        counter[0] = -1;
//
//        do {
//            NumpyArray.addCounter(counter, targetShape);
//            int[] indexOnOutput = new int[targetShape.length];
//            int[] indexOnInput = new int[targetShape.length - 1];
//            for (int i = 0; i < indexOnOutput.length - 1; i++) {
//                indexOnOutput[i] = counter[i];
//                indexOnInput[i] = counter[i];
//            }
//
//            result.set(np.get(indexOnInput), indexOnOutput);
//        } while (counter[counter.length - 1] == 0);
//
//        return result;
        }
    }
}