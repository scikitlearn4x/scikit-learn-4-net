using System;
using System.Collections.Generic;

namespace SkLearn.Core.Packaging
{
    /// <summary>
    /// This interface provides an abstraction over the physical file format to decouple the deserialization
    /// logic from the file format. This will ease the modifications to the file format and versioning for
    /// backward compatibility.
    /// </summary>
    public interface IScikitLearnPackage
    {
        /// <summary>
        /// Gets the object that stores the information provided in the binary package file header. The header
        /// include at the minimum the version of the file and the version of scikit-learn used to train the
        /// content of the file.
        /// </summary>
        IScikitLearnPackageHeader PackageHeader { get; }

        /// <summary>
        /// Gets a Map[String -> Object] of the extra values stored by the developer when saving the binary package.
        /// </summary>
        Dictionary<String, Object> ExtraValues { get; }

        /// <summary>
        /// Get the primary content stored in binary package file.
        /// <param name="name">Name of the content to retrieve.</param>
        /// <returns>A scikit-learn object that can now be used in Java.</returns>
        /// </summary>
        Object GetModel(String name);

        /// <summary>
        /// Loads the binary package from a file.
        /// <param name="path">Path of file to be loaded.
        /// </param>
        /// </summary>
        void LoadFromFile(String path);
    }
}