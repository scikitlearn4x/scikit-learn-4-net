/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
	public class Dim5FloatNumpyWrapper : INumpyArrayWrapper<float>
	{
		private float[,,,,] array;
		private int[] shape;

		public Dim5FloatNumpyWrapper(float[,,,,] array)
		{
			this.array = array;
			this.shape = new[] {array.GetLength(0), array.GetLength(1), array.GetLength(2), array.GetLength(3), array.GetLength(4)};
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
			return array[indices[0], indices[1], indices[2], indices[3], indices[4]];
		}

		public void Set(float value, params int[] indices)
		{
			this.array[indices[0], indices[1], indices[2], indices[3], indices[4]] = value;
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
				result = NumpyArrayFactory.From((float[,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 2) {
				result = NumpyArrayFactory.From((float[,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 3) {
				result = NumpyArrayFactory.From((float[,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 4) {
				result = NumpyArrayFactory.From((float[])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else {
				throw new NumpyOperationException("Invalid slice for array specified.");
			}

			return result;
		}


		public NumpyArray<float> Transpose() {
			float[,,,,] result = new float[shape[4], shape[3], shape[2], shape[1], shape[0]];

			for (int d0 = 0; d0 < this.shape[0]; d0++) {
				for (int d1 = 0; d1 < this.shape[1]; d1++) {
					for (int d2 = 0; d2 < this.shape[2]; d2++) {
						for (int d3 = 0; d3 < this.shape[3]; d3++) {
							for (int d4 = 0; d4 < this.shape[4]; d4++) {
								result[d4, d3, d2, d1, d0] = array[d0, d1, d2, d3, d4];

							}
						}
					}
				}
			}

			return NumpyArrayFactory.From(result);
		}
	}
}