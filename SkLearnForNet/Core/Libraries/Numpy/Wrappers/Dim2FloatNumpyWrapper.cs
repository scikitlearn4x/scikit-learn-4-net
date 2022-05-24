/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
	public class Dim2FloatNumpyWrapper : INumpyArrayWrapper<float>
	{
		private float[,] array;
		private int[] shape;

		public Dim2FloatNumpyWrapper(float[,] array)
		{
			this.array = array;
			this.shape = new[] {array.GetLength(0), array.GetLength(1)};
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
			return array[indices[0], indices[1]];
		}

		public void Set(float value, params int[] indices)
		{
			this.array[indices[0], indices[1]] = value;
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
		}


		public NumpyArray<float> WrapInnerSubsetArray(params int[] indices)
		{
			NumpyArray<float> result = null;

			if (indices.Length == 1) {
				result = NumpyArrayFactory.From((float[])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else {
				throw new NumpyOperationException("Invalid slice for array specified.");
			}

			return result;
		}


		public NumpyArray<float> Transpose() {
			float[,] result = new float[shape[1], shape[0]];

			for (int d0 = 0; d0 < this.shape[0]; d0++) {
				for (int d1 = 0; d1 < this.shape[1]; d1++) {
					result[d1, d0] = array[d0, d1];

				}
			}

			return NumpyArrayFactory.From(result);
		}
	}
}