using System;
using System.Diagnostics;
using Mandelbrot.Core;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Mandelbrot.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            var mandelbrot = Core.Mandelbrot.Calculate(
                xSize: 1000,
                maxIterations: 100,
                limits: new Limits
                {
                    Min = new Complex
                    {
                        Real = -2.0f,
                        Imag = -1.5f,
                    },
                    Max = new Complex
                    {
                        Real = 1.0f,
                        Imag = 1.5f,
                    },
                },
                iterator: Core.Mandelbrot.Square,
                abs2Limit: 4.0f,
                reportProgress: (progress) => {}
            );
            var bitmap = ImageHelper.CreateImage(
                mandelbrot,
                Color.Black,
                Color.White
            );
            bitmap.SaveAsPng("mandelbrot.png");
            System.Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
