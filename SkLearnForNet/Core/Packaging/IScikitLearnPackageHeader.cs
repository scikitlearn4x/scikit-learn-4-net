using System;

namespace SkLearn.Core.Packaging
{
    /// <summary>
    /// Abstracts the version of the binary package from its physical layout and its version.
    /// </summary>
    public interface IScikitLearnPackageHeader
    {
        /// <summary>
        /// Gets the version of the binary package file.
        /// </summary>
        int FileFormatVersion
        {
            get;
        }

        /// <summary>
        /// Gets the version that was used to train the scikit-learn object.
        /// </summary>
        String ScikitLearnVersion
        {
            get;
        }
    }
}