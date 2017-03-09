using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Алгоритмы_заливки
{
    public partial class Form1 : Form
    {
        Stack<Point> MyStack { get; set; }
        Bitmap Bmp { get; set; }

        public Form1()
        {
            InitializeComponent();
            Bmp = new Bitmap("D:\\hipster.png");
            Size = new Size(Bmp.Width + 16, Bmp.Height + 16);
            pictureBox1.Width = Bmp.Width;
            pictureBox1.Height = Bmp.Height;
            pictureBox1.Image = Bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs coordinates = (MouseEventArgs)e;
            var startPixel = new Point { X = coordinates.X, Y = coordinates.Y };

            MyStack = new Stack<Point>();
            MyStack.Push(startPixel);
            var startColor = Bmp.GetPixel(startPixel.X, startPixel.Y);
            var inverseColor = Color.FromArgb(
                Math.Abs(255 - startColor.A),
                Math.Abs(255 - startColor.R),
                Math.Abs(255 - startColor.G),
                Math.Abs(255 - startColor.B));
            while (MyStack.Count > 0)
            {
                var currentPixel = MyStack.Pop();
                PutPixel(inverseColor, currentPixel.X, currentPixel.Y, 255);

                for(int i = currentPixel.X - 1; i <= currentPixel.X + 1; i++)
                {
                    for(int j = currentPixel.Y - 1; j <= currentPixel.Y + 1; j++)
                    {
                        if(i > 0 && j > 0 && i < Bmp.Width && j < Bmp.Height)
                        {
                            var friendPixel = Bmp.GetPixel(i, j);
                            if (friendPixel == startColor)
                                MyStack.Push(new Point { X = i, Y = j });
                        }
                    }
                }
            }
            pictureBox1.Image = Bmp;
        }

        private void PutPixel(Color clr, int x, int y, int alpha)
        {
            Bmp.SetPixel(x, y, clr);
        }
    }
}
