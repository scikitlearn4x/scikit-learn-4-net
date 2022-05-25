using System;
using System.CodeDom;
using SkLearn.Core.Libraries.Numpy.Wrappers;

namespace SkLearn.Core.Libraries.Numpy
{
    public class Numpy
    {
        public static NumpyArray<double> Sum(NumpyArray<double> array, int axis)
        {
            var reducer = new NumpyReduceAxisFunction<double, double>((values) =>
            {
                double result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<double, double> reduction = new NumpyArrayOperationWithAxisReduction<double, double>(reducer);
            return reduction.Apply(array, axis);
        }

        public static NumpyArray<float> Sum(NumpyArray<float> array, int axis)
        {
            var reducer = new NumpyReduceAxisFunction<float, float>((values) =>
            {
                float result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<float, float> reduction = new NumpyArrayOperationWithAxisReduction<float, float>(reducer);
            return reduction.Apply(array, axis);
        }

        public static NumpyArray<long> Sum(NumpyArray<long> array, int axis)
        {
            var reducer = new NumpyReduceAxisFunction<long, long>((values) =>
            {
                long result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<long, long> reduction = new NumpyArrayOperationWithAxisReduction<long, long>(reducer);
            return reduction.Apply(array, axis);
        }

        public static NumpyArray<int> Sum(NumpyArray<int> array, int axis)
        {
            var reducer = new NumpyReduceAxisFunction<int, int>((values) =>
            {
                int result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<int, int> reduction = new NumpyArrayOperationWithAxisReduction<int, int>(reducer);
            return reduction.Apply(array, axis);
        }

        public static NumpyArray<int> Sum(NumpyArray<short> array, int axis)
        {
            var reducer = new NumpyReduceAxisFunction<short, int>((values) =>
            {
                int result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<short, int> reduction = new NumpyArrayOperationWithAxisReduction<short, int>(reducer);
            return reduction.Apply(array, axis);
        }

        public static NumpyArray<int> Sum(NumpyArray<byte> array, int axis)
        {
            var reducer = new NumpyReduceAxisFunction<byte, int>((values) =>
            {
                int result = 0;

                foreach (var element in values)
                {
                    result += element;
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<byte, int> reduction = new NumpyArrayOperationWithAxisReduction<byte, int>(reducer);
            return reduction.Apply(array, axis);
        }

        public static NumpyArray<long> Argmax(NumpyArray<double> array, int axis)
        {
            var reducer = new NumpyReduceAxisFunction<double, long>((values) =>
            {
                long result = 0;
                double max = values[0];

                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i] > max)
                    {
                        result = i;
                        max = values[i];
                    }
                }

                return result;
            });

            NumpyArrayOperationWithAxisReduction<double, long> reduction = new NumpyArrayOperationWithAxisReduction<double, long>(reducer);
            return reduction.Apply(array, axis);
        }

        /// <summary>
        /// Calculate the exponential of all elements in the input array.
        /// https://numpy.org/doc/stable/reference/generated/numpy.exp.html
        /// <param name="array">Input values.</param>
        /// <returns>Output array, element-wise exponential of x.</returns>
        /// </summary>
        public static NumpyArray<double> Exp(NumpyArray<double> array)
        {
            NumpyArray<double> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<double>(true, NumpyArrayFactory.SIZE_OF_DOUBLE, array.Shape);

            array.ApplyToEachElementAnsSaveToTarget(result, value => Math.Exp(value));

            return result;
        }

        /// <summary>
        /// Natural logarithm, element-wise.
        /// 
        /// The natural logarithm log is the inverse of the exponential function, so that
        /// log(exp(x)) = x. The natural logarithm is logarithm in base e.
        /// <param name="array">Input values.</param>
        /// <returns>Output array, element-wise log of x.</returns>
        /// </summary>
        public static NumpyArray<Double> Log(NumpyArray<double> array)
        {
            NumpyArray<Double> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<double>(true, NumpyArrayFactory.SIZE_OF_DOUBLE, array.Shape);

            array.ApplyToEachElementAnsSaveToTarget(result, value => Math.Log(value));

            return result;
        }

        public static NumpyArray<double> AtLeast2D(double value)
        {
            NumpyArray<double> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<double>(true, NumpyArrayFactory.SIZE_OF_DOUBLE, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        public static NumpyArray<float> AtLeast2D(float value)
        {
            NumpyArray<float> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<float>(true, NumpyArrayFactory.SIZE_OF_FLOAT, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        public static NumpyArray<long> AtLeast2D(long value)
        {
            NumpyArray<long> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<long>(false, NumpyArrayFactory.SIZE_OF_INT_64, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        public static NumpyArray<int> AtLeast2D(int value)
        {
            NumpyArray<int> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<int>(false, NumpyArrayFactory.SIZE_OF_INT_32, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        public static NumpyArray<short> AtLeast2D(short value)
        {
            NumpyArray<short> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<short>(false, NumpyArrayFactory.SIZE_OF_INT_16, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        public static NumpyArray<byte> AtLeast2D(byte value)
        {
            NumpyArray<byte> result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<byte>(false, NumpyArrayFactory.SIZE_OF_INT_8, new int[] { 1, 1 });
            result.Set(value, 0, 0);

            return result;
        }

        public static NumpyArray<ElementType> AtLeast2D<ElementType>(NumpyArray<ElementType> array) where ElementType : struct
        {
            // https://github.com/numpy/numpy/blob/v1.22.0/numpy/core/shape_base.py#L81-L132
            NumpyArray<ElementType> result = null;

            if (array.NumberOfDimensions == 1)
            {
                result = NumpyArrayFactory.CreateArrayOfShapeAndTypeInfo<ElementType>(array.IsFloatingPoint, array.NumberOfBytes, new int[] { 1, array.Shape[0] });
                for (int i = 0; i < array.Shape[0]; i++)
                {
                    result.Set(array.Get(i), 0, i);
                }
            }
            else if (array.NumberOfDimensions > 1)
            {
                result = array;
            }
            else
            {
                throw new NumpyOperationException("The input for AtLeast2D is invalid");
            }

            return result;
        }

        public static NumpyArray<double> AsDoubleArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(double), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToDouble(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<double> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1DoubleNumpyWrapper((double[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2DoubleNumpyWrapper((double[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3DoubleNumpyWrapper((double[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4DoubleNumpyWrapper((double[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5DoubleNumpyWrapper((double[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6DoubleNumpyWrapper((double[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7DoubleNumpyWrapper((double[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8DoubleNumpyWrapper((double[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9DoubleNumpyWrapper((double[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10DoubleNumpyWrapper((double[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<double>(wrapper);
        }

        public static NumpyArray<float> AsFloatArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(float), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, array.Shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToSingle(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<float> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1FloatNumpyWrapper((float[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2FloatNumpyWrapper((float[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3FloatNumpyWrapper((float[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4FloatNumpyWrapper((float[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5FloatNumpyWrapper((float[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6FloatNumpyWrapper((float[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7FloatNumpyWrapper((float[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8FloatNumpyWrapper((float[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9FloatNumpyWrapper((float[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10FloatNumpyWrapper((float[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<float>(wrapper);
        }

        public static NumpyArray<long> AsLongArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(long), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToInt64(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<long> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1Int64NumpyWrapper((long[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2Int64NumpyWrapper((long[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3Int64NumpyWrapper((long[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4Int64NumpyWrapper((long[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5Int64NumpyWrapper((long[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6Int64NumpyWrapper((long[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7Int64NumpyWrapper((long[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8Int64NumpyWrapper((long[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9Int64NumpyWrapper((long[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10Int64NumpyWrapper((long[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<long>(wrapper);
        }

        public static NumpyArray<int> AsIntegerArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(int), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToInt32(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<int> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1Int32NumpyWrapper((int[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2Int32NumpyWrapper((int[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3Int32NumpyWrapper((int[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4Int32NumpyWrapper((int[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5Int32NumpyWrapper((int[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6Int32NumpyWrapper((int[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7Int32NumpyWrapper((int[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8Int32NumpyWrapper((int[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9Int32NumpyWrapper((int[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10Int32NumpyWrapper((int[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<int>(wrapper);
        }

        public static NumpyArray<short> AsShortArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(short), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToInt16(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<short> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1Int16NumpyWrapper((short[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2Int16NumpyWrapper((short[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3Int16NumpyWrapper((short[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4Int16NumpyWrapper((short[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5Int16NumpyWrapper((short[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6Int16NumpyWrapper((short[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7Int16NumpyWrapper((short[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8Int16NumpyWrapper((short[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9Int16NumpyWrapper((short[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10Int16NumpyWrapper((short[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<short>(wrapper);
        }

        public static NumpyArray<byte> AsByteArray<Type>(NumpyArray<Type> array) where Type : struct
        {
            Array newArray = Array.CreateInstance(typeof(byte), array.Shape);

            int[] shape = array.Shape;
            int[] index = new int[shape.Length];
            int[] counter = new int[shape.Length + 1];
            counter[0] = -1;

            do
            {
                NumpyArray<Type>.AddCounter(counter, shape);

                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = counter[i];
                }

                newArray.SetValue(Convert.ToByte(array.Get(index)), index);
            } while (counter[counter.Length - 1] == 0);

            INumpyArrayWrapper<byte> wrapper = null;
            switch (array.NumberOfDimensions)
            {
                case 1:
                    wrapper = new Dim1Int8NumpyWrapper((byte[])newArray);
                    break;
                case 2:
                    wrapper = new Dim2Int8NumpyWrapper((byte[,])newArray);
                    break;
                case 3:
                    wrapper = new Dim3Int8NumpyWrapper((byte[,,])newArray);
                    break;
                case 4:
                    wrapper = new Dim4Int8NumpyWrapper((byte[,,,])newArray);
                    break;
                case 5:
                    wrapper = new Dim5Int8NumpyWrapper((byte[,,,,])newArray);
                    break;
                case 6:
                    wrapper = new Dim6Int8NumpyWrapper((byte[,,,,,])newArray);
                    break;
                case 7:
                    wrapper = new Dim7Int8NumpyWrapper((byte[,,,,,,])newArray);
                    break;
                case 8:
                    wrapper = new Dim8Int8NumpyWrapper((byte[,,,,,,,])newArray);
                    break;
                case 9:
                    wrapper = new Dim9Int8NumpyWrapper((byte[,,,,,,,,])newArray);
                    break;
                case 10:
                    wrapper = new Dim10Int8NumpyWrapper((byte[,,,,,,,,,])newArray);
                    break;
            }

            return new NumpyArray<byte>(wrapper);
        }

        public static Object AsArrayOfType<Type>(NumpyArray<Type> array, bool isFloatingPoint, int size) where Type : struct
        {
            if (isFloatingPoint)
            {
                if (size == 4)
                {
                    return AsFloatArray(array);
                }
                else if (size == 8)
                {
                    return AsDoubleArray(array);
                }
            }
            else
            {
                if (size == 8)
                {
                    return AsLongArray(array);
                }
                else if (size == 4)
                {
                    return AsIntegerArray(array);
                }
                else if (size == 2)
                {
                    return AsShortArray(array);
                }
                else if (size == 1)
                {
                    return AsByteArray(array);
                }
            }

            throw new NotImplementedException();
        }


        /// <summary>
        /// Gets the effective shape of the array. The effective shape is defined as the number of dimensions
        /// on the left that is followed only by ones.
        /// 
        /// Example:
        /// (2, 2) => (2, 2): Will return 2
        /// (1, 4) => (1, 4): Will return 2
        /// (3, 5, 1, 1) => (3, 5): Will return 2
        /// <param name="shape">Shape to evaluate the effective dimensions.</param>
        /// <returns>Number of effective dimensions.</returns>
        /// </summary>
        private static int GetEffectiveShapeWithRemovingEndingDimensions(int[] shape)
        {
            int lastOnes = 0;

            for (int i = 0; i < shape.Length; i++)
            {
                if (shape[shape.Length - i - 1] == 1)
                {
                    lastOnes++;
                }
                else
                {
                    break;
                }
            }

            return shape.Length - lastOnes;
        }

        /// <summary>
        /// Checks if two numpy arrays with the given dimensions could be added. If they are incompatible,
        /// an exception is thrown.
        /// <param name="shape1">Shape of the array on the left hand-side.</param>
        /// <param name="shape2">Shape of the array on the right hand-side.
        /// </param>
        /// </summary>
        private static void ValidateDimensionsForAdd(int[] shape1, int[] shape2)
        {
            int effective1 = GetEffectiveShapeWithRemovingEndingDimensions(shape1);
            int effective2 = GetEffectiveShapeWithRemovingEndingDimensions(shape2);

            if (effective2 == 0)
            {
                // This is the case where a single number is added to NumpyArray. 
                return;
            }

            if (effective1 != effective2 && Math.Abs(effective2 - effective1) != 1)
            {
                throw new NumpyOperationException("The effective shape of the two numpy array has different number of dimensions.");
            }

            for (int i = 0; i < effective1; i++)
            {
                if (shape1[i] != shape2[i] && (shape1[i] != 1 && shape2[i] != 1))
                {
                    throw new NumpyOperationException($"Dimension {i + 1} of the two numpy arrays doesn't match.");
                }
            }
        }

        /// <summary>
        /// To ease the add implementation, the code assumes that the array with higher dimensions is
        /// on the left-hand side. In case it is not provided in this format, it should be swapped. This
        /// function checks if it is the case or not.
        /// <param name="a1">Array on the left hand-side of the addition.</param>
        /// <param name="a2">Array on the right hand-side of the addition.</param>
        /// <returns>A boolean indicating if the values should be swapped or not.</returns>
        /// </summary>
        private static bool ShouldSwapForAdd<InputType1, InputType2>(NumpyArray<InputType1> a1, NumpyArray<InputType2> a2) where InputType1 : struct where InputType2 : struct
        {
            bool result = false;
            int[] s1 = a1.Shape;
            int[] s2 = a2.Shape;

            if (GetEffectiveShapeWithRemovingEndingDimensions(s1) < GetEffectiveShapeWithRemovingEndingDimensions(s2))
            {
                result = true;
            }

            return result;
        }


        public static NumpyArray<OutputType> Add<InputType1, InputType2, OutputType>(NumpyArray<InputType1> a1, NumpyArray<InputType2> a2) where InputType1 : struct where InputType2 : struct where OutputType : struct
        {
            int sign = 1;
            return AddNumpyArraysWithSign<InputType1, InputType2, OutputType>(a1, a2, sign);
        }

        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, byte value) where InputType : struct where OutputType : struct
        {
            NumpyArray<byte> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, byte, OutputType>(a1, asArray);
        }

        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, short value) where InputType : struct where OutputType : struct
        {
            NumpyArray<short> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, short, OutputType>(a1, asArray);
        }

        public static NumpyArray<OutputType> Subtract<InputType, OutputType>(NumpyArray<InputType> a1, short value) where InputType : struct where OutputType : struct
        {
            NumpyArray<short> asArray = NumpyArrayFactory.From(new[] { (short)-value });
            return Add<InputType, short, OutputType>(a1, asArray);
        }

        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, int value) where InputType : struct where OutputType : struct
        {
            NumpyArray<int> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, int, OutputType>(a1, asArray);
        }

        public static NumpyArray<OutputType> Subtract<InputType, OutputType>(NumpyArray<InputType> a1, int value) where InputType : struct where OutputType : struct
        {
            NumpyArray<int> asArray = NumpyArrayFactory.From(new[] { (int)-value });
            return Add<InputType, int, OutputType>(a1, asArray);
        }

        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, long value) where InputType : struct where OutputType : struct
        {
            NumpyArray<long> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, long, OutputType>(a1, asArray);
        }

        public static NumpyArray<OutputType> Subtract<InputType, OutputType>(NumpyArray<InputType> a1, long value) where InputType : struct where OutputType : struct
        {
            NumpyArray<long> asArray = NumpyArrayFactory.From(new[] { -value });
            return Add<InputType, long, OutputType>(a1, asArray);
        }

        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, float value) where InputType : struct where OutputType : struct
        {
            NumpyArray<float> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, float, OutputType>(a1, asArray);
        }

        public static NumpyArray<OutputType> Subtract<InputType, OutputType>(NumpyArray<InputType> a1, float value) where InputType : struct where OutputType : struct
        {
            NumpyArray<float> asArray = NumpyArrayFactory.From(new[] { -value });
            return Add<InputType, float, OutputType>(a1, asArray);
        }

        public static NumpyArray<OutputType> Add<InputType, OutputType>(NumpyArray<InputType> a1, double value) where InputType : struct where OutputType : struct
        {
            NumpyArray<double> asArray = NumpyArrayFactory.From(new[] { value });
            return Add<InputType, double, OutputType>(a1, asArray);
        }

        public static NumpyArray<OutputType> Subtract<InputType, OutputType>(NumpyArray<InputType> a1, double value) where InputType : struct where OutputType : struct
        {
            NumpyArray<double> asArray = NumpyArrayFactory.From(new[] { -value });
            return Add<InputType, double, OutputType>(a1, asArray);
        }

        private static NumpyArray<OutputType> AddNumpyArraysWithSign<InputType1, InputType2, OutputType>(NumpyArray<InputType1> a1, NumpyArray<InputType2> a2, int sign) where InputType1 : struct where InputType2 : struct where OutputType : struct
        {
            ValidateDimensionsForAdd(a1.Shape, a2.Shape);
            if (ShouldSwapForAdd(a1, a2))
            {
                return Add<InputType2, InputType1, OutputType>(a2, a1);
            }

            bool isFloatingPoint = a1.IsFloatingPoint || a2.IsFloatingPoint;
            int size = Math.Max(a1.NumberOfBytes, a2.NumberOfBytes);

            if (!a1.IsFloatingPoint)
            {
                size = a2.NumberOfBytes;
            }
            else if (!a2.IsFloatingPoint)
            {
                size = a1.NumberOfBytes;
            }

            Object result = null;
            if (isFloatingPoint)
            {
                NumpyArray<double> da1 = AsDoubleArray(a1);
                NumpyArray<double> da2 = AsDoubleArray(a2);
                NumpyArray<double> temp = NumpyArrayFactory.ArrayOfDoubleWithShape(a1.Shape);

                AddInPlace(new int[0], temp, da1, da2, sign);
                result = AsArrayOfType(temp, true, size);
            }
            else
            {
                NumpyArray<long> da1 = AsLongArray(a1);
                NumpyArray<long> da2 = AsLongArray(a2);
                NumpyArray<long> temp = NumpyArrayFactory.ArrayOfInt64WithShape(a1.Shape);

                AddInPlace(new int[0], temp, da1, da2, sign);
                result = AsArrayOfType(temp, false, size);
            }

            return (NumpyArray<OutputType>)result;
        }

        public static NumpyArray<OutputType> Subtract<InputType1, InputType2, OutputType>(NumpyArray<InputType1> a1, NumpyArray<InputType2> a2) where InputType1 : struct where InputType2 : struct where OutputType : struct
        {
            int sign = -1;
            return AddNumpyArraysWithSign<InputType1, InputType2, OutputType>(a1, a2, sign);
        }

        private static void AddInPlace(int[] targetBaseIndex, NumpyArray<double> target, NumpyArray<double> a1, NumpyArray<double> a2, int sign)
        {
            if (a2.IsSingleValueArray())
            {
                double singleValue = a2.GetSingleValue();

                AddInPlace(targetBaseIndex, target, a1, singleValue * sign);
            }
            else if (a1.NumberOfDimensions == 1 && a2.NumberOfDimensions == 1)
            {
                int firstDim = a1.Shape[0];
                double value = 0;
                int[] targetIndex = new int[target.NumberOfDimensions];
                for (int i = 0; i < targetBaseIndex.Length; i++)
                {
                    targetIndex[i] = targetBaseIndex[i];
                }

                for (int i = 0; i < firstDim; i++)
                {
                    value = a1.Get(i) + sign * a2.Get(i);
                    targetIndex[targetIndex.Length - 1] = i;
                    target.Set(value, targetIndex);
                }
            }
            else
            {
                int firstDim = target.Shape[0];

                int[] newTargetBaseIndex = new int[targetBaseIndex.Length + 1];
                for (int i = 0; i < targetBaseIndex.Length; i++)
                {
                    newTargetBaseIndex[i] = targetBaseIndex[i];
                }

                for (int i = 0; i < firstDim; i++)
                {
                    newTargetBaseIndex[newTargetBaseIndex.Length - 1] = i;
                    AddInPlace(newTargetBaseIndex, target, a1.WrapInnerSubsetArray(i), a2.WrapInnerSubsetArray(i), sign);
                }
            }
        }

        private static void AddInPlace(int[] targetBaseIndex, NumpyArray<double> target, NumpyArray<double> array, double value)
        {
            int[] targetIndex = new int[target.NumberOfDimensions];
            for (int i = 0; i < targetBaseIndex.Length; i++)
            {
                targetIndex[i] = targetBaseIndex[i];
            }

            array.IterateOnEachElement((element, currentIndex) =>
            {
                for (int i = 0; i < currentIndex.Length; i++)
                {
                    targetIndex[targetBaseIndex.Length + i] = currentIndex[i];
                }

                target.Set(value + element, targetIndex);
            });
        }

        private static void AddInPlace(int[] targetBaseIndex, NumpyArray<long> target, NumpyArray<long> a1, NumpyArray<long> a2, int sign)
        {
            if (a2.IsSingleValueArray())
            {
                long singleValue = a2.GetSingleValue();

                AddInPlace(targetBaseIndex, target, a1, singleValue * sign);
            }
            else if (a1.NumberOfDimensions == 1 && a2.NumberOfDimensions == 1)
            {
                int firstDim = a1.Shape[0];
                long value = 0;
                int[] targetIndex = new int[target.NumberOfDimensions];
                for (int i = 0; i < targetBaseIndex.Length; i++)
                {
                    targetIndex[i] = targetBaseIndex[i];
                }

                for (int i = 0; i < firstDim; i++)
                {
                    value = a1.Get(i) + sign * a2.Get(i);
                    targetIndex[targetIndex.Length - 1] = i;
                    target.Set(value, targetIndex);
                }
            }
            else
            {
                int firstDim = target.Shape[0];

                int[] newTargetBaseIndex = new int[targetBaseIndex.Length + 1];
                for (int i = 0; i < targetBaseIndex.Length; i++)
                {
                    newTargetBaseIndex[i] = targetBaseIndex[i];
                }

                for (int i = 0; i < firstDim; i++)
                {
                    newTargetBaseIndex[newTargetBaseIndex.Length - 1] = i;
                    AddInPlace(newTargetBaseIndex, target, a1.WrapInnerSubsetArray(i), a2.WrapInnerSubsetArray(i), sign);
                }
            }
        }

        private static void AddInPlace(int[] targetBaseIndex, NumpyArray<long> target, NumpyArray<long> array, long value)
        {
            int[] targetIndex = new int[target.NumberOfDimensions];
            for (int i = 0; i < targetBaseIndex.Length; i++)
            {
                targetIndex[i] = targetBaseIndex[i];
            }

            array.IterateOnEachElement((element, currentIndex) =>
            {
                for (int i = 0; i < currentIndex.Length; i++)
                {
                    targetIndex[targetBaseIndex.Length + i] = currentIndex[i];
                }

                target.Set(value + element, targetIndex);
            });
        }

        private static void UpdateLayoutInfoForMultiplication(Type type, ref int size, ref bool floatingPoint)
        {
            if (floatingPoint || type == typeof(float) || type == typeof(double))
            {
                floatingPoint = true;
                if (type == typeof(double))
                {
                    size = NumpyArrayFactory.SIZE_OF_DOUBLE;
                }
            }
            else
            {
                if (type == typeof(long)) size = NumpyArrayFactory.SIZE_OF_INT_64;
                if (type == typeof(int)) size = Math.Max(NumpyArrayFactory.SIZE_OF_INT_32, size);
                if (type == typeof(short)) size = Math.Max(NumpyArrayFactory.SIZE_OF_INT_16, size);
                if (type == typeof(byte)) size = Math.Max(NumpyArrayFactory.SIZE_OF_INT_8, size);
            }
        }

        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, byte value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_INT_8;
            bool floatingPoint = false;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, short value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_INT_16;
            bool floatingPoint = false;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, int value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_INT_32;
            bool floatingPoint = false;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, long value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_INT_64;
            bool floatingPoint = false;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, float value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_FLOAT;
            bool floatingPoint = true;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        public static NumpyArray<OutputType> Multiply<InputType, OutputType>(NumpyArray<InputType> numpyArray, double value) where InputType : struct where OutputType : struct
        {
            int size = NumpyArrayFactory.SIZE_OF_DOUBLE;
            bool floatingPoint = true;

            UpdateLayoutInfoForMultiplication(typeof(InputType), ref size, ref floatingPoint);

            return MultiplyNumpyArrayByNumber<InputType, OutputType>(numpyArray, value, floatingPoint, size);
        }

        private static NumpyArray<OutputType> MultiplyNumpyArrayByNumber<InputType, OutputType>(NumpyArray<InputType> numpyArray, double value, bool floatingPoint, int size) where InputType : struct where OutputType : struct
        {
            Object result = null;
            if (floatingPoint)
            {
                NumpyArray<double> temp = NumpyArrayFactory.ArrayOfDoubleWithShape(numpyArray.Shape);
                numpyArray.IterateOnEachElement((element, index) =>
                {
                    double e = Convert.ToDouble(element) * value;
                    temp.Set(e, index);
                });

                result = AsArrayOfType(temp, true, size);
            }
            else
            {
                NumpyArray<long> temp = NumpyArrayFactory.ArrayOfInt64WithShape(numpyArray.Shape);
                long coeff = (long)value;
                numpyArray.IterateOnEachElement((element, index) =>
                {
                    long e = Convert.ToInt64(element) * coeff;
                    temp.Set(e, index);
                });

                result = AsArrayOfType(temp, false, size);
            }

            return (NumpyArray<OutputType>)result;
        }

        public static NumpyArray<double> Divide(NumpyArray<double> numpyArray, long value)
        {
            return Multiply<double, double>(numpyArray, 1.0 / value);
        }

        public static NumpyArray<double> Divide(NumpyArray<double> numpyArray, double value)
        {
            return Multiply<double, double>(numpyArray, 1.0 / value);
        }

        public static NumpyArray<float> Divide(NumpyArray<float> numpyArray, long value)
        {
            return Multiply<float, float>(numpyArray, 1.0f / value);
        }

        public static NumpyArray<float> Divide(NumpyArray<float> numpyArray, float value)
        {
            return Multiply<float, float>(numpyArray, 1.0f / value);
        }

        public static NumpyArray<double> Divide(NumpyArray<float> numpyArray, double value)
        {
            return Multiply<float, double>(numpyArray, 1.0 / value);
        }
    }
}