using System;

namespace SkLearn.Core.Packaging.Version1
{
    /// <summary>
    /// A data class that contains the values stored in the header of the binary package files. This is the
    /// default implementation for version 1 of the binary file formats.
    /// </summary>
    public class ScikitLearnPackageHeaderV1 : IScikitLearnPackageHeader
    {
        /// <summary>
        /// The version of the binary package file. This value is the first 4 bytes stored in the file.
        /// </summary>
        private int fileFormatVersion = 0;

        /// <summary>
        /// The version of the binary package file. This value is the first 4 bytes stored in the file.
        /// </summary>
        public int FileFormatVersion
        {
            get { return fileFormatVersion; }
            internal set { fileFormatVersion = value; }
        }

        /// <summary>
        /// The sklearn4x version. This is the library used to serialize the models into file. For more
        /// information, please see:
        /// https://pypi.org/project/sklearn4x/
        /// </summary>
        private String sklearn4xVersion = null;

        /// <summary>
        /// The sklearn4x version. This is the library used to serialize the models into file. For more
        /// information, please see:
        /// https://pypi.org/project/sklearn4x/
        /// </summary>
        public String Sklearn4xVersion
        {
            get { return sklearn4xVersion; }
            internal set { sklearn4xVersion = value; }
        }

        /// <summary>
        /// The version of the scikit-learn library used to train/prepare the objects contained in the
        /// current file.
        /// </summary>
        private String scikitLearnVersion = null;

        /// <summary>
        /// The version of the scikit-learn library used to train/prepare the objects contained in the
        /// current file.
        /// </summary>
        public String ScikitLearnVersion
        {
            get { return scikitLearnVersion; }
            internal set { scikitLearnVersion = value; }
        }

        /// <summary>
        /// The version of the numpy library used to train/prepare the objects contained in the
        /// current file.
        /// </summary>
        private String numpyVersion = null;

        /// <summary>
        /// The version of the numpy library used to train/prepare the objects contained in the
        /// current file.
        /// </summary>
        public String NumpyVersion
        {
            get { return numpyVersion; }
            internal set { numpyVersion = value; }
        }

        /// <summary>
        /// The version of the scipy library used to train/prepare the objects contained in the
        /// current file.
        /// </summary>
        private String scipyVersion = null;

        /// <summary>
        /// The version of the scipy library used to train/prepare the objects contained in the
        /// current file.
        /// </summary>
        public String ScipyVersion
        {
            get { return scipyVersion; }
            internal set { scipyVersion = value; }
        }

        /// <summary>
        /// Information about the python version installed that was used to create the binary package file.
        /// </summary>
        private String pythonInfo = null;

        /// <summary>
        /// Information about the python version installed that was used to create the binary package file.
        /// </summary>
        public String PythonInfo
        {
            get { return pythonInfo; }
            internal set { pythonInfo = value; }
        }

        /// <summary>
        /// Information about the platform that was used to create the binary package file.
        /// </summary>
        private String platformInfo = null;

        /// <summary>
        /// Information about the platform that was used to create the binary package file.
        /// </summary>
        public String PlatformInfo
        {
            get { return platformInfo; }
            internal set { platformInfo = value; }
        }

        /// <summary>
        /// List of the serializers used to serialize the primary contents of the binary package. These values
        /// are to be used for internal purposes only and should not be modified by the developers.
        /// </summary>
        private String[] serializerTypes = null;

        /// <summary>
        /// List of the serializers used to serialize the primary contents of the binary package. These values
        /// are to be used for internal purposes only and should not be modified by the developers.
        /// </summary>
        public String[] SerializerTypes
        {
            get { return serializerTypes; }
            internal set { serializerTypes = value; }
        }
    }
}