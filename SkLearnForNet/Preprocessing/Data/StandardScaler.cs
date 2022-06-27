// ==================================================================
// Inference for StandardScaler
// 
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.StandardScaler.html#sklearn.preprocessing.StandardScaler
// ==================================================================

using SkLearn.Base;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Preprocessing.Data
{
    /// <summary>
    /// Standardize features by removing the mean and scaling to unit
    /// variance.
    /// The standard score of a sample `x` is calculated as:
    /// z = (x - u) / s
    /// where `u` is the mean of the training samples or zero if
    /// `with_mean=False`, and `s` is the standard deviation of the training
    /// samples or one if `with_std=False`.
    /// Centering and scaling happen independently on each feature by
    /// computing the relevant statistics on the samples in the training set.
    /// Mean and standard deviation are then stored to be used on later data
    /// using :meth:`transform`.
    /// Standardization of a dataset is a common requirement for many machine
    /// learning estimators: they might behave badly if the individual
    /// features do not more or less look like standard normally distributed
    /// data (e.g. Gaussian with 0 mean and unit variance).
    /// For instance many elements used in the objective function of a
    /// learning algorithm (such as the RBF kernel of Support Vector Machines
    /// or the L1 and L2 regularizers of linear models) assume that all
    /// features are centered around 0 and have variance in the same order. If
    /// a feature has a variance that is orders of magnitude larger than
    /// others, it might dominate the objective function and make the
    /// estimator unable to learn from other features correctly as expected.
    /// This scaler can also be applied to sparse CSR or CSC matrices by
    /// passing `with_mean=False` to avoid breaking the sparsity structure of
    /// the data.
    /// </summary>
    public class StandardScaler : TransformerMixin<NumpyArray<double>, NumpyArray<double>>
    {
        /// <summary>
        /// Instantiate a new object of StandardScaler.
        /// </summary>
        public StandardScaler()
        {
        }

        /// <summary>
        /// Per feature relative scaling of the data to achieve zero mean and unit
        /// variance. Generally this is calculated using `np.sqrt(var_)`. If a
        /// variance is zero, we can't achieve unit variance, and the data is left
        /// as-is, giving a scaling factor of 1. `scale_` is equal to `None` when
        /// `with_std=False`.
        /// </summary>
        public NumpyArray<double> Scale { get; internal set; }

        /// <summary>
        /// The mean value for each feature in the training set. Equal to `None`
        /// when `with_mean=False`.
        /// </summary>
        public NumpyArray<double> Mean { get; internal set; }

        /// <summary>
        /// The variance for each feature in the training set. Used to compute
        /// `scale_`. Equal to `None` when `with_std=False`.
        /// </summary>
        public NumpyArray<double> Variance { get; internal set; }

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
        /// The number of samples processed by the estimator for each feature. If
        /// there are no missing samples, the `n_samples_seen` will be an integer,
        /// otherwise it will be an array of dtype int. If `sample_weights` are
        /// used it will be a float (if no missing data) or an array of dtype
        /// float that sums the weights seen so far. Will be reset on new calls to
        /// fit, but increments across `partial_fit` calls.
        /// </summary>
        public NumpyArray<long> NumberOfSamplesSeen { get; internal set; }

        /// <summary>
        /// Internal field of scikit-learn object.
        /// </summary>
        public bool WithMean { get; internal set; }

        /// <summary>
        /// Internal field of scikit-learn object.
        /// </summary>
        public bool WithStandardDeviation { get; internal set; }
        
        /// <summary>
        /// Takes the input array and transforms it.
        /// <param name="array">The array to transform.</param>
        /// <returns>The transformed array.</returns>
        /// </summary>
        public override NumpyArray<double> Transform(NumpyArray<double> array)
        {
            NumpyArray<double> result = array;

            if (WithMean)
            {
                result = Numpy.Subtract<double, double, double>(result, Mean);
            }

            if (WithStandardDeviation)
            {
                result = Numpy.Divide(result, Scale);
            }

            return result;
        }

        /// <summary>
        /// Takes a transformed array and reveres the transformation.
        /// <param name="array">The array to apply reveres transform.</param>
        /// <returns>The inversed transform of array.</returns>
        /// </summary>
        public override NumpyArray<double> InverseTransform(NumpyArray<double> array)
        {
            NumpyArray<double> result = array;

            if (WithStandardDeviation)
            {
                result = Numpy.Multiply(result, Scale);
            }

            if (WithMean)
            {
                result = Numpy.Add<double, double, double>(result, Mean);
            }

            return result;
        }
    }
}