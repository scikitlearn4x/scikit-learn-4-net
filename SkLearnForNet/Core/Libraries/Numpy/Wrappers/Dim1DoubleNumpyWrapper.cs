/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
    public class Dim1DoubleNumpyWrapper : INumpyArrayWrapper<double>
    {
        private double[] array;
        private int[] shape;

        public Dim1DoubleNumpyWrapper(double[] array)
        {
            this.array = array;
            this.shape = new[] { array.GetLength(0) };
        }

        public int[] Shape
        {
            get { return shape; }
        }

        public double Get(params int[] indices)
        {
            return array[indices[0]];
        }

        public void Set(double value, params int[] indices)
        {
            this.array[indices[0]] = value;
        }

        public bool IsFloatingPoint
        {
            get { return true; }
        }


        public int NumberOfBits
        {
            get { return 64; }
        }


        public Object RawArray
        {
            get { return array; }
        }


        public NumpyArray<double> WrapInnerSubsetArray(params int[] indices)
        {
            throw new NumpyOperationException("A single dimension sub array can't be sliced.");
        }


        public NumpyArray<double> Transpose()
        {
            double[] result = new double[shape[0]];

            for (int d0 = 0; d0 < this.shape[0]; d0++)
            {
                result[d0] = array[d0];
            }

            return NumpyArrayFactory.From(result);
        }
    }
}