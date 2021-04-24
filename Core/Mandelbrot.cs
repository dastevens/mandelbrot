using System;

namespace Mandelbrot.Core
{
    public static class Mandelbrot
    {
        public static Complex Square(Complex a)
        {
            return new Complex
            {
                Real = a.Real * a.Real - a.Imag * a.Imag,
                Imag = 2 * a.Real * a.Imag,
            };
        }

        public static Complex Cube(Complex a)
        {
            return new Complex
            {
                Real = a.Real * a.Real * a.Real - 3 * a.Real * a.Imag * a.Imag,
                Imag = 3 * a.Real * a.Real * a.Imag - a.Imag * a.Imag * a.Imag
            };
        }

        public static int[,] Calculate(
            int xSize,
            int maxIterations,
            Limits limits,
            Func<Complex, Complex> iterator,
            float abs2Limit,
            Action<int> reportProgress)
        {
            var aspectRatio = (limits.Max.Real - limits.Min.Real) / (limits.Max.Imag - limits.Min.Imag);
            int ySize = (int)((float)xSize / aspectRatio);
            return Calculate(xSize, ySize, maxIterations, limits, iterator, abs2Limit, reportProgress);
        }

        public static int[,] Calculate(
            int xSize,
            int ySize,
            int maxIterations,
            Limits limits,
            Func<Complex, Complex> iterator,
            float abs2Limit,
            Action<int> reportProgress)
        {
            var z_0 = new Complex { Real = 0, Imag = 0 };

            var array = new int[xSize, ySize];
            for (var x = 0; x < xSize; x++)
            {
                for (var y = 0; y < ySize; y++)
                {
                    var c = Map(x, xSize, y, ySize, limits);
                    var z_i = z_0;
                    for (var i = 0; i < maxIterations; i++)
                    {
                        var abs2 = Abs2(z_i);
                        if (abs2 > abs2Limit)
                        {
                            array[x, y] = i;
                            break;
                        }
                        z_i = Add(iterator(z_i), c);
                    }
                }
                reportProgress((int)((x + 1) * 100.0 / xSize));
            }
            return array;
        }

        private static Complex Map(int x, int xSize, int y, int ySize, Limits limits)
        {
            return new Complex
            {
                Real = limits.Min.Real + ((float)x / (float)xSize) * (limits.Max.Real - limits.Min.Real),
                Imag = limits.Min.Imag + ((float)y / (float)ySize) * (limits.Max.Imag - limits.Min.Imag),
            };
        }

        private static Complex Add(Complex a, Complex b)
        {
            return new Complex
            {
                Real = a.Real + b.Real,
                Imag = a.Imag + b.Imag,
            };
        }

        private static float Abs2(Complex a)
        {
            return a.Real * a.Real + a.Imag * a.Imag;
        }
    }
}
