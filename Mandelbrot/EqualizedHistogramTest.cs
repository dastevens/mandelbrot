using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    public class EqualizedHistogramTest
    {
        [Test]
        public void Test()
        {
            var array = new int[2, 1];
            array[0, 0] = 1;
            array[1, 0] = 10;
            var result = EqualizedHistogram.Equalize(array);

            Assert.AreEqual(0, result[0, 0]);
            Assert.AreEqual(255, result[1, 0]);
        }
    }
}
