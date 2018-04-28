using System;

namespace Net_Task3_1
{
    abstract class GroundTransport : ITransport
    {
        private int speed;
        private int carrying;
        private string model;
        private int numberStuff;
        private int numberPassenger;
        private bool isRail;

        public GroundTransport(int speed, int carrying, string model, int numberStuff, int numberPassenger, bool isRail)
        {
            this.Speed = speed;
            this.Carrying = carrying;
            this.Model = model;
            this.NumberStuff = numberStuff;
            this.NumberPassenger = numberPassenger;
            this.isRail = isRail;
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if ((value > 0) && (value < 500))
                {
                    speed = value;
                }
            }
        }

        public int Carrying
        {
            get
            {
                return carrying;
            }
            set
            {
                if ((value > 0) && (value < 200000))
                {
                    carrying = value;
                }
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    model = value;
                }
            }
        }

        public int NumberStuff
        {
            get
            {
                return numberStuff;
            }
            set
            {
                if (value > 0)
                {
                    numberStuff = value;
                }
            }
        }

        public int NumberPassenger
        {
            get
            {
                return numberPassenger;
            }
            set
            {
                if (value > 0)
                {
                    numberPassenger = value;
                }
            }
        }

        public void DeliverCargo(int weight)
        {
            if (weight <= this.Carrying)
            {
                Console.WriteLine("Доставлен груз весом в {0}", weight);
            }
            else
            {
                Console.WriteLine("Невозможно доставить груз такого веса");
            }
        }

        public virtual string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"Скорость: {Speed} Грузоподъемность: {Carrying} Модель: {Model} Количество персонала: {NumberStuff} " +
                $"Количество пассажиров: {NumberPassenger}  Рельсовый: {isRail} ";
        }
    }
}
