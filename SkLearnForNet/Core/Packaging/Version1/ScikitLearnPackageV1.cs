using System;
using System.Collections.Generic;
using SkLearn.Core.Packaging.Loaders;

namespace SkLearn.Core.Packaging.Version1
{
    /// <summary>
    /// A data class that contains the values stored in the binary package files. This is the default
    /// implementation for version 1 of the binary file formats.
    /// </summary>
    public class ScikitLearnPackageV1 : IScikitLearnPackage
    {
        /// <summary>
        /// The object storing information in the file header.
        /// </summary>
        private ScikitLearnPackageHeaderV1 header = null;

        /// <summary>
        /// List of the scikit-learn objects of the binary package file.
        /// </summary>
        private List<Object> primaryContent = null;

        /// <summary>
        /// Extra information that the developer added to the package file.
        /// </summary>
        private Dictionary<String, Object> extras = null;

        /// <summary>
        /// Gets the object that stores the information provided in the binary package file header. The header
        /// include at the minimum the version of the file and the version of scikit-learn used to train the
        /// content of the file.
        /// </summary>
        public IScikitLearnPackageHeader PackageHeader
        {
            get { return header; }
        }

        /// <summary>
        /// Gets a Dictionary[String -> Object] of the extra values stored by the developer when saving the binary package.
        /// </summary>
        public Dictionary<String, Object> ExtraValues
        {
            get { return extras; }
        }

        /// <summary>
        /// Get the primary content stored in binary package file.
        /// <param name="index">Index of the content to retrieve.
        /// </param>
        /// <returns>A scikit-learn object that can now be used in Java.</returns>
        /// </summary>
        public Object GetModel(int index)
        {
            return primaryContent[index];
        }

        /// <summary>
        /// Loads the binary package from a file.
        /// <param name="path">Path of file to be loaded.
        /// </param>
        /// </summary>
        public void LoadFromFile(String path)
        {
            BinaryModelPackage buffer = BinaryModelPackage.FromFile(path);

            LoadFileHeader(buffer);
            LoadFilePrimaryContent(buffer);
            LoadFileExtraContent(buffer);
        }

        /// <summary>
        /// Loads the extra information that the developer added to the package file.
        /// <param name="buffer">The wrapper over the input file/stream.
        /// </param>
        /// </summary>
        private void LoadFileExtraContent(BinaryModelPackage buffer)
        {
            if (buffer.CanRead())
            {
                extras = buffer.ReadDictionary();
            }
            else
            {
                extras = new Dictionary<String, Object>();
            }
        }

        /// <summary>
        /// Loads the primary content stored in binary package file.
        /// <param name="buffer">The wrapper over the input file/stream.
        /// </param>
        /// </summary>
        private void LoadFilePrimaryContent(BinaryModelPackage buffer)
        {
            primaryContent = new List<Object>();
            foreach (String serializerType in header.SerializerTypes)
            {
                IScikitLearnContentLoader loader = ScikitLearnContentLoaderFactory.LoaderForType(serializerType);
                primaryContent.Add(loader.LoadContent(buffer));
            }
        }

        /// <summary>
        /// Loads the header into an ScikitLearnPackageHeaderV1 object.
        /// <param name="buffer">The wrapper over the input file/stream.
        /// </param>
        /// </summary>
        private void LoadFileHeader(BinaryModelPackage buffer)
        {
            header = new ScikitLearnPackageHeaderV1();
            header.FileFormatVersion = buffer.ReadInteger();
            Dictionary<String, Object> headerValues = buffer.ReadDictionary();
            header.Sklearn4xVersion = (String)headerValues["sklearn4x_version"];
            header.ScikitLearnVersion = (String)headerValues["scikit_learn_version"];
            header.NumpyVersion = (String)headerValues["numpy_version"];
            header.ScipyVersion = (String)headerValues["scipy_version"];
            header.PythonInfo = (String)headerValues["python_info"];
            header.PlatformInfo = (String)headerValues["platform_info"];
            header.SerializerTypes = (String[])headerValues["serializer_types"];
        }
    }
}