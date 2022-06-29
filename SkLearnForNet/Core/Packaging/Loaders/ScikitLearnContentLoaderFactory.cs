using System;
using System.Collections.Generic;
using SkLearn.Core.Packaging.Loaders.Classifiers.NaiveBayes;
using SkLearn.Core.Packaging.Loaders.Preprocessing.Data;
using SkLearn.Core.Packaging.Loaders.Preprocessing.Label;

namespace SkLearn.Core.Packaging.Loaders
{
    /// <summary>
    /// A factory class that instantiate a loader of type IScikitLearnContentLoader for a given
    /// serializer name.
    /// </summary>
    public class ScikitLearnContentLoaderFactory
    {
        /// <summary>
        /// A map of registered loaders.
        /// </summary>
        private static Dictionary<String, IScikitLearnContentLoader> registeredLoaders = null;

        /// <summary>
        /// Static initialization of the class and registering the available loaders.
        /// </summary>
        static ScikitLearnContentLoaderFactory()
        {
            registeredLoaders = new Dictionary<String, IScikitLearnContentLoader>();

            RegisterNaiveBayesLoaders();
            RegisterLabelPreprocessingLoaders();
            RegisterDataPreprocessingLoaders();
        }

        /// <summary>
        /// Registers the content loaders for data preprocessing.
        /// </summary>
        private static void RegisterDataPreprocessingLoaders()
        {
            RegisterLoader(new MinimumMaximumScalerContentLoader());
            RegisterLoader(new StandardScalerContentLoader());
            RegisterLoader(new MaximumAbsoluteScalerContentLoader());
            RegisterLoader(new RobustScalerContentLoader());
            RegisterLoader(new NormalizerContentLoader());
            RegisterLoader(new BinarizerContentLoader());

//        RegisterLoader(new QuantileTransformerContentLoader());
        }

        /// <summary>
        /// Registers the content loaders for label preprocessing.
        /// </summary>
        private static void RegisterLabelPreprocessingLoaders()
        {
            RegisterLoader(new LabelEncoderContentLoader());
            RegisterLoader(new LabelBinarizerContentLoader());
            RegisterLoader(new MultiLabelBinarizerContentLoader());
        }

        /// <summary>
        /// Registers the classes coming from the naive_bayes file in sklearn repository.
        /// </summary>
        private static void RegisterNaiveBayesLoaders()
        {
            RegisterLoader(new GaussianNaiveBayesContentLoader());
            RegisterLoader(new BernoulliNaiveBayesContentLoader());
            RegisterLoader(new CategoricalNaiveBayesContentLoader());
            RegisterLoader(new ComplementNaiveBayesContentLoader());
            RegisterLoader(new MultinomialNaiveBayesContentLoader());
        }

        /// <summary>
        /// Registers a new loader in the static map.
        /// <param name="loader">Instance of the loader to be registered.
        /// </param>
        /// </summary>
        private static void RegisterLoader(IScikitLearnContentLoader loader)
        {
            registeredLoaders.Add(loader.TypeName, loader);
        }

        /// <summary>
        /// Returns a loader based on its name for deserialization of contents.
        /// <param name="type">Name/ID of the loader.
        /// </param>
        /// <returns>An IScikitLearnContentLoader associated with the requested loader name.</returns>
        /// </summary>
        public static IScikitLearnContentLoader LoaderForType(String type)
        {
            if (registeredLoaders.ContainsKey(type))
            {
                return registeredLoaders[type];
            }

            throw new ScikitLearnCoreException($"The loader type '{type}' is not supported.");
        }
    }
}