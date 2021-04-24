using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Mandelbrot.Core
{
    public static class ImageHelper
    {
        public static Image CreateImage(int[,] mandelbrot, Rgba32 color0, Rgba32 color255)
        {
            var equalized = EqualizedHistogram.Equalize(mandelbrot);
            var bitmap = new Image<Rgba32>(mandelbrot.GetLength(0), mandelbrot.GetLength(1));
            for (var x = 0; x < mandelbrot.GetLength(0); x++)
            {
                for (var y = 0; y < mandelbrot.GetLength(1); y++)
                {
                    if (mandelbrot[x, y] == 0)
                    {
                        bitmap[x, y] = Color.Black;
                    }
                    else
                    {
                        var level = equalized[x, y];
                        level = Math.Max(0, level);
                        level = Math.Min(255, level);
                        var a = (byte)(color0.A + (color255.A - color0.A) * level / 255.0);
                        var r = (byte)(color0.R + (color255.R - color0.R) * level / 255.0);
                        var g = (byte)(color0.G + (color255.G - color0.G) * level / 255.0);
                        var b = (byte)(color0.B + (color255.B - color0.B) * level / 255.0);
                        bitmap[x, y] = new Rgba32(r, g, b, a);
                    }
                }
            }
            return bitmap;
        }
    }
}
