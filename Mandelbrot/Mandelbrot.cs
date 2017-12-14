using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    static class Mandelbrot
    {
        static Complex Map(int x, int xSize, int y, int ySize, Limits limits)
        {
            return new Complex
            {
                Real = limits.Min.Real + ((float)x / (float)xSize) * (limits.Max.Real - limits.Min.Real),
                Imag = limits.Min.Imag + ((float)y / (float)ySize) * (limits.Max.Imag - limits.Min.Imag),
            };
        }

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

        static Complex Add(Complex a, Complex b)
        {
            return new Complex
            {
                Real = a.Real + b.Real,
                Imag = a.Imag + b.Imag,
            };
        }

        static float Abs2(Complex a)
        {
            return a.Real * a.Real + a.Imag * a.Imag;
        }

        static public int[,] Calculate(int xSize, int ySize, int maxIterations, Limits limits, Func<Complex, Complex> iterator, float abs2Limit, Action<int> reportProgress)
        {
            var XSIZE = xSize;
            var YSIZE = ySize;
            var MAX_ITERATIONS = maxIterations;
            var z_0 = new Complex { Real = 0, Imag = 0 };

            var array = new int[XSIZE, YSIZE];
            for (var x = 0; x < XSIZE; x++)
            {
                for (var y = 0; y < YSIZE; y++)
                {
                    var c = Map(x, XSIZE, y, YSIZE, limits);
                    var z_i = z_0;
                    for (var i = 0; i < MAX_ITERATIONS; i++)
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
                reportProgress((int)((x + 1) * 100.0 / XSIZE));
            }
            return array;
        }
    }
}
