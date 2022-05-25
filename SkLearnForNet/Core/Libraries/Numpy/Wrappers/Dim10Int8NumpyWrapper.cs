/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
    public class Dim10Int8NumpyWrapper : INumpyArrayWrapper<byte>
    {
        private byte[,,,,,,,,,] array;
        private int[] shape;

        public Dim10Int8NumpyWrapper(byte[,,,,,,,,,] array)
        {
            this.array = array;
            this.shape = new[] { array.GetLength(0), array.GetLength(1), array.GetLength(2), array.GetLength(3), array.GetLength(4), array.GetLength(5), array.GetLength(6), array.GetLength(7), array.GetLength(8), array.GetLength(9) };
        }

        public int[] Shape
        {
            get { return shape; }
        }

        public byte Get(params int[] indices)
        {
            return array[indices[0], indices[1], indices[2], indices[3], indices[4], indices[5], indices[6], indices[7], indices[8], indices[9]];
        }

        public void Set(byte value, params int[] indices)
        {
            this.array[indices[0], indices[1], indices[2], indices[3], indices[4], indices[5], indices[6], indices[7], indices[8], indices[9]] = value;
        }

        public bool IsFloatingPoint
        {
            get { return false; }
        }


        public int NumberOfBits
        {
            get { return 8; }
        }


        public Object RawArray
        {
            get { return array; }
        }


        public NumpyArray<byte> WrapInnerSubsetArray(params int[] indices)
        {
            NumpyArray<byte> result = null;

            if (indices.Length == 1)
            {
                result = NumpyArrayFactory.From((byte[,,,,,,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
            }
            else if (indices.Length == 2)
            {
                result = NumpyArrayFactory.From((byte[,,,,,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
            }
            else if (indices.Length == 3)
            {
                result = NumpyArrayFactory.From((byte[,,,,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
            }
            else if (indices.Length == 4)
            {
                result = NumpyArrayFactory.From((byte[,,,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
            }
            else if (indices.Length == 5)
            {
                result = NumpyArrayFactory.From((byte[,,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
            }
            else if (indices.Length == 6)
            {
                result = NumpyArrayFactory.From((byte[,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
            }
            else if (indices.Length == 7)
            {
                result = NumpyArrayFactory.From((byte[,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
            }
            else if (indices.Length == 8)
            {
                result = NumpyArrayFactory.From((byte[,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
            }
            else if (indices.Length == 9)
            {
                result = NumpyArrayFactory.From((byte[])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
            }
            else
            {
                throw new NumpyOperationException("Invalid slice for array specified.");
            }

            return result;
        }


        public NumpyArray<byte> Transpose()
        {
            byte[,,,,,,,,,] result = new byte[shape[9], shape[8], shape[7], shape[6], shape[5], shape[4], shape[3], shape[2], shape[1], shape[0]];

            for (int d0 = 0; d0 < this.shape[0]; d0++)
            {
                for (int d1 = 0; d1 < this.shape[1]; d1++)
                {
                    for (int d2 = 0; d2 < this.shape[2]; d2++)
                    {
                        for (int d3 = 0; d3 < this.shape[3]; d3++)
                        {
                            for (int d4 = 0; d4 < this.shape[4]; d4++)
                            {
                                for (int d5 = 0; d5 < this.shape[5]; d5++)
                                {
                                    for (int d6 = 0; d6 < this.shape[6]; d6++)
                                    {
                                        for (int d7 = 0; d7 < this.shape[7]; d7++)
                                        {
                                            for (int d8 = 0; d8 < this.shape[8]; d8++)
                                            {
                                                for (int d9 = 0; d9 < this.shape[9]; d9++)
                                                {
                                                    result[d9, d8, d7, d6, d5, d4, d3, d2, d1, d0] = array[d0, d1, d2, d3, d4, d5, d6, d7, d8, d9];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return NumpyArrayFactory.From(result);
        }
    }
}