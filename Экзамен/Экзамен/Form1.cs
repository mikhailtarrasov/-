using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен
{
    public partial class Form1 : Form
    {
        Stack<Point> MyStack { get; set; }
        Stack<Point> ReColor { get; set; }
        private Bitmap OriginalImage { get; set; }
        private Bitmap NewImage { get; set; }

        public Form1()
        {
            InitializeComponent();
            OriginalImage = new Bitmap("D:\\ekz.png");
            pictureBox1.Image = OriginalImage;
            NewImage = new Bitmap("D:\\ekz.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs coordinates = (MouseEventArgs)e;
            var startPixel = new Point { X = coordinates.X, Y = coordinates.Y };

            MyStack = new Stack<Point>();
            ReColor = new Stack<Point>();
            MyStack.Push(startPixel);
            var startColor = NewImage.GetPixel(startPixel.X, startPixel.Y);
            var inverseColor = Color.FromArgb(
                Math.Abs(255 - startColor.A),
                Math.Abs(255 - startColor.R),
                Math.Abs(255 - startColor.G),
                Math.Abs(255 - startColor.B));
            var newColor = Color.Red;
            int delta = 2;
            while (MyStack.Count > 0)
            {
                var currentPixel = MyStack.Pop();
                NewImage.SetPixel(currentPixel.X, currentPixel.Y, inverseColor);
                //PutPixel(inverseColor, currentPixel.X, currentPixel.Y, 255);

                for (int i = currentPixel.X - delta; i <= currentPixel.X + delta; i++)
                {
                    for (int j = currentPixel.Y - delta; j <= currentPixel.Y + delta; j++)
                    {
                        if (i > 0 && j > 0 && i < NewImage.Width && j < NewImage.Height)
                        {
                            var friendPixel = NewImage.GetPixel(i, j);
                            var friendOriginalPixel = OriginalImage.GetPixel(i, j);

                            if (friendPixel == startColor)
                                MyStack.Push(new Point { X = i, Y = j });
                            if (friendOriginalPixel == inverseColor)
                            {
                                 ReColor.Push(new Point { X = i, Y = j });
                            }
                        }
                    }
                }
            }

            while (ReColor.Count > 0)
            {
                var pixelNewColor = ReColor.Pop();
                PutPixel(newColor, pixelNewColor.X, pixelNewColor.Y, 255);
            }
            //pictureBox1.Image = NewImage;
        }

        private void PutPixel(Color clr, int x, int y, int alpha)
        {
            var graphics = pictureBox1.CreateGraphics();
            var rectangle = new Rectangle(x, y, 1, 1);
            graphics.FillRectangle(new SolidBrush(clr), rectangle);
        }
    }
}
