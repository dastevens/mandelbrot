using System.Collections.Generic;
using System.Linq;

namespace Mandelbrot.Core
{
    static class EqualizedHistogram
    {
        public static int[,] Equalize(int[,] array)
        {
            var histogram = new Dictionary<int, int>();
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    var level = array[i, j];
                    if (!histogram.ContainsKey(level))
                    {
                        histogram[level] = 1;
                    }
                    else
                    {
                        histogram[level]++;
                    }
                }
            }
            var levels = new Dictionary<int, int>();
            var countPerBin = array.GetLength(0) * array.GetLength(1) / 256.0;
            var cumulative = 0.0;
            var first = true;
            foreach (var level in histogram.Keys.OrderBy(level => level))
            {
                var countForLevel = histogram[level];
                if (first)
                {
                    first = false;
                }
                else
                {
                    cumulative += 0.5 * countForLevel;
                }
                levels[level] = (int)(cumulative / countPerBin);
                cumulative += 0.5 * countForLevel;
            }
            var result = new int[array.GetLength(0), array.GetLength(1)];
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    result[i, j] = levels[array[i, j]];
                }
            }
            return result;
        }
    }
}
