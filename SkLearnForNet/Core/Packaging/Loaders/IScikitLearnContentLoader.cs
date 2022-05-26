using System;

namespace SkLearn.Core.Packaging.Loaders
{
    /// <summary>
    /// IScikitLearnContentLoader abstracts the format of individual objects from the file formatting. A class
    /// should be derived from this interface for each classifier in scikit-learn.
    /// </summary>
    public interface IScikitLearnContentLoader
    {
        /// <summary>
        /// Name of the loader. The name is stored in the header of the binary package file to be used during
        /// deserialization.
        /// </summary>
        String TypeName { get; }

        /// <summary>
        /// Loads a scikit-learn object from an input stream.
        /// <param name="buffer">The buffer to load the object from.
        /// </param>
        /// <returns>A deserialized ready to use object.</returns>
        /// </summary>
        Object LoadContent(BinaryModelPackage buffer);

        /// <summary>
        /// Creates a clone of the instance.
        /// <returns>An empty clean instance of the loader.</returns>
        /// </summary>
        IScikitLearnContentLoader Duplicate();
    }
}