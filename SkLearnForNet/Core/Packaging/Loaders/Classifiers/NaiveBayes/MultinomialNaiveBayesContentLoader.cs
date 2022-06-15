using SkLearn.Core.Libraries.Numpy;
using SkLearn.NaiveBayes;

namespace SkLearn.Core.Packaging.Loaders.Classifiers.NaiveBayes
{
    /// <summary>
    /// MultinomialNaiveBayes object loader.
    /// </summary>
    public class MultinomialNaiveBayesContentLoader : BaseScikitLearnContentLoader<MultinomialNaiveBayes>
    {
        /// <summary>
        /// Instantiate a new object of MultinomialNaiveBayesContentLoader.
        /// </summary>
        public MultinomialNaiveBayesContentLoader() : base("nb_multinomial_serializer")
        {
            
        }

        /// <summary>
        /// Instantiate an unloaded MultinomialNaiveBayes classifier.
        /// <returns>The unloaded classifier.</returns>
        /// </summary>
        protected override MultinomialNaiveBayes CreateResultObject()
        {
            return new MultinomialNaiveBayes();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new MultinomialNaiveBayesContentLoader();
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
        }

        /// <summary>
        /// Sets the feature's log probability in the training data.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="numpyArray">The feature's log probability in the training data.
        /// </param>
        /// </summary>
        private void SetFeatureLogProbabilities(MultinomialNaiveBayes result, Object numpyArray)
        {
            result.FeatureLogProbabilities = (NumpyArray<double>)numpyArray;
        }

        /// <summary>
        /// Sets the frequency of the features in the training data.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="numpyArray">The frequency of the features in the training data.
        /// </param>
        /// </summary>
        private void SetFeatureCount(MultinomialNaiveBayes result, Object numpyArray)
        {
            result.FeatureCounts = (NumpyArray<double>)numpyArray;
        }

        /// <summary>
        /// Sets the probability of each class.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The probability of each class.
        /// </param>
        /// </summary>
        private void SetClassLogPriors(MultinomialNaiveBayes result, Object numpyArray)
        {
            result.ClassLogPrior = (NumpyArray<double>)numpyArray;
        }

        /// <summary>
        /// Sets the class labels known to the classifier.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The class labels known to the classifier.
        /// </param>
        /// </summary>
        private void SetClasses(MultinomialNaiveBayes result, Object numpyArray)
        {
            result.Classes = (NumpyArray<long>)numpyArray;
        }

        /// <summary>
        /// Sets the number of training samples observed in each class.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The number of training samples observed in each class.
        /// </param>
        /// </summary>
        private void SetClassCount(MultinomialNaiveBayes result, Object numpyArray)
        {
            result.ClassCounts = (NumpyArray<double>)numpyArray;
        }
    }
}