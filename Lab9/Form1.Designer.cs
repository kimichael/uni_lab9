namespace Lab9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.lifecycleMean = new System.Windows.Forms.NumericUpDown();
            this.maxCircles = new System.Windows.Forms.NumericUpDown();
            this.meanLabel = new System.Windows.Forms.TextBox();
            this.maxCirclesLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifecycleMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCircles)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 429);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startButton.Location = new System.Drawing.Point(12, 415);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lifecycleMean
            // 
            this.lifecycleMean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lifecycleMean.Location = new System.Drawing.Point(93, 418);
            this.lifecycleMean.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lifecycleMean.Name = "lifecycleMean";
            this.lifecycleMean.Size = new System.Drawing.Size(60, 20);
            this.lifecycleMean.TabIndex = 2;
            this.lifecycleMean.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lifecycleMean.ValueChanged += new System.EventHandler(this.lifecycleMean_ValueChanged);
            // 
            // maxCircles
            // 
            this.maxCircles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxCircles.Location = new System.Drawing.Point(159, 418);
            this.maxCircles.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxCircles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxCircles.Name = "maxCircles";
            this.maxCircles.Size = new System.Drawing.Size(60, 20);
            this.maxCircles.TabIndex = 2;
            this.maxCircles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxCircles.ValueChanged += new System.EventHandler(this.maxCircles_ValueChanged);
            // 
            // meanLabel
            // 
            this.meanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.meanLabel.BackColor = System.Drawing.SystemColors.Control;
            this.meanLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meanLabel.Location = new System.Drawing.Point(93, 399);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(60, 13);
            this.meanLabel.TabIndex = 3;
            this.meanLabel.Text = "mean";
            // 
            // maxCirclesLabel
            // 
            this.maxCirclesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxCirclesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxCirclesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxCirclesLabel.Location = new System.Drawing.Point(159, 399);
            this.maxCirclesLabel.Name = "maxCirclesLabel";
            this.maxCirclesLabel.Size = new System.Drawing.Size(60, 13);
            this.maxCirclesLabel.TabIndex = 3;
            this.maxCirclesLabel.Text = "maxCircles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maxCirclesLabel);
            this.Controls.Add(this.meanLabel);
            this.Controls.Add(this.maxCircles);
            this.Controls.Add(this.lifecycleMean);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifecycleMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCircles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown lifecycleMean;
        private System.Windows.Forms.NumericUpDown maxCircles;
        private System.Windows.Forms.TextBox meanLabel;
        private System.Windows.Forms.TextBox maxCirclesLabel;
    }
}

