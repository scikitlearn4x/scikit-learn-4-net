using SkLearn.Base;
using SkLearn.Core;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Preprocessing.Data
{
    /// <summary>
    /// Binarize data (set feature values to 0 or 1) according to a
    /// threshold.
    /// Values greater than the threshold map to 1, while values less than or
    /// equal to the threshold map to 0. With the default threshold of 0, only
    /// positive values map to 1.
    /// Binarization is a common operation on text count data where the
    /// analyst can decide to only consider the presence or absence of a
    /// feature rather than a quantified number of occurrences for instance.
    /// It can also be used as a pre-processing step for estimators that
    /// consider boolean random variables (e.g. modelled using the Bernoulli
    /// distribution in a Bayesian setting).
    /// </summary>
    public class Binarizer : TransformerMixin<NumpyArray<double>, NumpyArray<double>>
    {
        /// <summary>
        /// Instantiate a new object of Binarizer.
        /// </summary>
        public Binarizer()
        {
        }

        /// <summary>
        /// Number of features seen during `fit`.
        /// </summary>
        public long NumberOfFeatures
        {
            get;
            internal set;
        }

        /// <summary>
        /// Names of features seen during `fit`. Defined only when `X` has feature
        /// names that are all strings.
        /// </summary>
        public String[] FeatureNames
        {
            get;
            internal set;
        }

        /// <summary>
        /// Feature values below or equal to this are replaced by 0, above it by 1. Threshold
        /// may not be less than 0 for operations on sparse matrices.
        /// </summary>
        public double Threshold 
        {
            get;
            internal set;
        }

        /// <summary>
        /// Takes the input array and transforms it.
        /// <param name="array">The array to transform.</param>
        /// <returns>The transformed array.</returns>
        /// </summary>
        public override NumpyArray<double> Transform(NumpyArray<double> array)
        {
            NumpyArray<double> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<double>(array.IsFloatingPoint, array.NumberOfBytes, array.Shape);

            array.ApplyToEachElementAnsSaveToTarget(result, value =>
            {
                if (value > Threshold)
                {
                    return 1.0;
                }

                return 0.0;
            });

            return result;
        }

        /// <summary>
        /// Takes a transformed array and reveres the transformation.
        /// <param name="array">The array to apply reveres transform.</param>
        /// <returns>The inversed transform of array.</returns>
        /// </summary>
        public override NumpyArray<double> InverseTransform(NumpyArray<double> array)
        {
            throw new ScikitLearnCoreException("The inverse transform is not available for the Binarizer preprocessing.");
        }
    }
}