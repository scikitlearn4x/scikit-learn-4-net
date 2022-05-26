/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
	public class Dim1Int8NumpyWrapper : INumpyArrayWrapper<byte>
	{
		private byte[] array;
		private int[] shape;

		public Dim1Int8NumpyWrapper(byte[] array)
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

		public byte Get(params int[] indices)
		{
			return array[indices[0]];
		}

		public void Set(byte value, params int[] indices)
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
				return 8;
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
				array = (byte[])value;
			}
		}


		public NumpyArray<byte> WrapInnerSubsetArray(params int[] indices)
		{
			throw new NumpyOperationException("A single dimension sub array can't be sliced.");
		}


		public NumpyArray<byte> Transpose() {
			byte[] result = new byte[shape[0]];

			for (int d0 = 0; d0 < this.shape[0]; d0++) {
				result[d0] = array[d0];

			}

			return NumpyArrayFactory.From(result);
		}
	}
}