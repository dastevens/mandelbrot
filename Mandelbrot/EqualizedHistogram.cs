using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    class EqualizedHistogram
    {
        private int[] _bins = new int[256];
        public EqualizedHistogram(int[,] array)
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
            var countPerBin = array.GetLength(0) * array.GetLength(1) / 256.0;
            var cumulative = 0;
            var binIndex = 0;
            foreach (var level in histogram.Keys.OrderBy(level => level))
            {
                var countForLevel = histogram[level];
                cumulative += countForLevel;
                while (cumulative / countPerBin > (binIndex + 1))
                {
                    _bins[binIndex] = level;
                    binIndex++;
                }
            }
        }

        public int GetLevel(int level)
        {
            var result = _bins
                .Select((bin, binLevel) => new { index = binLevel, arrayLevel = bin })
                .FirstOrDefault(bin => bin.arrayLevel >= level);
            return result != null ? result.index : 0;
        }
    }
}
