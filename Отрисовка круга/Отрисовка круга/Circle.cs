using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Отрисовка_круга
{

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

    }
}
