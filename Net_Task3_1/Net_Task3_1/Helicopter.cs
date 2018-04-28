using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Task3_1
{
    class Helicopter : AirTransport
    {
        public Helicopter(int speed, int carrying, string model, int numberStuff, int numberPassenger) 
            : base(speed, carrying, model, numberStuff, numberPassenger)
        {
        }

        public override string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return base.ToString() + $" Тип: Вертолет ";
        }
    }
}
