/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
	public class Dim1Int64NumpyWrapper : INumpyArrayWrapper<long>
	{
		private long[] array;
		private int[] shape;

		public Dim1Int64NumpyWrapper(long[] array)
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

		public long Get(params int[] indices)
		{
			return array[indices[0]];
		}

		public void Set(long value, params int[] indices)
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
				return 64;
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
				array = (long[])value;
			}
		}


		public NumpyArray<long> WrapInnerSubsetArray(params int[] indices)
		{
			throw new NumpyOperationException("A single dimension sub array can't be sliced.");
		}


		public NumpyArray<long> Transpose() {
			long[] result = new long[shape[0]];

			for (int d0 = 0; d0 < this.shape[0]; d0++) {
				result[d0] = array[d0];

			}

			return NumpyArrayFactory.From(result);
		}
	}
}