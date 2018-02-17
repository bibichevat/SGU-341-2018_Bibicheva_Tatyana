using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Task1
{
    public class Pyramid
    {
        private List<Point> basePoints = new List<Point>();
        private Point commonPoint;
        private Point h;

        public Pyramid(IEnumerable<Point> points)
        {
            try
            {
                commonPoint = points.ElementAt(0);
                for (int i = 1; i < 5; i++)
                {
                    basePoints.Add(points.ElementAt(i));
                }
                h = points.ElementAt(5);

                if (!Exist())
                {
                    throw new Exception("Пирамиды с заданными координатами не существует");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private bool Exist()
        {
            //проверка на существование всех 4-х треугольников
            double aB = commonPoint.GetDistance(basePoints[0]);
            double aC = commonPoint.GetDistance(basePoints[1]);
            double bC = basePoints[0].GetDistance(basePoints[1]);
            double aD = commonPoint.GetDistance(basePoints[2]);
            double cD = basePoints[1].GetDistance(basePoints[2]);
            double aE = commonPoint.GetDistance(basePoints[3]);
            double dE = basePoints[2].GetDistance(basePoints[3]);
            double bE = basePoints[0].GetDistance(basePoints[3]);

            if (aB > aC + bC || aC > aB + bC || bC > aC + aB)
                return false;
            if (aC > aD + cD || aD > aC + cD || cD > aC + aD)
                return false;
            if (aD > aE + dE || aE > dE + aD || dE > aD + aE)
                return false;
            if (aB > aE + bE || aE > aB + bE || bE > aB + aE)
                return false;

            //проверка на существование основания
            if (bC > cD + dE + bE || cD > bC + dE + bE || bE > bC + cD + bE || bE > bC + cD + dE)
                return false;

            return true;
        }

        public double GetBaseSquare()
        {
            double bC = basePoints[0].GetDistance(basePoints[1]);
            double cD = basePoints[1].GetDistance(basePoints[2]);
            double dE = basePoints[2].GetDistance(basePoints[3]);
            double bE = basePoints[0].GetDistance(basePoints[3]);
            double p = (bC + cD + dE + bE) / 2; //полупериметр
            return Math.Sqrt((p - bC) * (p - cD) * (p - dE) * (p - bE));
        }

        public double GetV()
        {
            return (1.0 / 3.0) * GetBaseSquare() * commonPoint.GetDistance(h);
        }

    }
}
