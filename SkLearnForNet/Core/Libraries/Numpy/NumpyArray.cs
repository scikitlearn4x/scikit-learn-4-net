using System;
using SkLearn.Core.Libraries.Numpy.Wrappers;

namespace SkLearn.Core.Libraries.Numpy
{
    public delegate ElementType NumpyArrayElementOperation<ElementType>(ElementType value);
    public delegate void NumpyArrayElementIterateOperation<ElementType>(ElementType value, int[] index);

    public class NumpyArray<ElementType> where ElementType : struct
    {
        private INumpyArrayWrapper<ElementType> data = null;

        public NumpyArray(INumpyArrayWrapper<ElementType> data)
        {
            this.data = data;
        }

        public int[] Shape
        {
            get { return data.Shape; }
        }

        public ElementType Get(params int[] indices)
        {
            if (indices.Length != Shape.Length)
            {
                throw new NumpyOperationException("The number of indices provided doesn't match the number of dimensions.");
            }

            return data.Get(indices);
        }

        public void ApplyToEachElement(NumpyArrayElementOperation<ElementType> operation)
        {
            int[] shape = data.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                data.Set(operation((ElementType)data.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);
        }

        public void ApplyToEachElementAnsSaveToTarget(NumpyArray<ElementType> target, NumpyArrayElementOperation<ElementType> operation)
        {
            int[] shape = data.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                target.Set(operation(data.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);
        }
        
        public void IterateOnEachElement(NumpyArrayElementIterateOperation<ElementType> operation)
        {
            int[] shape = data.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                operation(data.Get(index), index);
            } while (counter[counter.Length - 1] == 0);
        }

        internal static void AddCounter(int[] counter, int[] shape)
        {
            counter[0]++;

            for (int i = 0; i < shape.Length; i++)
            {
                if (counter[i] == shape[i])
                {
                    counter[i] = 0;
                    counter[i + 1]++;
                }
                else
                {
                    break;
                }
            }
        }


        public void Set(ElementType value, params int[] indices)
        {
            data.Set(value, indices);
        }

        public bool IsFloatingPoint
        {
            get { return data.IsFloatingPoint; }
        }

        public int NumberOfBytes
        {
            get { return data.NumberOfBits / 8; }
        }

        public NumpyArray<ElementType> Transpose()
        {
            return data.Transpose();
        }

        public bool IsSingleValueArray()
        {
            int count = 1;
            int[] shape = Shape;

            for (int i = 0; i < shape.Length; i++)
            {
                count *= shape[i];
            }

            return count == 1;
        }

        public ElementType GetSingleValue()
        {
            int[] shape = Shape;
            int[] index = new int[shape.Length];

            return data.Get(index);
        }

        public NumpyArray<ElementType> WrapInnerSubsetArray(params int[] indices)
        {
            return data.WrapInnerSubsetArray(indices);
        }

        public int NumberOfDimensions
        {
            get { return Shape.Length; }
        }

        public INumpyArrayWrapper<ElementType> GetWrapper()
        {
            return data;
        }

        
    }
}