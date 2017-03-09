using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение_для_просмотра_изображений
{
    public class MyBitmap
    {
        public string FileName { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public MyBitmap(string location)
        {
            try
            {
                FileStream stream = new FileStream(@location, FileMode.Open, FileAccess.Read);

                while (stream.ReadByte() != -1)
                {
                    
                }

                stream.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
