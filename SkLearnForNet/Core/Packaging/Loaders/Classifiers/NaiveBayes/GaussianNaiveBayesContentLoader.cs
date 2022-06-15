using System;
using SkLearn.Core.Libraries.Numpy;
using SkLearn.NaiveBayes;

namespace SkLearn.Core.Packaging.Loaders.Classifiers.NaiveBayes
{
    /// <summary>
    /// GaussianNaiveBayes object loader.
    /// </summary>
    public class GaussianNaiveBayesContentLoader : BaseScikitLearnContentLoader<GaussianNaiveBayes>
    {
        /// <summary>
        /// Instantiate a new object of GaussianNaiveBayesContentLoader.
        /// </summary>
        public GaussianNaiveBayesContentLoader() : base("nb_gaussian_serializer")
        {
        }

        /// <summary>
        /// Instantiate an unloaded GaussianNaiveBayes classifier.
        /// <returns>The unloaded classifier.</returns>
        /// </summary>
        protected override GaussianNaiveBayes CreateResultObject()
        {
            return new GaussianNaiveBayes();
        }

        /// <summary>
        /// Create a clean instance of the loader.
        /// <returns>A clean instance of the loader.</returns>
        /// </summary>
        public override IScikitLearnContentLoader Duplicate()
        {
            return new GaussianNaiveBayesContentLoader();
        }

        /// <summary>
        /// Defines the fields that are required to initialize a trained classifier.
        /// </summary>
        protected override void RegisterSetters()
        {
            try
            {
                RegisterNumpyArrayField("class_count_", SetClassCount);
                RegisterNumpyArrayField("classes_", SetClasses);
                RegisterNumpyArrayField("class_prior_", SetClassPriors);
                RegisterNumpyArrayField("theta_", SetMeanValues);
                RegisterNumpyArrayField("var_", SetVarianceValues);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sets the variance of each feature per class.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The variance of each feature per class.
        /// </param>
        /// </summary>
        private void SetVarianceValues(GaussianNaiveBayes result, Object value)
        {
            result.Sigma = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the mean of each feature per class.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The mean of each feature per class.
        /// </param>
        /// </summary>
        private void SetMeanValues(GaussianNaiveBayes result, Object value)
        {
            result.Theta = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the probability of each class.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The probability of each class.
        /// </param>
        /// </summary>
        private void SetClassPriors(GaussianNaiveBayes result, Object value)
        {
            result.ClassPriors = (NumpyArray<double>)value;
        }

        /// <summary>
        /// Sets the class labels known to the classifier.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The class labels known to the classifier.
        /// </param>
        /// </summary>
        private void SetClasses(GaussianNaiveBayes result, Object value)
        {
            result.Classes = (NumpyArray<long>)value;
        }

        /// <summary>
        /// Sets the number of training samples observed in each class.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The number of training samples observed in each class.
        /// </param>
        /// </summary>
        private void SetClassCount(GaussianNaiveBayes result, Object value)
        {
            result.ClassCounts = (NumpyArray<double>)value;
        }
    }
}