// ==================================================================
// Inference for MaxAbsScaler
// 
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.MaxAbsScaler.html#sklearn.preprocessing.MaxAbsScaler
// ==================================================================

using SkLearn.Base;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Preprocessing.Data
{
    /// <summary>
    /// Scale each feature by its maximum absolute value.
    /// This estimator scales and translates each feature individually such
    /// that the maximal absolute value of each feature in the training set
    /// will be 1.0. It does not shift/center the data, and thus does not
    /// destroy any sparsity.
    /// This scaler can also be applied to sparse CSR or CSC matrices.
    /// </summary>
    public class MaximumAbsoluteScaler: TransformerMixin<NumpyArray<double>, NumpyArray<double>>
    {
        /// <summary>
        /// Instantiate a new object of MaximumAbsoluteScaler.
        /// </summary>
        public MaximumAbsoluteScaler()
        {
        }

        /// <summary>
        /// Per feature relative scaling of the data.
        /// </summary>
        public NumpyArray<double> Scale 
        {
            get;
            internal set;
        }

        /// <summary>
        /// Per feature maximum absolute value.
        /// </summary>
        public NumpyArray<double> MaxAbsolute 
        {
            get;
            internal set;
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
        /// The number of samples processed by the estimator. Will be reset on new
        /// calls to fit, but increments across `partial_fit` calls.
        /// </summary>
        public long NumberOfSamplesSeen 
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
            return Numpy.Divide(array, Scale);
        }

        /// <summary>
        /// Takes a transformed array and reveres the transformation.
        /// <param name="array">The array to apply reveres transform.</param>
        /// <returns>The inversed transform of array.</returns>
        /// </summary>
        public override NumpyArray<double> InverseTransform(NumpyArray<double> array)
        {
            return Numpy.Multiply(array, Scale);
        }
    }
}