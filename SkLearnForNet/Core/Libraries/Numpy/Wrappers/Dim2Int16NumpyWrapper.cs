/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
	public class Dim2Int16NumpyWrapper : INumpyArrayWrapper<short>
	{
		private short[,] array;
		private int[] shape;

		public Dim2Int16NumpyWrapper(short[,] array)
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

		public short Get(params int[] indices)
		{
			return array[indices[0], indices[1]];
		}

		public void Set(short value, params int[] indices)
		{
			this.array[indices[0], indices[1]] = value;
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
				result = NumpyArrayFactory.From((short[])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else {
				throw new NumpyOperationException("Invalid slice for array specified.");
			}

			return result;
		}


		public NumpyArray<short> Transpose() {
			short[,] result = new short[shape[1], shape[0]];

			for (int d0 = 0; d0 < this.shape[0]; d0++) {
				for (int d1 = 0; d1 < this.shape[1]; d1++) {
					result[d1, d0] = array[d0, d1];

				}
			}

			return NumpyArrayFactory.From(result);
		}
	}
}