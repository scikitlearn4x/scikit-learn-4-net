// ==================================================================
// Inference for MultiLabelBinarizer
// 
// Scaffolded and manually converted from: https://scikit-learn.org/stable/modules/generated/sklearn.preprocessing.MultiLabelBinarizer.html
// ==================================================================

using SkLearn.Base;
using SkLearn.Core;
using SkLearn.Core.Libraries.Numpy;

namespace SkLearn.Preprocessing.Label
{
    /// <summary>
    /// Transform between iterable of iterables and a multilabel format.
    /// Although a list of sets or tuples is a very intuitive format for
    /// multilabel data, it is unwieldy to process. This transformer converts
    /// between this intuitive format and the supported multilabel format: a
    /// (samples x classes)
    /// </summary>
    public class MultiLabelBinarizer : TransformerMixin<List<ISet<Object>>, NumpyArray<long>>
    {
        /// <summary>
        /// Instantiate a new object of MultiLabelBinarizer.
        /// </summary>
        public MultiLabelBinarizer()
        {
        }

        /// <summary>
        /// A copy of the `classes` parameter when provided. Otherwise it
        /// corresponds to the sorted set of classes found when fitting.
        /// </summary>
        public List<Object> Classes { get; internal set; }

        /// <summary>
        /// Internal field of scikit-learn object.
        /// </summary>
        public Dictionary<String, Object> CachedDict { get; internal set; }

        /// <summary>
        /// Takes the input array and transforms it.
        /// <param name="array">The array to transform.</param>
        /// <returns>The transformed array.</returns>
        /// </summary>
        public override NumpyArray<long> Transform(List<ISet<Object>> array)
        {
            Dictionary<Object, int> mapper = new Dictionary<Object, int>();

            foreach (Object cls in Classes)
            {
                mapper.Add(cls, mapper.Count);
            }


            NumpyArray<long> result = NumpyArrayFactory.ArrayOfInt64WithShape(new int[] { array.Count, Classes.Count });

            for (int i = 0; i < array.Count; i++)
            {
                ISet<Object> labels = array[i];

                foreach (Object label in labels)
                {
                    if (mapper.ContainsKey(label))
                    {
                        long index = mapper[label];
                        result.Set(1, i, (int)index);
                    }
                    else
                    {
                        throw new ScikitLearnCoreException($"The class '{label}' was not defined during the MultiLabelBinarizer training.");
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Takes a transformed array and reveres the transformation.
        /// <param name="array">The array to apply reveres transform.</param>
        /// <returns>The inversed transform of array.</returns>
        /// </summary>
        public override List<ISet<Object>> InverseTransform(NumpyArray<long> array)
        {
            List<ISet<Object>> result = new List<ISet<Object>>();

            for (int i = 0; i < array.Shape[0]; i++)
            {
                ISet<Object> labels = new HashSet<Object>();
                result.Add(labels);

                for (int j = 0; j < Classes.Count; j++)
                {
                    long value = array.Get(i, j);
                    if (value != 0)
                    {
                        labels.Add(Classes[j]);
                    }
                }
            }

            return result;
        }
    }
}