using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Task1
{
    public class Point
    {
        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }


        public double GetDistance(Point point)
        {
            return Math.Sqrt(Math.Pow((this.X - point.X), 2) + Math.Pow((this.Y - point.Y), 2) + Math.Pow((this.Z - point.Z), 2));
        }

    }
}
