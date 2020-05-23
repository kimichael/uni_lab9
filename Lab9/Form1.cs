using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        private Random generator;

        private Boolean isStopped = true;

        private Task circleGeneratorTask;

        private int drawnCircles = 0;

        public Form1()
        {
            InitializeComponent();
            generator = new Random();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isStopped)
            {
                isStopped = false;
                circleGeneratorTask = new Task(() =>
                {
                    while (true) {
                        if (drawnCircles < maxCircles.Value) {
                            Task.Run(() =>
                            {
                                drawnCircles++;
                                Graphics graphics = pictureBox1.CreateGraphics();
                                int red = generator.Next(0, 255);
                                int green = generator.Next(0, 255);
                                int blue = generator.Next(0, 255);
                                int x = generator.Next(0, pictureBox1.Width);
                                int y = generator.Next(0, pictureBox1.Height);
                                int lifeTime = Convert.ToInt32(lifecycleMean.Value) + generator.Next(-5, 5);
                                int radius = 0;

                                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(Color.FromArgb(red, green, blue));
                                for (int i = 0; i < lifeTime * 3; i++)
                                {
                                    Rectangle rect = new Rectangle(new Point(x - radius, y - radius), new Size(radius * 2, radius * 2));
                                    graphics.FillEllipse(myBrush, rect);
                                    radius += 10;
                                    Thread.Sleep(1);
                                }
                                pictureBox1.Invalidate();
                                drawnCircles--;
                            });
                        }

                        Thread.Sleep(5);
                        if (isStopped)
                        {
                            return;
                        }
                    }
                });
                circleGeneratorTask.Start();
                startButton.Text = "Stop";
            }
            else {
                stopGenerating();
            }
            
        }

        private void maxCircles_ValueChanged(object sender, EventArgs e)
        {
            stopGenerating();
        }

        private void lifecycleMean_ValueChanged(object sender, EventArgs e)
        {
            stopGenerating();
        }

        private void stopGenerating() {
            startButton.Text = "Start";
            isStopped = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            stopGenerating();
        }
    }
}
