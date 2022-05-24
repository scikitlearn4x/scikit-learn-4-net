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

            NumpyArrayOperationWithAxisReduction<double, double> reduction =
                new NumpyArrayOperationWithAxisReduction<double, double>(reducer);
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

            NumpyArrayOperationWithAxisReduction<float, float> reduction =
                new NumpyArrayOperationWithAxisReduction<float, float>(reducer);
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

            NumpyArrayOperationWithAxisReduction<long, long> reduction =
                new NumpyArrayOperationWithAxisReduction<long, long>(reducer);
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
    }
}