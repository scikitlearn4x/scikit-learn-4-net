using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Core.Packaging
{
    /// <summary>
    /// A delegate to wrap the read functions in BinaryModelPackage.
    /// </summary>
    delegate Object BinaryModelPackagePrimitiveValueReader();

    /// <summary>
    /// A enum holding the different types of element that are stored in a binary package.
    /// </summary>
    enum BinaryModelPackageElementType : int
    {
        Byte = 0x01,
        Short = 0x02,
        Integer = 0x04,
        LongInteger = 0x08,
        UnsignedByte = 0x11,
        UnsignedShort = 0x12,
        UnsignedInteger = 0x14,
        UnsignedLongInteger = 0x18,
        Float = 0x20,
        Double = 0x21,
        String = 0x30,
        List = 0x40,
        Dictionary = 0x41,
        NumpyArray = 0x42,
        StringArray = 0x43,
        Null = 0x10,
    }

    /// <summary>
    /// The python package (sklearn4x) implements a class named BinaryBuffer that saves the python objects
    /// in a binary format. BinaryModelPackage is its counterpart to load these files (or stream) in other
    /// languages.
    /// </summary>
    public class BinaryModelPackage
    {
        private Stream stream;

        private BinaryModelPackage(Stream stream)
        {
            this.stream = stream;
        }

        /// <summary>
        /// Creates a new BinaryModelPackage that reads from  a given file.
        /// <param name="path">Path to the file to be read.</param>
        /// <returns>A BinaryModelPackage instance to read the package file.</returns>
        /// </summary>
        public static BinaryModelPackage FromFile(String path)
        {
            BinaryModelPackage result = null;
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                byte[] content = new byte[stream.Length];
                stream.Read(content, 0, content.Length);

                MemoryStream ms = new MemoryStream(content);
                result = FromStream(ms);
            }

            return result;
        }

        /// <summary>
        /// Creates a new BinaryModelPackage that reads from a given stream. This method is useful to load the files
        /// from a custom-made package or an encrypted one.
        /// <param name="stream">The input stream that should be loaded. It is recommended to use a buffered stream.</param>
        /// <returns>A BinaryModelPackage instance to read the package file.</returns>
        /// </summary>
        public static BinaryModelPackage FromStream(Stream stream)
        {
            return new BinaryModelPackage(stream);
        }

        /// <summary>
        /// Reads a byte from the stream.
        /// <returns>A byte value stored in the stream.</returns>
        /// </summary>
        public byte ReadByte()
        {
            int size = 1;

            byte[] data = ReadBuffer(size);
            return data[0];
        }

        /// <summary>
        /// Reads a 16-bits integer from the stream. The values are stored in little endian formats. 
        /// <returns>A short value stored in the stream.</returns>
        /// </summary>
        public short ReadShort()
        {
            int size = 2;
            int result = 0;

            byte[] data = ReadBuffer(size);

            for (int i = 0; i < size; i++)
            {
                result = result * 256;
                result = (data[size - 1 - i] & 0x000000FF) + result;
            }

            return (short)result;
        }

        /// <summary>
        /// Reads a 32-bits integer from the stream. The values are stored in little endian formats. 
        /// <returns>An integer value stored in the stream.</returns>
        /// </summary>
        public int ReadInteger()
        {
            int size = 4;
            int result = 0;

            byte[] data = ReadBuffer(size);

            for (int i = 0; i < size; i++)
            {
                result = result * 256;
                result = (data[size - 1 - i] & 0x000000FF) + result;
            }

            return result;
        }

        /// <summary>
        /// Reads a 64-bits integer from the stream. The values are stored in little endian formats. 
        /// <returns>An integer value stored in the stream.</returns>
        /// </summary>
        public long ReadLongInteger()
        {
            int size = 8;
            long result = 0;

            byte[] data = ReadBuffer(size);

            for (int i = 0; i < size; i++)
            {
                result = result * 256;
                result = (data[size - 1 - i] & 0x000000FF) + result;
            }

            return result;
        }


        /// <summary>
        /// Reads a 32-bits floating point value from the stream. The values are stored in IEE 754 and little endian formats.
        /// <returns>A float value stored in the stream.</returns>
        /// </summary>
        public float ReadFloat()
        {
            float result = float.NaN;
            int hasValue = ReadByte();

            if (hasValue == 1)
            {
                result = BitConverter.ToSingle(ReadBuffer(4), 0);
            }

            return result;
        }

        /// <summary>
        /// Reads a 64-bits floating point value from the stream. The values are stored in IEE 754 and little endian formats. 
        /// <returns>A double value stored in the stream.</returns>
        /// </summary>
        public double ReadDouble()
        {
            double result = double.NaN;
            int hasValue = ReadByte();

            if (hasValue == 1)
            {
                result = BitConverter.ToDouble(ReadBuffer(8), 0);
            }

            return result;
        }

        /// <summary>
        /// Reads a string with UTF-8 encoding from stream. 
        /// <returns>The string stored in the stream, or null if it has no value.</returns>
        /// </summary>
        public String ReadString()
        {
            String result = null;
            int hasValue = ReadByte();

            if (hasValue == 1)
            {
                int length = ReadInteger();
                byte[] data = ReadBuffer(length);

                result = Encoding.UTF8.GetString(data);
            }

            return result;
        }

        /// <summary>
        /// Read a multidimensional numpy array from the stream.
        /// <returns>The numpy array stored in the stream, or null if it has no value.</returns>
        /// </summary>
        public Object ReadNumpyArray()
        {
            INumpyArray result = null;
            int hasValue = ReadByte();

            if (hasValue == 1)
            {
                int[] shape = new int[ReadInteger()];
                BinaryModelPackageElementType elementType = (BinaryModelPackageElementType)ReadByte();

                for (int i = 0; i < shape.Length; i++)
                {
                    shape[i] = ReadInteger();
                }

                
                result = CreateNumpyArray(elementType, shape);
                int[] indices = new int[shape.Length];

                ReadNumpyDataFromStream(result.GetUnderlyingArray(), indices, 0, shape, elementType);
            }

            return result;
        }
        
        /// <summary>
        /// The element type of a numpy array is stored as a byte. The value of this byte is defined as
        /// the enum BinaryModelPackageElementType. This method converts these element type constants into
        /// respective C# types to create an array.
        /// <param name="elementType">A byte value read from buffer that specifies the type of numpy array.</param>
        /// <returns>A Class object used by reflection to create a new array.</returns>
        /// </summary>
        private INumpyArray CreateNumpyArray(BinaryModelPackageElementType elementType, int[] shape) {
            INumpyArray result = null;

            if (elementType == BinaryModelPackageElementType.Byte || elementType == BinaryModelPackageElementType.UnsignedByte) {
                result = NumpyArrayFactory.ArrayOfInt8WithShape(shape);
            } else if (elementType == BinaryModelPackageElementType.Short || elementType == BinaryModelPackageElementType.UnsignedShort) {
                result = NumpyArrayFactory.ArrayOfInt16WithShape(shape);
            } else if (elementType == BinaryModelPackageElementType.Integer || elementType == BinaryModelPackageElementType.UnsignedInteger) {
                result = NumpyArrayFactory.ArrayOfInt32WithShape(shape);
            } else if (elementType == BinaryModelPackageElementType.LongInteger || elementType == BinaryModelPackageElementType.UnsignedLongInteger) {
                result = NumpyArrayFactory.ArrayOfInt64WithShape(shape);
            } else if (elementType == BinaryModelPackageElementType.Float) {
                result = NumpyArrayFactory.ArrayOfFloatWithShape(shape);
            } else if (elementType == BinaryModelPackageElementType.Double) {
                result = NumpyArrayFactory.ArrayOfDoubleWithShape(shape);
            } else {
                throw new Exception($"Numpy array with element type {(int)elementType} is not supported.");
            }

            return result;
        }

        /// <summary>
        /// Reads a list from the stream.
        /// <returns>The list stored in the stream, or null if it has no value.</returns>
        /// </summary>
        public List<Object> ReadList()
        {
            List<Object> result = null;
            int hasValue = ReadByte();

            if (hasValue == 1)
            {
                result = new List<Object>();

                int count = ReadInteger();
                for (int i = 0; i < count; i++)
                {
                    BinaryModelPackageElementType elementType = (BinaryModelPackageElementType)ReadByte();

                    if (elementType == BinaryModelPackageElementType.Null)
                    {
                        result.Add(null);
                    }
                    else
                    {
                        BinaryModelPackagePrimitiveValueReader reader = GetPrimitiveDataReader(elementType);
                        Object value = reader();
                        result.Add(value);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Reads a dictionary from the stream.
        /// <returns>The dictionary stored in the stream, or null if it has no value.</returns>
        /// </summary>
        public Dictionary<String, Object> ReadDictionary()
        {
            Dictionary<String, Object> result = null;
            int hasValue = ReadByte();

            if (hasValue == 1)
            {
                result = new Dictionary<String, Object>();
                int count = ReadInteger();

                for (int i = 0; i < count; i++)
                {
                    String key = ReadString();
                    BinaryModelPackageElementType elementType = (BinaryModelPackageElementType)ReadByte();
                    if (elementType == BinaryModelPackageElementType.Null)
                    {
                        result.Add(key, null);
                    }
                    else
                    {
                        BinaryModelPackagePrimitiveValueReader reader = GetPrimitiveDataReader(elementType);
                        Object value = reader();
                        result.Add(key, value);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Recursively read the stream to load an encoded numpy array from the stream.
        /// </summary>
        /// <param name="result">The array to be loaded.</param>
        /// <param name="indices">The current subarray index being loaded in the recursion stack.</param>
        /// <param name="dimension">The current dimension being loaded in the recursion stack.</param>
        /// <param name="shape">The shape of the numpy array.</param>
        /// <param name="elementType">The type of the numpy array's elements.</param>
        private void ReadNumpyDataFromStream(Array result, int[] indices, int dimension, int[] shape, BinaryModelPackageElementType elementType)
        {
            if (dimension == shape.Length - 1)
            {
                // This is the last dimension of the tensor, read actual values.
                for (int i = 0; i < shape[dimension]; i++)
                {
                    indices[dimension] = i;
                    BinaryModelPackagePrimitiveValueReader reader = GetPrimitiveDataReader(elementType);
                    Object value = reader();
                    result.SetValue(value, indices);
                }
            }
            else
            {
                // This is an intermediate dimensions, it should read a tensor from the buffer
                for (int i = 0; i < shape[dimension]; i++)
                {
                    indices[dimension] = i;
                    ReadNumpyDataFromStream(result, indices, dimension + 1, shape, elementType);
                }
            }
        }

        /// <summary>
        /// The element type of a numpy array is stored as a byte. The value of this byte is defined as an enum
        /// (BinaryModelPackageElementType). This method converts these element type constants into respective
        /// C# types to create an array using reflection.
        /// <param name="elementType">A byte value read from buffer that specifies the type of numpy array.</param>
        /// <returns>A Class object used by reflection to create a new array.</returns>
        /// </summary>
        private Type GetComponentType(BinaryModelPackageElementType elementType)
        {
            Type result = null;

            if (elementType == BinaryModelPackageElementType.Byte)
            {
                result = typeof(sbyte);
            }
            else if (elementType == BinaryModelPackageElementType.UnsignedByte)
            {
                result = typeof(sbyte);
            }
            else if (elementType == BinaryModelPackageElementType.Short)
            {
                result = typeof(short);
            }
            else if (elementType == BinaryModelPackageElementType.UnsignedShort)
            {
                result = typeof(short);
            }
            else if (elementType == BinaryModelPackageElementType.Integer)
            {
                result = typeof(int);
            }
            else if (elementType == BinaryModelPackageElementType.UnsignedInteger)
            {
                result = typeof(int);
            }
            else if (elementType == BinaryModelPackageElementType.LongInteger)
            {
                result = typeof(long);
            }
            else if (elementType == BinaryModelPackageElementType.UnsignedLongInteger)
            {
                result = typeof(long);
            }
            else if (elementType == BinaryModelPackageElementType.Float)
            {
                result = typeof(float);
            }
            else if (elementType == BinaryModelPackageElementType.Double)
            {
                result = typeof(double);
            }
            else
            {
                throw new Exception($"Numpy array with element type {(int)elementType} is not supported.");
            }

            return result;
        }

        /// <summary>
        /// Gets a BinaryModelPackagePrimitiveValueReader to read numerical values from the stream. This method was
        /// added to prevent having many if-elses in the code.
        /// <param name="elementType">A byte value read from buffer that specifies the type of numerical value.</param>
        /// <returns>An instance of BinaryModelPackagePrimitiveValueReader to read numerical values.</returns>
        /// </summary>
        private BinaryModelPackagePrimitiveValueReader GetPrimitiveDataReader(BinaryModelPackageElementType elementType)
        {
            BinaryModelPackagePrimitiveValueReader result = null;

            if (elementType == BinaryModelPackageElementType.Byte)
            {
                result = () => ReadByte();
            }
            else if (elementType == BinaryModelPackageElementType.UnsignedByte)
            {
                result = () => ReadByte();
            }
            else if (elementType == BinaryModelPackageElementType.Short)
            {
                result = () => ReadShort();
            }
            else if (elementType == BinaryModelPackageElementType.UnsignedShort)
            {
                result = () => ReadShort();
            }
            else if (elementType == BinaryModelPackageElementType.Integer)
            {
                result = () => ReadInteger();
            }
            else if (elementType == BinaryModelPackageElementType.UnsignedInteger)
            {
                result = () => ReadInteger();
            }
            else if (elementType == BinaryModelPackageElementType.LongInteger)
            {
                result = () => ReadLongInteger();
            }
            else if (elementType == BinaryModelPackageElementType.UnsignedLongInteger)
            {
                result = () => ReadLongInteger();
            }
            else if (elementType == BinaryModelPackageElementType.Float)
            {
                result = () => ReadFloat();
            }
            else if (elementType == BinaryModelPackageElementType.Double)
            {
                result = () => ReadDouble();
            }
            else if (elementType == BinaryModelPackageElementType.Dictionary)
            {
                result = () => ReadDictionary();
            }
            else if (elementType == BinaryModelPackageElementType.NumpyArray)
            {
                result = () => ReadNumpyArray();
            }
            else if (elementType == BinaryModelPackageElementType.StringArray)
            {
                result = () => ReadStringArray();
            }
            else if (elementType == BinaryModelPackageElementType.List)
            {
                result = () => ReadList();
            }
            else if (elementType == BinaryModelPackageElementType.String)
            {
                result = () => ReadString();
            }
            else
            {
                throw new Exception($"Numpy array with element type {(int)elementType} is not supported.");
            }

            return result;
        }


        /// <summary>
        /// Reads a buffer from the stream.
        /// <param name="size">Length of the buffer to be read from stream.</param>
        /// <returns>A byte[] buffer.</returns>
        /// </summary>
        private byte[] ReadBuffer(int size)
        {
            byte[] buffer = new byte[size];

            int length = 0;
            length = stream.Read(buffer, 0, size);

            if (length != size)
            {
                throw new Exception($"Unable to read {size} bytes from the stream.");
            }

            return buffer;
        }

        /// <summary>
        /// Reads an array of string from the stream.
        /// <returns>The String[] stored in the stream, or null if it has no value.</returns>
        /// </summary>
        public String[] ReadStringArray()
        {
            String[] result = null;
            int hasValue = ReadByte();

            if (hasValue == 1)
            {
                int count = ReadInteger();
                result = new String[count];

                for (int i = 0; i < count; i++)
                {
                    result[i] = ReadString();
                }
            }

            return result;
        }

        public bool CanRead()
        {
            return stream.Length > 0;
        }
    }
}