using SkLearn.Core;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Utils
{
    /// <summary>
    /// Helper class that implements scikit-learn functionalities in utils/extmath.py.
    /// </summary>
    public class ExtMath
    {
        /// <summary>
        /// Dot product of the NumpyArray.
        /// <param name="v1">Left-hand side of the expression.</param>
        /// <param name="v2">Right-hand side of the expression.</param>
        /// <returns>The dot product of the two numpy array.</returns>
        /// </summary>
        public static NumpyArray<double> Dot(NumpyArray<double> v1, NumpyArray<double> v2)
        {
            if (v1.NumberOfDimensions == v2.NumberOfDimensions && v1.NumberOfDimensions == 2)
            {
                // Just do a regular matrix multiplication
                double[,] result = new double[v1.Shape[0], v2.Shape[1]];

                for (int i = 0; i < v1.Shape[0]; i++)
                {
                    for (int j = 0; j < v2.Shape[1]; j++)
                    {
                        for (int k = 0; k < v1.Shape[1]; k++)
                        {
                            result[i, j] += v1.Get(i, k) * v2.Get(k, j);
                        }
                    }
                }

                return NumpyArrayFactory.From(result);
            }

            throw new ScikitLearnFeatureNotImplementedException();
        }
    }
}