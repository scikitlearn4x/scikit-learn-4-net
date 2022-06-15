using System;
using System.Collections.Generic;
using SkLearn.Base;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Core.Packaging.Loaders
{
    /// <summary>
    /// A base class that implements common functionality shred among the scikit-learn object
    /// loaders. Each loader will provide a list of supported fields to BaseScikitLearnContentLoader
    /// instead of implementing the deserialization manually to simplify the loaders as much as
    /// possible.
    /// <typeparam name="ObjectType">The type of the scikit-learn object that the loader supports.</typeparam>
    /// </summary>
    public abstract class BaseScikitLearnContentLoader<ObjectType> : IScikitLearnContentLoader where ObjectType : class
    {
        /// <summary>
        /// The type name of the loader.
        /// </summary>
        private String typeName = null;

        /// <summary>
        /// A map of the fields the loader requires to load an object.
        /// </summary>
        private Dictionary<String, LoaderFieldInfo> fields = new Dictionary<String, LoaderFieldInfo>();


        /// <summary>
        /// Name of the loader. The name is stored in the header of the binary package file to be used during
        /// deserialization.
        /// <returns>The name/id of the loader type.</returns>
        /// </summary>
        public String TypeName
        {
            get { return this.typeName; }
        }

        /// <summary>
        /// Instantiate a BaseScikitLearnContentLoader object.
        /// <param name="typeName">The type name of the loader.
        /// </param>
        /// </summary>
        protected BaseScikitLearnContentLoader(String typeName)
        {
            this.typeName = typeName;
            RegisterSetters();
            
            if (CreateResultObject() is ClassifierMixin) {
                RegisterLongField("n_features", SetNumberOfFeatureIn);
                RegisterStringArrayField("feature_names", SetFeaturesIn);
            }
        }

        /// <summary>
        /// Loads the scikit-learn object with the provided layout in registerSetters.
        /// <param name="buffer">The buffer to load the object from.
        /// </param>
        /// <returns>The fully initialized scikit-learn object.</returns>
        /// </summary>
        public Object LoadContent(BinaryModelPackage buffer)
        {
            ObjectType result = CreateResultObject();
            int fieldCount = buffer.ReadInteger();

            for (int i = 0; i < fieldCount; i++)
            {
                String name = buffer.ReadString();
                if (!fields.ContainsKey(name))
                {
                    throw new ScikitLearnCoreException("Package contains an unregistered field name: " + name);
                }

                LoaderFieldInfo info = fields[name];

                if (info.fieldType == LoaderFieldInfoType.Double)
                {
                    double value = buffer.ReadDouble();
                    ((ScikitLearnLoaderDoubleFieldSetter<ObjectType>)info.setter)(result, value);
                }
                else if (info.fieldType == LoaderFieldInfoType.Long)
                {
                    long value = buffer.ReadLongInteger();
                    ((ScikitLearnLoaderLongFieldSetter<ObjectType>)info.setter)(result, value);
                }
                else if (info.fieldType == LoaderFieldInfoType.NumpyArray)
                {
                    Object value = buffer.ReadNumpyArray();
                    ((ScikitLearnLoaderNumpyArrayFieldSetter<ObjectType>)info.setter)(result, value);
                }
                else if (info.fieldType == LoaderFieldInfoType.StringArray)
                {
                    String[] value = buffer.ReadStringArray();
                    ((ScikitLearnLoaderStringArrayFieldSetter<ObjectType>)info.setter)(result, value);
                }
                else if (info.fieldType == LoaderFieldInfoType.ListOfNumpyArray)
                {
                    List<Object> value = buffer.ReadList();
                    ((ScikitLearnLoaderListOfNumpyArrayFieldSetter<ObjectType>) info.setter)(result, value);
                }
            }

            return result;
        }

        /// <summary>
        /// Creates a clone of the instance.
        /// <returns>An empty clean instance of the loader.</returns>
        /// </summary>
        public abstract IScikitLearnContentLoader Duplicate();

        /// <summary>
        /// An abstract method to initialize a new instance of the scikit-learn object supported
        /// by the loader.
        /// <returns>The unloaded scikit-learn object supported by the loader.</returns>
        /// </summary>
        protected abstract ObjectType CreateResultObject();

        /// <summary>
        /// An abstract method implemented by the derived classes that loads the layout of the
        /// binary format. BaseScikitLearnContentLoader uses this layout to load the object.
        /// </summary>
        protected abstract void RegisterSetters();

        /// <summary>
        /// Registers a double field for the scikit-learn serialized layout.
        /// <param name="name">Name of the field.</param>
        /// <param name="setter">The setter callback to load the value of the scikit-learn object.
        /// </param>
        /// </summary>
        protected void RegisterDoubleField(String name, ScikitLearnLoaderDoubleFieldSetter<ObjectType> setter)
        {
            if (fields.ContainsKey(name))
            {
                throw new ScikitLearnCoreException("Field is already added");
            }

            LoaderFieldInfo field = new LoaderFieldInfo();
            field.name = name;
            field.setter = setter;
            field.fieldType = LoaderFieldInfoType.Double;

            fields.Add(name, field);
        }

        /// <summary>
        /// Registers a long integer field for the scikit-learn serialized layout.
        /// <param name="name">Name of the field.</param>
        /// <param name="setter">The setter callback to load the value of the scikit-learn object.
        /// </param>
        /// </summary>
        protected void RegisterLongField(String name, ScikitLearnLoaderLongFieldSetter<ObjectType> setter)
        {
            if (fields.ContainsKey(name))
            {
                throw new ScikitLearnCoreException("Field is already added");
            }

            LoaderFieldInfo field = new LoaderFieldInfo();
            field.name = name;
            field.setter = setter;
            field.fieldType = LoaderFieldInfoType.Long;

            fields.Add(name, field);
        }

        /// <summary>
        /// Registers a numpy array field for the scikit-learn serialized layout.
        /// <param name="name">Name of the field.</param>
        /// <param name="setter">The setter callback to load the value of the scikit-learn object.
        /// </param>
        /// </summary>
        protected void RegisterNumpyArrayField(String name, ScikitLearnLoaderNumpyArrayFieldSetter<ObjectType> setter)
        {
            if (fields.ContainsKey(name))
            {
                throw new ScikitLearnCoreException("Field is already added");
            }

            LoaderFieldInfo field = new LoaderFieldInfo();
            field.name = name;
            field.setter = setter;
            field.fieldType = LoaderFieldInfoType.NumpyArray;

            fields.Add(name, field);
        }

        /// <summary>
        /// Registers a String array field for the scikit-learn serialized layout.
        /// <param name="name">Name of the field.</param>
        /// <param name="setter">The setter callback to load the value of the scikit-learn object.
        /// </param>
        /// </summary>
        protected void RegisterStringArrayField(String name, ScikitLearnLoaderStringArrayFieldSetter<ObjectType> setter)
        {
            if (fields.ContainsKey(name))
            {
                throw new ScikitLearnCoreException("Field is already added");
            }

            LoaderFieldInfo field = new LoaderFieldInfo();
            field.name = name;
            field.setter = setter;
            field.fieldType = LoaderFieldInfoType.StringArray;

            fields.Add(name, field);
        }
        
        /// <summary>
        /// Registers a list of numpy array field for the scikit-learn serialized layout.
        /// <param name="name">Name of the field.</param>
        /// <param name="setter">The setter callback to load the value of the scikit-learn object.
        /// </param>
        /// </summary>
        protected void RegisterListOfNumpyArrayField(String name, ScikitLearnLoaderListOfNumpyArrayFieldSetter<ObjectType> setter)
        {
            if (fields.ContainsKey(name))
            {
                throw new ScikitLearnCoreException("Field is already added");
            }

            LoaderFieldInfo field = new LoaderFieldInfo();
            field.name = name;
            field.setter = setter;
            field.fieldType = LoaderFieldInfoType.ListOfNumpyArray;

            fields.Add(name, field);
        }
        
        /// <summary>
        /// Sets the list of features names' of the dataset the model was trained on.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The list of feature names.</param>
        /// </summary>
        private void SetFeaturesIn(ObjectType result, String[] value) {
            if (result is ClassifierMixin mixin) {
                mixin.FeatureNames = value;
            } 
        }

        /// <summary>
        /// Sets the number of features of the dataset the model was trained on.
        /// <param name="result">The classifier to be loaded.</param>
        /// <param name="value">The number of features.</param>
        /// </summary>
        private void SetNumberOfFeatureIn(ObjectType result, long value) {
            if (result is ClassifierMixin mixin) {
                mixin.NumberOfFeatures = value;
            }
        }
        
        /// <summary>
        /// Casts a list of Object to a list of double NumpyArray. 
        /// </summary>
        /// <param name="list">List to be converted.</param>
        /// <returns>The list of double NumpyArray</returns>
        protected List<NumpyArray<double>> AsListOfDoubleNumpyArray(List<Object> list)
        {
            List<NumpyArray<double>> result = new List<NumpyArray<double>>(list.Count);

            foreach (Object o in list)
            {
                result.Add((NumpyArray<double>)o);
            }
            
            return result;
        }

    }

    /// <summary>
    /// Different type of field supported by BaseScikitLearnContentLoader.
    /// </summary>
    internal enum LoaderFieldInfoType
    {
        None,
        Double,
        Long,
        NumpyArray,
        StringArray,
        ListOfNumpyArray,
    }

    /// <summary>
    /// Callback to set a double value in scikit-learn object.
    /// </summary>
    /// <typeparam name="ObjectType">The type of the scikit-learn object.</typeparam>
    public delegate void ScikitLearnLoaderDoubleFieldSetter<ObjectType>(ObjectType obj, double value);

    /// <summary>
    /// Callback to set a long value in scikit-learn object.
    /// </summary>
    /// <typeparam name="ObjectType">The type of the scikit-learn object.</typeparam>
    public delegate void ScikitLearnLoaderLongFieldSetter<ObjectType>(ObjectType obj, long value);

    /// <summary>
    /// Callback to set a numpy value in scikit-learn object.
    /// </summary>
    /// <typeparam name="ObjectType">The type of the scikit-learn object.</typeparam>
    public delegate void ScikitLearnLoaderNumpyArrayFieldSetter<ObjectType>(ObjectType obj, Object value);

    /// <summary>
    /// Callback to set a string array value in scikit-learn object.
    /// </summary>
    /// <typeparam name="ObjectType">The type of the scikit-learn object.</typeparam>
    public delegate void ScikitLearnLoaderStringArrayFieldSetter<ObjectType>(ObjectType obj, String[] value);

    /// <summary>
    /// Callback to set a list of numpy array value in scikit-learn object.
    /// </summary>
    /// <typeparam name="ObjectType">The type of the scikit-learn object.</typeparam>
    public delegate void ScikitLearnLoaderListOfNumpyArrayFieldSetter<ObjectType>(ObjectType obj, List<Object> value);

    /// <summary>
    /// Data class to hold the layout of the scikit-learn object.
    /// </summary>
    internal class LoaderFieldInfo
    {
        /// <summary>
        /// The name of the field.
        /// </summary>
        public String name = null;
        
        /// <summary>
        /// The type of the field.
        /// </summary>
        public LoaderFieldInfoType fieldType = LoaderFieldInfoType.None;
        
        /// <summary>
        /// The setting method that sets the loaded value in the classifier.
        /// </summary>
        public Object setter = null;
    }
}