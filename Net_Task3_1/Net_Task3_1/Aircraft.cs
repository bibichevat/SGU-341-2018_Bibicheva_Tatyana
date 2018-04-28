using System;

namespace Net_Task3_1
{
    class Aircraft : AirTransport
    {
        private int span;

        public int Span
        {
            get
            {
                return span;
            }
            set
            {
                if ((value > 0) && (value < 300))
                {
                    span = value;
                }
            }
        }

        public Aircraft(int speed, int carrying, string model, int numberStuff, int numberPassenger, int span) 
            : base(speed, carrying, model, numberStuff, numberPassenger)
        {
            this.Span = span;
        }

        public override string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return base.ToString() + $" Тип: Самолет Размах крыльев: {Span} ";
        }
    }
}
