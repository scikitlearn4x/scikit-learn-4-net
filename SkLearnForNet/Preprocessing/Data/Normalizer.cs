// ==================================================================
// Inference for Normalizer
// 
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.Normalizer.html#sklearn.preprocessing.Normalizer
// ==================================================================

using SkLearn.Base;
using SkLearn.Core;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.Utils;

namespace SkLearn.Preprocessing.Data
{
    /// <summary>
    /// Normalize samples individually to unit norm.
    /// Each sample (i.e. each row of the data matrix) with at least one non
    /// zero component is rescaled independently of other samples so that its
    /// norm (l1, l2 or inf) equals one.
    /// This transformer is able to work both with dense numpy arrays and
    /// scipy.sparse matrix (use CSR format if you want to avoid the burden of
    /// a copy / conversion).
    /// Scaling inputs to unit norms is a common operation for text
    /// classification or clustering for instance. For instance the dot
    /// product of two l2-normalized TF-IDF vectors is the cosine similarity
    /// of the vectors and is the base similarity metric for the Vector Space
    /// Model commonly used by the Information Retrieval community.
    /// </summary>
    public class Normalizer : TransformerMixin<NumpyArray<double>, NumpyArray<double>>
    {
        /// <summary>
        /// Instantiate a new object of Normalizer.
        /// </summary>
        public Normalizer()
        {
        }

        /// <summary>
        /// Number of features seen during `fit`.
        /// </summary>
        public long NumberOfFeatures { get; internal set; }

        /// <summary>
        /// Names of features seen during `fit`. Defined only when `X` has feature
        /// names that are all strings.
        /// </summary>
        public String[] FeatureNames { get; internal set; }

        /// <summary>
        /// The norm to use to normalize each non zero sample. If norm=’max’ is used, values will
        /// be rescaled by the maximum of the absolute values.
        /// </summary>
        public String Norm { get; internal set; }

        /// <summary>
        /// Takes the input array and transforms it.
        /// <param name="array">The array to transform.</param>
        /// <returns>The transformed array.</returns>
        /// </summary>
        public override NumpyArray<double> Transform(NumpyArray<double> array)
        {
//        if norm == "l1":
//            norms = np.Abs(X).Sum(axis=1)
//        elif norm == "l2":
//            norms = row_norms(X)
//        elif norm == "max":
//            norms = np.Max(abs(X), axis=1)
//        norms = _handle_zeros_in_scale(norms, copy=False)
//        X /= norms[:, np.Newaxis]
            NumpyArray<double> result = null;
            NumpyArray<double> norms = null;

            if (Norm == "l1")
            {
                norms = Numpy.Sum(Numpy.Abs(array), 1, false);
            }
            else if (Norm == "l2")
            {
                norms = ExtMath.RowNorm(array);
            }
            else if (Norm == "max")
            {
                norms = Numpy.ArrayMax(Numpy.Abs(array), 1, false);
            }

            HandleZerosInScale(norms);
            result = Numpy.Divide(array, AddTrailingOneDimension(norms));
            return result;
        }

        /// <summary>
        /// Adds a trailing dimension of 1 to the end of the shape. Effectively, transforms a (n,) array
        /// to (n, 1).
        /// <param name="array">The input array.</param>
        /// <returns>The array with an additional 1 dimension at the end of the shape.</returns>
        /// </summary>
        private NumpyArray<double> AddTrailingOneDimension(NumpyArray<double> array)
        {
            double[,] result = new double[array.Shape[0], 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i, 0] = array.Get(i);
            }

            return NumpyArrayFactory.From(result);
        }

        /// <summary>
        /// Set scales of near constant features to 1.
        /// <p>
        /// The goal is to avoid division by very small or zero values.
        /// <p>
        /// Near constant features are detected automatically by identifying scales close to machine
        /// precision unless they are precomputed by the caller and passed with the `constant_mask` kwarg.
        /// <p>
        /// Typically for standard scaling, the scales are the standard deviation while near constant
        /// features are better detected on the computed variances which are closer to machine precision
        /// by construction.
        /// <param name="array">The array to normalize the zeros.
        /// </param>
        /// </summary>
        private void HandleZerosInScale(NumpyArray<double> array)
        {
            double epsilon = 2.220446049250313e-16; // np.Finfo(np.Float64).Eps
            double threshold = 10 * epsilon;

            array.ApplyToEachElement(value =>
            {
                if (value < threshold)
                {
                    return 1.0;
                }

                return value;
            });
        }

        /// <summary>
        /// Takes a transformed array and reveres the transformation.
        /// <param name="array">The array to apply reveres transform.</param>
        /// <returns>The inversed transform of array.</returns>
        /// </summary>
        public override NumpyArray<double> InverseTransform(NumpyArray<double> array)
        {
            throw new ScikitLearnCoreException("The inverse transform is not available for the Normalizer preprocessing.");
        }
    }
}