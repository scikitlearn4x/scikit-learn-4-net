// ==================================================================
// Inference for LabelEncoder
//
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.LabelEncoder.html#sklearn.preprocessing.LabelEncoder
// ==================================================================

using SkLearn.Base;
using SkLearn.Core;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Preprocessing.Label
{
    /// <summary>
    /// Encode target labels with value between 0 and n_classes-1.
    /// This transformer should be used to encode target values, *i.e.* `y`,
    /// and not the input `X`.
    /// </summary>
    public class LabelEncoder : TransformerMixin<List<Object>, NumpyArray<long>>
    {
        /// <summary>
        /// Instantiate a new object of LabelEncoder.
        /// </summary>
        public LabelEncoder()
        {
        }

        /// <summary>
        /// Holds the label for each class.
        /// </summary>
        public List<Object> Classes { get; internal set; }

        /// <summary>
        /// Transform labels to normalized encoding.
        /// <param name="array">array-like of shape (n_samples,) Target values.</param>
        /// <returns>array-like of shape (n_samples,) Labels as normalized encodings.</returns>
        /// </summary>
        public override NumpyArray<long> Transform(List<Object> array)
        {
            Dictionary<Object, long> mapper = new Dictionary<Object, long>();

            foreach (Object cls in Classes)
            {
                mapper.Add(cls, mapper.Count);
            }


            long[] result = new long[array.Count];

            int i = 0;
            foreach (Object obj in array)
            {
                if (mapper.ContainsKey(obj))
                {
                    result[i] = mapper[obj];
                    i++;
                }
                else
                {
                    throw new ScikitLearnCoreException($"The class '{obj}' was not defined during the LabelEncoder training.");
                }
            }

            return NumpyArrayFactory.From(result);
        }

        /// <summary>
        /// Takes a transformed array and reveres the transformation.
        /// <param name="array">The array to apply reveres transform.</param>
        /// <returns>The inversed transform of array.</returns>
        /// </summary>
        public override List<Object> InverseTransform(NumpyArray<long> array)
        {
            List<Object> result = new List<Object>();
            long[] values = (long[])array.GetWrapper().RawArray;

            for (int i = 0; i < values.Length; i++)
            {
                int cls = (int)values[i];
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
    }
}