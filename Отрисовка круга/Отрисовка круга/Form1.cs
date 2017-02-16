using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Отрисовка_круга
{
    public partial class Form1 : Form
    {
        public Circle MyCircle { get; set; }

        public Form1()
        {
            MyCircle = new Circle();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            if (MyCircle.Center == null)
            {
                MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
                MyCircle.Center = new Point();
                MyCircle.Center.X = mouseEventArgs.X;
                MyCircle.Center.Y = mouseEventArgs.Y;

                PutPixel(g, Color.DeepPink, MyCircle.Center.X, MyCircle.Center.Y, 255);
            }
            else
            {
                if (MyCircle.Radius == 0)
                {
                    MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
                    int dx2 = (int)Math.Pow(mouseEventArgs.X - MyCircle.Center.X, 2);
                    int dy2 = (int)Math.Pow(mouseEventArgs.Y - MyCircle.Center.Y, 2);
                    int radius2 = (dx2 + dy2);
                    MyCircle.Radius = (int) Math.Sqrt(radius2);

                    BresenhamCircle(g, Color.DeepPink, MyCircle.Center.X, MyCircle.Center.Y, MyCircle.Radius);
                    MyCircle = new Circle();
                }
            }
        }

        public static void BresenhamCircle(Graphics g, Color clr, int _x, int _y, int radius)
        {
            int x = 0, y = radius, gap = 0, delta = (2 - 2 * radius);
            while (y >= 0)
            {
                PutPixel(g, clr, _x + x, _y + y, 255);
                PutPixel(g, clr, _x + x, _y - y, 255);
                PutPixel(g, clr, _x - x, _y - y, 255);
                PutPixel(g, clr, _x - x, _y + y, 255);
                gap = 2 * (delta + y) - 1;
                if (delta < 0 && gap <= 0)
                {
                    x++;
                    delta += 2 * x + 1;
                    continue;
                }
                if (delta > 0 && gap > 0)
                {
                    y--;
                    delta -= 2 * y + 1;
                    continue;
                }
                x++;
                delta += 2 * (x - y);
                y--;
            }
        }
        private static void PutPixel(Graphics g, Color clr, int x, int y, int alpha)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(alpha, clr)), x, y, 1, 1);
        }
    }
}
