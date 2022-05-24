/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
	public class Dim1Int16NumpyWrapper : INumpyArrayWrapper<short>
	{
		private short[] array;
		private int[] shape;

		public Dim1Int16NumpyWrapper(short[] array)
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

		public short Get(params int[] indices)
		{
			return array[indices[0]];
		}

		public void Set(short value, params int[] indices)
		{
			this.array[indices[0]] = value;
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
			throw new NumpyOperationException("A single dimension sub array can't be sliced.");
		}


		public NumpyArray<short> Transpose() {
			short[] result = new short[shape[0]];

			for (int d0 = 0; d0 < this.shape[0]; d0++) {
				result[d0] = array[d0];

			}

			return NumpyArrayFactory.From(result);
		}
	}
}