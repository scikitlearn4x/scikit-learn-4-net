using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Utils
{
    /// <summary>
    /// Utils method that scikit-learn provide to preprocess the data.
    /// </summary>
    public class Preprocessing
    {
        /// <summary>
        /// Binarize a numpy array based on a given threshold.
        /// <param name="x">Array to be binarized.</param>
        /// <param name="threshold">The threshold for binarization. If the value in x is greater than threshold,
        /// the target element is 1.0 otherwise is 0.0.
        /// </param>
        /// <returns>The binarized numpy array.</returns>
        /// </summary>
        public static NumpyArray<double> BinarizeInput(NumpyArray<double> x, double threshold)
        {
            NumpyArray<double> result = NumpyArrayFactory.ArrayOfDoubleWithShape(x.Shape);

            x.ApplyToEachElementAnsSaveToTarget(result, value =>
            {
                if (value > threshold)
                {
                    return 1.0;
                }

                return 0.0;
            });

            return result;
        }
    }
}