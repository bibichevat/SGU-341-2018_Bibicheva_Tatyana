using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Net_Task1
{
    class Program
    {
        private static bool TryParse(string[] points, out Point value)
        {
            double point1;
            double point2;
            double point3;
            value = null;
            if (double.TryParse(points[0], out point1) && double.TryParse(points[1], out point2) && double.TryParse(points[2], out point3))
            {
                value = new Point(point1, point2, point3);
                return true;
            }

            return false;
        }
        public static IEnumerable<Point> ReadPoints(string name)
        {
            using (StreamReader file = new StreamReader(name))
            {
                string text = file.ReadLine();
                string[] mas = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<Point> tmp = new List<Point>();

                for (int i = 0; i < mas.Length / 3; i++)
                {
                    Point point;
                    if (!TryParse(mas.Skip(i * 3).Take(3).ToArray(), out point))
                    {
                        Console.WriteLine("Неверный формат файла");
                        return null;
                    }
                    tmp.Add(point);
                }

                return tmp;
            }
        }

        static void Main(string[] args)
        {
            IEnumerable<Point> points;
            points = ReadPoints("input.txt");
            if (points != null)
            {
                try
                {
                    Pyramid pyramid = new Pyramid(points);
                    using (StreamWriter file = new StreamWriter("output.txt"))
                    {
                        file.WriteLine("Площадь основания = {0}", pyramid.GetBaseSquare());
                        file.WriteLine("Объем пирамиды = {0}", pyramid.GetV());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
