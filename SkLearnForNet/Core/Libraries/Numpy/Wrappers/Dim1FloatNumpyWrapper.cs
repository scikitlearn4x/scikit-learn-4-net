/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
	public class Dim1FloatNumpyWrapper : INumpyArrayWrapper<float>
	{
		private float[] array;
		private int[] shape;

		public Dim1FloatNumpyWrapper(float[] array)
		{
			this.array = array;
			this.shape = new[] {array.GetLength(0)};
		}

		public int[] Shape
		{
			get
			{
				return shape;
			}
		}

		public float Get(params int[] indices)
		{
			return array[indices[0]];
		}

		public void Set(float value, params int[] indices)
		{
			this.array[indices[0]] = value;
		}

		public bool IsFloatingPoint
		{
			get
			{
				return true;
			}
		}


		public int NumberOfBits
		{
			get
			{
				return 32;
			}
		}


		public Object RawArray
		{
			get
			{
				return array;
			}
			set
			{
				array = (float[])value;
			}
		}


		public NumpyArray<float> WrapInnerSubsetArray(params int[] indices)
		{
			throw new NumpyOperationException("A single dimension sub array can't be sliced.");
		}


		public NumpyArray<float> Transpose() {
			float[] result = new float[shape[0]];

			for (int d0 = 0; d0 < this.shape[0]; d0++) {
				result[d0] = array[d0];

			}

			return NumpyArrayFactory.From(result);
		}
	}
}