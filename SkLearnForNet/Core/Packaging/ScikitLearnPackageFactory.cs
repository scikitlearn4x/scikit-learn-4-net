using System;
using System.IO;
using SkLearn.Core.Packaging.Version1;

namespace SkLearn.Core.Packaging
{
    /// <summary>
    /// ScikitLearnPackageFactory is a factory that takes in the physical file (or stream) of a binary package
    /// and parse it into a ready to use object. It also supports handling different versions of the binary
    /// files.
    /// </summary>
    public class ScikitLearnPackageFactory
    {
        /// <summary>
        /// Load a binary package file into a ready to use object. It reads the version of the file and
        /// load the appropriate loader to deserialize the file.
        /// <param name="path">Path of the file to be loaded.
        /// </param>
        /// <returns>An IScikitLearnPackage object that represent the models stored in the binary package file.</returns>
        /// </summary>
        public static IScikitLearnPackage LoadFromFile(String path)
        {
            int version = ReadFileVersion(path);
            IScikitLearnPackage pkg = null;

            if (version == 1)
            {
                pkg = new ScikitLearnPackageV1();
                pkg.LoadFromFile(path);
            }
            else
            {
                throw new Exception("This version of the file format is not supported.");
            }

            return pkg;
        }

        /// <summary>
        /// Reads the version of the binary package from a file.
        /// <param name="path">Path of the file to be loaded.
        /// </param>
        /// <returns>An integer representing the file format version.</returns>
        /// </summary>
        private static int ReadFileVersion(String path)
        {
            int result = 0;
            
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                BinaryModelPackage buffer = BinaryModelPackage.FromStream(stream);
                result = buffer.ReadInteger();
            }

            return result;
        }
    }
}