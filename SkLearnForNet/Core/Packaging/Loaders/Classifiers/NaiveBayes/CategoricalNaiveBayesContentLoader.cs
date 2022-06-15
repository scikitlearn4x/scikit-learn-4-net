using SkLearn.Core.Libraries.Numpy;
using SkLearn.NaiveBayes;

namespace SkLearn.Core.Packaging.Loaders.Classifiers.NaiveBayes
{
    /// <summary>
    /// CategoricalNaiveBayes object loader.
    /// </summary>
    public class CategoricalNaiveBayesContentLoader : BaseScikitLearnContentLoader<CategoricalNaiveBayes>
    {
        /// <summary>
        /// Instantiate a new object of CategoricalNaiveBayesContentLoader.
        /// </summary>
        public CategoricalNaiveBayesContentLoader() : base("nb_categorical_serializer")
        {
            
        }

        /// <summary>
        /// Instantiate an unloaded CategoricalNaiveBayes classifier.
        /// <returns>The unloaded classifier.</returns>
        /// </summary>
        protected override CategoricalNaiveBayes CreateResultObject()
        {
            return new CategoricalNaiveBayes();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new CategoricalNaiveBayesContentLoader();
        }

        /// <summary>
        /// Defines the fields that are required to initialize a trained classifier.
        /// </summary>
        protected override void RegisterSetters()
        {
            RegisterNumpyArrayField("classes_", SetClasses);
            RegisterNumpyArrayField("class_count_", SetClassCount);
            RegisterNumpyArrayField("class_log_prior_", SetClassLogPriors);
            RegisterListOfNumpyArrayField("feature_log_prob_", SetFeatureLogProbabilities);
            RegisterListOfNumpyArrayField("category_count_", SetCategoryCounts);
            RegisterNumpyArrayField("n_categories_", SetNumberInCategories);
        }

        /// <summary>
        /// Sets the field n_categories_ in the classifier.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="numpyArray">The n in each category.
        /// </param>
        /// </summary>
        private void SetNumberInCategories(CategoricalNaiveBayes result, Object numpyArray)
        {
        }

        /// <summary>
        /// Sets the category_count_ in the classifier.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="numpyArrays">The categories count in the training data.
        /// </param>
        /// </summary>
        private void SetCategoryCounts(CategoricalNaiveBayes result, List<Object> numpyArrays)
        {
        }

        /// <summary>
        /// Sets the feature's log probability in the training data.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="numpyArray">The feature's log probability in the training data.
        /// </param>
        /// </summary>
        private void SetFeatureLogProbabilities(CategoricalNaiveBayes result, List<Object> numpyArray)
        {
            result.FeatureLogProbabilities = AsListOfDoubleNumpyArray(numpyArray);
        }
        
        /// <summary>
        /// Sets the probability of each class.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The probability of each class.
        /// </param>
        /// </summary>
        private void SetClassLogPriors(CategoricalNaiveBayes result, Object value)
        {
            result.ClassLogPrior = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the class labels known to the classifier.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The class labels known to the classifier.
        /// </param>
        /// </summary>
        private void SetClasses(CategoricalNaiveBayes result, Object value)
        {
            result.Classes = (NumpyArray<long>)value;
        }

        /// <summary>
        /// Sets the number of training samples observed in each class.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The number of training samples observed in each class.
        /// </param>
        /// </summary>
        private void SetClassCount(CategoricalNaiveBayes result, Object value)
        {
            result.ClassCounts = (NumpyArray<double>)value;
        }
    }
}