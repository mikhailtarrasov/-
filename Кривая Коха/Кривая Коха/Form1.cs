using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кривая_Коха
{
    public partial class Form1 : Form
    {
        private Bitmap Bmp { get; set; }

        static Pen pen1;
        static Graphics g;
        static Pen pen2;
        private List<MouseEventArgs> TraingleDotsList { get; set; }

        public Form1()
        {
            InitializeComponent();
            TraingleDotsList = new List<MouseEventArgs>();
            Bmp = new Bitmap("D://Кох.png");
            Height = Bmp.Height + 40;
            Width = Bmp.Width + 18;
            pictureBox1.Image = Bmp;
            pictureBox1.Height = Bmp.Height;
            pictureBox1.Width = Bmp.Width;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var coordinates = (MouseEventArgs) e;
            TraingleDotsList.Add(coordinates);
            if (TraingleDotsList.Count == 3)
            {
                Draw(sender, e);
                TraingleDotsList.Clear();
            }
        }

        private void Draw(object sender, EventArgs e)
        {
            //Выбираем цвета зарисовки 
            pen1 = new Pen(Color.Green, 1);
            pen2 = new Pen(Color.Blue, 1);
            //Определяем объект "g" класса Graphics
            g = pictureBox1.CreateGraphics(); 
            //= CreateGraphics();
            g.Clear(Color.Black);//Зарисовка экрана черным фоном

            //Определим координаты исходного треугольника
            var point1 = new PointF(TraingleDotsList[0].X, TraingleDotsList[0].Y);
            var point2 = new PointF(TraingleDotsList[1].X, TraingleDotsList[1].Y);
            var point3 = new PointF(TraingleDotsList[2].X, TraingleDotsList[2].Y);

            //Зарисуем треугольник
            g.DrawLine(pen1, point1, point2);
            g.DrawLine(pen1, point2, point3);
            g.DrawLine(pen1, point3, point1);

            //Вызываем функцию Fractal для того, чтобы
            //нарисовать три кривых Коха на сторонах треугольника
            Fractal(point1, point2, point3, 6);
            Fractal(point2, point3, point1, 6);
            Fractal(point3, point1, point2, 6);
        }


        //рекурсивная функция рисования кривой Коха
        static int Fractal(PointF p1, PointF p2, PointF p3, int iter)
        {
            //n -количество итераций
            if (iter > 0)  //условие выхода из рекурсии
            {
                //средняя треть отрезка
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                //координаты вершины угла
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);
                //рисуем его
                g.DrawLine(pen1, p4, pn);
                g.DrawLine(pen1, p5, pn);
                g.DrawLine(pen2, p4, p5);


                //рекурсивно вызываем функцию нужное число раз
                Fractal(p4, pn, p5, iter - 1);
                Fractal(pn, p5, p4, iter - 1);
                Fractal(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), iter - 1);
                Fractal(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), iter - 1);
            }
            return iter;
        }
    }
}
