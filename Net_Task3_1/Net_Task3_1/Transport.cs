using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Task3_1
{
    interface ITransport
    {
        int Speed { get; set; }
        int Carrying { get; set; }
        string Model { get; set; }
        int NumberStuff { get; set; }
        int NumberPassenger { get; set; }
        void DeliverCargo(int weight);
        string GetInfo();
    }
}
