using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Task3_1
{
    class Car : GroundTransport
    {
        public Car(int speed, int carrying, string model, int numberStuff, int numberPassenger, bool isRail) 
            : base(speed, carrying, model, numberStuff, numberPassenger, isRail)
        {

        }

        public override string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return base.ToString() + $" Тип: Автомобиль";
        }
    }
}
