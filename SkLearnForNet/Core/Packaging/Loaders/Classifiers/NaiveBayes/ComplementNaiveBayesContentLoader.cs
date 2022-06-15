using SkLearn.Core.Libraries.Numpy;
using SkLearn.NaiveBayes;

namespace SkLearn.Core.Packaging.Loaders.Classifiers.NaiveBayes
{
    /// <summary>
    /// ComplementNaiveBayes object loader.
    /// </summary>
    public class ComplementNaiveBayesContentLoader : BaseScikitLearnContentLoader<ComplementNaiveBayes>
    {
        /// <summary>
        /// Instantiate a new object of ComplementNaiveBayesContentLoader.
        /// </summary>
        public ComplementNaiveBayesContentLoader() : base("nb_complement_serializer")
        {
        }

        /// <summary>
        /// Instantiate an unloaded ComplementNaiveBayes classifier.
        /// <returns>The unloaded classifier.</returns>
        /// </summary>
        protected override ComplementNaiveBayes CreateResultObject()
        {
            return new ComplementNaiveBayes();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new ComplementNaiveBayesContentLoader();
        }

        /// <summary>
        /// Defines the fields that are required to initialize a trained classifier.
        /// </summary>
        protected override void RegisterSetters()
        {
            RegisterNumpyArrayField("classes_", SetClasses);
            RegisterNumpyArrayField("class_count_", SetClassCount);
            RegisterNumpyArrayField("class_log_prior_", SetClassLogPriors);
            RegisterNumpyArrayField("feature_log_prob_", SetFeatureLogProbabilities);
            RegisterNumpyArrayField("feature_count_", SetFeatureCount);
            RegisterNumpyArrayField("feature_all_", SetFeatureAll);
        }

        /// <summary>
        /// Sets the feature_all_ field.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="numpyArray">The feature_all_ field.
        /// </param>
        /// </summary>
        private void SetFeatureAll(ComplementNaiveBayes result, Object numpyArray)
        {
        }

        /// <summary>
        /// Sets the feature's log probability in the training data.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="numpyArray">The feature's log probability in the training data.
        /// </param>
        /// </summary>
        private void SetFeatureLogProbabilities(ComplementNaiveBayes result, Object numpyArray)
        {
            result.FeatureLogProbabilities = (NumpyArray<double>)numpyArray;
        }

        /// <summary>
        /// Sets the frequency of the features in the training data.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="numpyArray">The frequency of the features in the training data.
        /// </param>
        /// </summary>
        private void SetFeatureCount(ComplementNaiveBayes result, Object numpyArray)
        {
            result.FeatureCounts = (NumpyArray<double>)numpyArray;
        }

        /// <summary>
        /// Sets the probability of each class.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The probability of each class.
        /// </param>
        /// </summary>
        private void SetClassLogPriors(ComplementNaiveBayes result, Object value)
        {
            result.ClassLogPrior = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the class labels known to the classifier.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The class labels known to the classifier.
        /// </param>
        /// </summary>
        private void SetClasses(ComplementNaiveBayes result, Object value)
        {
            result.Classes = (NumpyArray<long>)value;
        }

        /// <summary>
        /// Sets the number of training samples observed in each class.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The number of training samples observed in each class.
        /// </param>
        /// </summary>
        private void SetClassCount(ComplementNaiveBayes result, Object value)
        {
            result.ClassCounts = (NumpyArray<double>)value;
        }
    }
}