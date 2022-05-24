/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
	public class Dim8Int16NumpyWrapper : INumpyArrayWrapper<short>
	{
		private short[,,,,,,,] array;
		private int[] shape;

		public Dim8Int16NumpyWrapper(short[,,,,,,,] array)
		{
			this.array = array;
			this.shape = new[] {array.GetLength(0), array.GetLength(1), array.GetLength(2), array.GetLength(3), array.GetLength(4), array.GetLength(5), array.GetLength(6), array.GetLength(7)};
		}

		public int[] Shape
		{
			get
			{
				return shape;
			}
		}

		public short Get(params int[] indices)
		{
			return array[indices[0], indices[1], indices[2], indices[3], indices[4], indices[5], indices[6], indices[7]];
		}

		public void Set(short value, params int[] indices)
		{
			this.array[indices[0], indices[1], indices[2], indices[3], indices[4], indices[5], indices[6], indices[7]] = value;
		}

		public bool IsFloatingPoint
		{
			get
			{
				return false;
			}
		}


		public int NumberOfBits
		{
			get
			{
				return 16;
			}
		}


		public Object RawArray
		{
			get
			{
				return array;
			}
		}


		public NumpyArray<short> WrapInnerSubsetArray(params int[] indices)
		{
			NumpyArray<short> result = null;

			if (indices.Length == 1) {
				result = NumpyArrayFactory.From((short[,,,,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 2) {
				result = NumpyArrayFactory.From((short[,,,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 3) {
				result = NumpyArrayFactory.From((short[,,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 4) {
				result = NumpyArrayFactory.From((short[,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 5) {
				result = NumpyArrayFactory.From((short[,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 6) {
				result = NumpyArrayFactory.From((short[,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 7) {
				result = NumpyArrayFactory.From((short[])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else {
				throw new NumpyOperationException("Invalid slice for array specified.");
			}

			return result;
		}


		public NumpyArray<short> Transpose() {
			short[,,,,,,,] result = new short[shape[7], shape[6], shape[5], shape[4], shape[3], shape[2], shape[1], shape[0]];

			for (int d0 = 0; d0 < this.shape[0]; d0++) {
				for (int d1 = 0; d1 < this.shape[1]; d1++) {
					for (int d2 = 0; d2 < this.shape[2]; d2++) {
						for (int d3 = 0; d3 < this.shape[3]; d3++) {
							for (int d4 = 0; d4 < this.shape[4]; d4++) {
								for (int d5 = 0; d5 < this.shape[5]; d5++) {
									for (int d6 = 0; d6 < this.shape[6]; d6++) {
										for (int d7 = 0; d7 < this.shape[7]; d7++) {
											result[d7, d6, d5, d4, d3, d2, d1, d0] = array[d0, d1, d2, d3, d4, d5, d6, d7];

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