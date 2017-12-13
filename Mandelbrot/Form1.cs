using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Complex
        {
            public float Imag;
            public float Real;
        }

        class Limits
        {
            public Complex Min;
            public Complex Max;
        }

        Complex Map(int x, int xSize, int y, int ySize, Limits limits)
        {
            return new Complex
            {
                Real = limits.Min.Real + ((float)x / (float)xSize) * (limits.Max.Real - limits.Min.Real),
                Imag = limits.Min.Imag + ((float)y / (float)ySize) * (limits.Max.Imag - limits.Min.Imag),
            };
        }

        Complex Square(Complex a)
        {
            return new Complex
            {
                Real = a.Real * a.Real - a.Imag * a.Imag,
                Imag = 2 * a.Real * a.Imag,
            };
        }

        Complex Cube(Complex a)
        {
            return new Complex
            {
                Real = a.Real * a.Real * a.Real - 3 * a.Real * a.Imag * a.Imag,
                Imag = 3 * a.Real * a.Real * a.Imag - a.Imag * a.Imag * a.Imag
            };
        }

        Complex Add(Complex a, Complex b)
        {
            return new Complex
            {
                Real = a.Real + b.Real,
                Imag = a.Imag + b.Imag,
            };
        }

        float Abs2(Complex a)
        {
            return a.Real * a.Real + a.Imag * a.Imag;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var XSIZE = (int)pixels.Value;
            var YSIZE = (int)pixels.Value;
            var MAX_ITERATIONS = (int)iterations.Value;
            var limits = new Limits
            {
                Min = new Complex { Real = (float)realMin.Value, Imag = (float)imagMin.Value },
                Max = new Complex { Real = (float)realMax.Value, Imag = (float)imagMax.Value },
            };
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
                        if (abs2 > (squareRadioButton.Checked ? 4 : 9))
                        {
                            array[x, y] = i;
                            break;
                        }
                        z_i = Add(squareRadioButton.Checked ? Square(z_i) : Cube(z_i), c);
                    }
                }
                backgroundWorker1.ReportProgress((int)((x + 1) * 50.0 / XSIZE));
            }

            var equalized = EqualizedHistogram.Equalize(array);
            Bitmap bitmap = new Bitmap(XSIZE, YSIZE);
            for (var x = 0; x < XSIZE; x++)
            {
                for (var y = 0; y < YSIZE; y++)
                {
                    var level = equalized[x, y];
                    level = Math.Max(0, level);
                    level = Math.Min(255, level);
                    bitmap.SetPixel(x, y, Color.FromArgb(level, level, level));
                }
                backgroundWorker1.ReportProgress(50 + (int)((x + 1) * 50.0 / XSIZE));
            }
            pictureBox1.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
