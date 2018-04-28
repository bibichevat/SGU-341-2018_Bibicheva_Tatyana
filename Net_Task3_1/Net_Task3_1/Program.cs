using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransport[] transport = new ITransport[2];
            transport[0] = new Car(80, 1000, "Chevrolet", 1, 4, false);
            transport[1] = new Aircraft(800, 100000, "Boeing 777", 2, 300, 60);
            foreach (var elem in transport)
            {
                Console.WriteLine(elem.GetInfo());
            }

            GroundTransport groundTransport = new Train(200, 200000, "1", 20, 400, true);
            Console.WriteLine(groundTransport.GetInfo());

            WaterTransport waterTransport = new Tanker(50, 10000, "11", 30, 300);
            Console.WriteLine(waterTransport.GetInfo());
        }
    }
}
