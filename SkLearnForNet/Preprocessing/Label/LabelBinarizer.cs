// ==================================================================
// Inference for LabelBinarizer
//
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.LabelBinarizer.html
// ==================================================================

using SkLearn.Base;
using SkLearn.Core;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Preprocessing.Label
{
    /// <summary>
    /// Binarize labels in a one-vs-all fashion.
    /// Several regression and binary classification algorithms are available
    /// in scikit-learn. A simple way to extend these algorithms to the
    /// multi-class classification case is to use the so-called one-vs-all
    /// scheme.
    /// At learning time, this simply consists in learning one regressor or
    /// binary classifier per class. In doing so, one needs to convert
    /// multi-class labels to binary labels (belong or does not belong to the
    /// class). LabelBinarizer makes this process easy with the transform
    /// method.
    /// At prediction time, one assigns the class for which the corresponding
    /// model gave the greatest confidence. LabelBinarizer makes this easy
    /// with the inverse_transform method.
    /// </summary>
    public class LabelBinarizer : TransformerMixin<List<Object>, NumpyArray<long>>
    {
        /// <summary>
        /// Constant value for y_type binary.
        /// </summary>
        private const String Y_TYPE_BINARY = "binary";

        /// <summary>
        /// Constant value for y_type multi class.
        /// </summary>
        private const String Y_TYPE_MULTICLASS = "multiclass";

        /// <summary>
        /// Instantiate a new object of LabelBinarizer.
        /// </summary>
        public LabelBinarizer()
        {
            PositiveLabel = 1;
            NegativeLabel = 0;
        }

        /// <summary>
        /// Holds the label for each class.
        /// </summary>
        public List<Object> Classes { get; internal set; }

        /// <summary>
        /// Represents the type of the target data as evaluated by
        /// utils.multiclass.type_of_target. Possible type are 'continuous',
        /// 'continuous-multioutput', 'binary', 'multiclass',
        /// 'multiclass-multioutput', 'multilabel-indicator', and 'unknown'.
        /// </summary>
        public String YType { get; internal set; }

        /// <summary>
        /// Internal field of scikit-learn object.
        /// </summary>
        public long NegativeLabel { get; internal set; }

        /// <summary>
        /// Internal field of scikit-learn object.
        /// </summary>
        public long PositiveLabel { get; internal set; }

        /// <summary>
        /// Takes the input array and transforms it.
        /// <param name="array">The array to transform.</param>
        /// <returns>The transformed array.</returns>
        /// </summary>
        public override NumpyArray<long> Transform(List<Object> array)
        {
            if (YType.Equals(Y_TYPE_BINARY))
            {
                return TransformBinary(array);
            }
            else if (YType.Equals(Y_TYPE_MULTICLASS))
            {
                return TransformMulticlass(array);
            }
            else
            {
                throw new ScikitLearnFeatureNotImplementedException($"The YType={YType} in LabelBinarizer is not implemented.");
            }
        }

        /// <summary>
        /// Transforms a list of labels into a binary format. Since there are only two possible
        /// values, the length of the encoded is 1.
        /// <param name="array">The input label list to binarize.</param>
        /// <returns>The transformed array.</returns>
        /// </summary>
        private NumpyArray<long> TransformBinary(List<Object> array)
        {
            Dictionary<Object, int> mapper = new Dictionary<Object, int>();

            foreach (Object cls in Classes)
            {
                mapper.Add(cls, mapper.Count);
            }

            NumpyArray<long> result = NumpyArrayFactory.ArrayOfInt64WithShape(new int[] { array.Count, 1 });

            int i = 0;
            foreach (Object obj in array)
            {
                if (mapper.ContainsKey(obj))
                {
                    int index = mapper[obj];
                    result.Set(index == 0 ? NegativeLabel : PositiveLabel, i, 0);
                    i++;
                }
                else
                {
                    throw new ScikitLearnCoreException($"The class '{obj}' was not defined during the LabelEncoder training.");
                }
            }

            return result;
        }

        /// <summary>
        /// Transforms a list of labels into a multiclass format. Since there are multiple possible
        /// values, the length of the encoded is the number of classes, but only one of them is 1.
        /// <param name="array">The input label list to binarize.</param>
        /// <returns>The transformed array.</returns>
        /// </summary>
        private NumpyArray<long> TransformMulticlass(List<Object> array)
        {
            Dictionary<Object, int> mapper = new Dictionary<Object, int>();

            foreach (Object cls in Classes)
            {
                mapper.Add(cls, mapper.Count);
            }

            NumpyArray<long> result = NumpyArrayFactory.ArrayOfInt64WithShape(new int[] { array.Count, Classes.Count });

            int i = 0;
            int classCount = Classes.Count;
            foreach (Object obj in array)
            {
                if (mapper.ContainsKey(obj))
                {
                    int index = mapper[obj];
                    for (int j = 0; j < classCount; j++)
                    {
                        if (j == index)
                        {
                            result.Set(PositiveLabel, i, j);
                        }
                        else
                        {
                            result.Set(NegativeLabel, i, j);
                        }
                    }

                    i++;
                }
                else
                {
                    throw new ScikitLearnCoreException($"The class '{obj}' was not defined during the LabelEncoder training.");
                }
            }

            return result;
        }

        /// <summary>
        /// Takes a transformed array and reveres the transformation.
        /// <param name="array">The array to apply reveres transform.</param>
        /// <returns>The inversed transform of array.</returns>
        /// </summary>
        public override List<Object> InverseTransform(NumpyArray<long> array)
        {
            if (YType.Equals(Y_TYPE_BINARY))
            {
                return InverseTransformBinary(array);
            }
            else if (YType.Equals(Y_TYPE_MULTICLASS))
            {
                return InverseTransformMulticlass(array);
            }
            else
            {
                throw new ScikitLearnFeatureNotImplementedException($"The YType={YType} in LabelBinarizer is not implemented.");
            }
        }

        /// <summary>
        /// Reverse the transformation on a binary encoded label column.
        /// <param name="array">The binary encoded labels.</param>
        /// <returns>List of object that better represents the labels.</returns>
        /// </summary>
        private List<Object> InverseTransformBinary(NumpyArray<long> array)
        {
            List<Object> result = new List<Object>();
            long[][] values = (long[][])array.GetWrapper().RawArray;

            for (int i = 0; i < values.Length; i++)
            {
                int cls = (int)values[i][0];
                result.Add(cls == NegativeLabel ? Classes[0] : Classes[1]);
            }

            return result;
        }

        /// <summary>
        /// Reverse the transformation on a multiclass encoded label column.
        /// <param name="array">The multiclass encoded labels.</param>
        /// <returns>List of object that better represents the labels.</returns>
        /// </summary>
        private List<Object> InverseTransformMulticlass(NumpyArray<long> array)
        {
            List<Object> result = new List<Object>();
            long[][] values = (long[][])array.GetWrapper().RawArray;

            for (int i = 0; i < values.Length; i++)
            {
                int cls = GetPositiveLabelIndex(values[i]);
                if (cls < 0 || cls >= Classes.Count)
                {
                    throw new ScikitLearnCoreException($"The class '{cls}' is not in valid range.");
                }
                else
                {
                    result.Add(Classes[cls]);
                }
            }

            return result;
        }

        /// <summary>
        /// Gets which index holds the class presence. This only works for multiclass binarized columns.
        /// <param name="value">The binarized value.</param>
        /// <returns>Index of the class.</returns>
        /// </summary>
        private int GetPositiveLabelIndex(long[] value)
        {
            int result = -1;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == PositiveLabel)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}