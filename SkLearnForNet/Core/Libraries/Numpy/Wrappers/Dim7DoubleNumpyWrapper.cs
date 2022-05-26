/*
 * This file was automatically generated, don't edit it manually.
 */

using System;

namespace SkLearn.Core.Libraries.Numpy.Wrappers
{
	public class Dim7DoubleNumpyWrapper : INumpyArrayWrapper<double>
	{
		private double[,,,,,,] array;
		private int[] shape;

		public Dim7DoubleNumpyWrapper(double[,,,,,,] array)
		{
			this.array = array;
			this.shape = new[] {array.GetLength(0), array.GetLength(1), array.GetLength(2), array.GetLength(3), array.GetLength(4), array.GetLength(5), array.GetLength(6)};
		}

		public int[] Shape
		{
			get
			{
				return shape;
			}
		}

		public double Get(params int[] indices)
		{
			return array[indices[0], indices[1], indices[2], indices[3], indices[4], indices[5], indices[6]];
		}

		public void Set(double value, params int[] indices)
		{
			this.array[indices[0], indices[1], indices[2], indices[3], indices[4], indices[5], indices[6]] = value;
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
				array = (double[,,,,,,])value;
			}
		}


		public NumpyArray<double> WrapInnerSubsetArray(params int[] indices)
		{
			NumpyArray<double> result = null;

			if (indices.Length == 1) {
				result = NumpyArrayFactory.From((double[,,,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 2) {
				result = NumpyArrayFactory.From((double[,,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 3) {
				result = NumpyArrayFactory.From((double[,,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 4) {
				result = NumpyArrayFactory.From((double[,,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 5) {
				result = NumpyArrayFactory.From((double[,])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else if (indices.Length == 6) {
				result = NumpyArrayFactory.From((double[])NumpyArrayFactory.WrapInnerSubsetArray(array, indices));
			} else {
				throw new NumpyOperationException("Invalid slice for array specified.");
			}

			return result;
		}


		public NumpyArray<double> Transpose() {
			double[,,,,,,] result = new double[shape[6], shape[5], shape[4], shape[3], shape[2], shape[1], shape[0]];

			for (int d0 = 0; d0 < this.shape[0]; d0++) {
				for (int d1 = 0; d1 < this.shape[1]; d1++) {
					for (int d2 = 0; d2 < this.shape[2]; d2++) {
						for (int d3 = 0; d3 < this.shape[3]; d3++) {
							for (int d4 = 0; d4 < this.shape[4]; d4++) {
								for (int d5 = 0; d5 < this.shape[5]; d5++) {
									for (int d6 = 0; d6 < this.shape[6]; d6++) {
										result[d6, d5, d4, d3, d2, d1, d0] = array[d0, d1, d2, d3, d4, d5, d6];

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