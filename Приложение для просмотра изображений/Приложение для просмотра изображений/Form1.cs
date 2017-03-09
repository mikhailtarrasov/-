using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение_для_просмотра_изображений
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string bmpPicture = "D:\\hipster.bmp";
            MyBitmap myBmp = new MyBitmap(bmpPicture);
            //Bitmap bmp = new Bitmap("D:\\hipster.bmp");
            //this.Size = new Size(bmp.Width + 16, bmp.Height + 16);
            //this.pictureBox1.Width = bmp.Width;
            //this.pictureBox1.Height = bmp.Height;
            //pictureBox1.Image = bmp;
        }
    }
}
