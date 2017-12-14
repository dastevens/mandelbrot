namespace Mandelbrot
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.color255 = new System.Windows.Forms.Button();
            this.color0 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cubeRadioButton = new System.Windows.Forms.RadioButton();
            this.squareRadioButton = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.iterations = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pixels = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.imagMax = new System.Windows.Forms.NumericUpDown();
            this.imagMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.realMax = new System.Windows.Forms.NumericUpDown();
            this.realMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realMin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.color255);
            this.splitContainer1.Panel1.Controls.Add(this.color0);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.cubeRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.squareRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.iterations);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.pixels);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.imagMax);
            this.splitContainer1.Panel1.Controls.Add(this.imagMin);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.realMax);
            this.splitContainer1.Panel1.Controls.Add(this.realMin);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(526, 497);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 1;
            // 
            // color255
            // 
            this.color255.BackColor = System.Drawing.Color.White;
            this.color255.Location = new System.Drawing.Point(96, 280);
            this.color255.Name = "color255";
            this.color255.Size = new System.Drawing.Size(75, 48);
            this.color255.TabIndex = 18;
            this.color255.UseVisualStyleBackColor = false;
            this.color255.Click += new System.EventHandler(this.button5_Click);
            // 
            // color0
            // 
            this.color0.BackColor = System.Drawing.Color.Black;
            this.color0.Location = new System.Drawing.Point(12, 280);
            this.color0.Name = "color0";
            this.color0.Size = new System.Drawing.Size(75, 48);
            this.color0.TabIndex = 17;
            this.color0.UseVisualStyleBackColor = false;
            this.color0.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 44);
            this.button3.TabIndex = 16;
            this.button3.Text = "Equalize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cubeRadioButton
            // 
            this.cubeRadioButton.AutoSize = true;
            this.cubeRadioButton.Checked = true;
            this.cubeRadioButton.Location = new System.Drawing.Point(111, 174);
            this.cubeRadioButton.Name = "cubeRadioButton";
            this.cubeRadioButton.Size = new System.Drawing.Size(50, 17);
            this.cubeRadioButton.TabIndex = 14;
            this.cubeRadioButton.TabStop = true;
            this.cubeRadioButton.Text = "Cube";
            this.cubeRadioButton.UseVisualStyleBackColor = true;
            // 
            // squareRadioButton
            // 
            this.squareRadioButton.AutoSize = true;
            this.squareRadioButton.Location = new System.Drawing.Point(18, 174);
            this.squareRadioButton.Name = "squareRadioButton";
            this.squareRadioButton.Size = new System.Drawing.Size(59, 17);
            this.squareRadioButton.TabIndex = 13;
            this.squareRadioButton.TabStop = true;
            this.squareRadioButton.Text = "Square";
            this.squareRadioButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 197);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 29);
            this.progressBar1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Iterations";
            // 
            // iterations
            // 
            this.iterations.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.iterations.Location = new System.Drawing.Point(63, 142);
            this.iterations.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.iterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(108, 20);
            this.iterations.TabIndex = 10;
            this.iterations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pixels";
            // 
            // pixels
            // 
            this.pixels.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pixels.Location = new System.Drawing.Point(63, 116);
            this.pixels.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pixels.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pixels.Name = "pixels";
            this.pixels.Size = new System.Drawing.Size(108, 20);
            this.pixels.TabIndex = 8;
            this.pixels.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imagMax
            // 
            this.imagMax.DecimalPlaces = 3;
            this.imagMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.imagMax.Location = new System.Drawing.Point(64, 90);
            this.imagMax.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.imagMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.imagMax.Name = "imagMax";
            this.imagMax.Size = new System.Drawing.Size(108, 20);
            this.imagMax.TabIndex = 6;
            this.imagMax.Value = new decimal(new int[] {
            112,
            0,
            0,
            131072});
            // 
            // imagMin
            // 
            this.imagMin.DecimalPlaces = 3;
            this.imagMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.imagMin.Location = new System.Drawing.Point(64, 64);
            this.imagMin.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.imagMin.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.imagMin.Name = "imagMin";
            this.imagMin.Size = new System.Drawing.Size(108, 20);
            this.imagMin.TabIndex = 5;
            this.imagMin.Value = new decimal(new int[] {
            105,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imag";
            // 
            // realMax
            // 
            this.realMax.DecimalPlaces = 3;
            this.realMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.realMax.Location = new System.Drawing.Point(64, 38);
            this.realMax.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.realMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.realMax.Name = "realMax";
            this.realMax.Size = new System.Drawing.Size(108, 20);
            this.realMax.TabIndex = 3;
            this.realMax.Value = new decimal(new int[] {
            32,
            0,
            0,
            131072});
            // 
            // realMin
            // 
            this.realMin.DecimalPlaces = 3;
            this.realMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.realMin.Location = new System.Drawing.Point(64, 12);
            this.realMin.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.realMin.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.realMin.Name = "realMin";
            this.realMin.Size = new System.Drawing.Size(108, 20);
            this.realMin.TabIndex = 2;
            this.realMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Real";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 497);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Mandelbrot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown imagMax;
        private System.Windows.Forms.NumericUpDown imagMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown realMax;
        private System.Windows.Forms.NumericUpDown realMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown pixels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown iterations;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton cubeRadioButton;
        private System.Windows.Forms.RadioButton squareRadioButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button color255;
        private System.Windows.Forms.Button color0;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

