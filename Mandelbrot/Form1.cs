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

        int[,] _mandelbrot;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var limits = new Limits
            {
                Min = new Complex { Real = (float)realMin.Value, Imag = (float)imagMin.Value },
                Max = new Complex { Real = (float)realMax.Value, Imag = (float)imagMax.Value },
            };
            _mandelbrot = Mandelbrot.Calculate((int)pixels.Value, (int)pixels.Value, (int)iterations.Value, limits, a => squareRadioButton.Checked ? Mandelbrot.Square(a) : Mandelbrot.Cube(a), squareRadioButton.Checked ? 4 : 9, progress => backgroundWorker1.ReportProgress(progress));
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

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            backgroundWorker2.RunWorkerAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = color0.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color0.BackColor = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = color255.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color255.BackColor = colorDialog1.Color;
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_mandelbrot == null) return;
            var equalized = EqualizedHistogram.Equalize(_mandelbrot);
            Bitmap bitmap = new Bitmap(_mandelbrot.GetLength(0), _mandelbrot.GetLength(1));
            for (var x = 0; x < _mandelbrot.GetLength(0); x++)
            {
                for (var y = 0; y < _mandelbrot.GetLength(1); y++)
                {
                    if (_mandelbrot[x, y] == 0)
                    {
                        bitmap.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        var level = equalized[x, y];
                        level = Math.Max(0, level);
                        level = Math.Min(255, level);
                        var r = (int)(color0.BackColor.R + (color255.BackColor.R - color0.BackColor.R) * level / 255.0);
                        var g = (int)(color0.BackColor.G + (color255.BackColor.G - color0.BackColor.G) * level / 255.0);
                        var b = (int)(color0.BackColor.B + (color255.BackColor.B - color0.BackColor.B) * level / 255.0);
                        bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
                backgroundWorker2.ReportProgress(((int)((x + 1) * 100.0 / _mandelbrot.GetLength(0))));
            }
            pictureBox1.Image = bitmap;
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private Point RectStartPoint;
        private Rectangle Rect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Determine the initial rectangle coordinates...
            RectStartPoint = e.Location;
            Invalidate();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            Rect.Location = new Point(
                Math.Min(RectStartPoint.X, tempEndPoint.X),
                Math.Min(RectStartPoint.Y, tempEndPoint.Y));
            Rect.Size = new Size(
                Math.Abs(RectStartPoint.X - tempEndPoint.X),
                Math.Abs(RectStartPoint.Y - tempEndPoint.Y));
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Rect.Contains(e.Location))
                {
                    var rMin = GetReal(Rect.X);
                    var rMax = GetReal(Rect.X + Rect.Width);
                    var iMin = GetImag(Rect.Y);
                    var iMax = GetImag(Rect.Y + Rect.Height);

                    realMin.Value = rMin;
                    realMax.Value = rMax;
                    imagMin.Value = iMin;
                    imagMax.Value = iMax;
                    Rect = new Rectangle();
                    Invalidate();
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Draw the rectangle...
            if (pictureBox1.Image != null)
            {
                if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                {
                    e.Graphics.FillRectangle(selectionBrush, Rect);
                }
            }
        }

        private decimal GetReal(int x)
        {
            return ((decimal)x / (decimal)pictureBox1.Size.Width) * (realMax.Value - realMin.Value) + realMin.Value;
        }

        private decimal GetImag(int y)
        {
            return ((decimal)y / (decimal)pictureBox1.Size.Height) * (imagMax.Value - imagMin.Value) + imagMin.Value;
        }
    }
}
