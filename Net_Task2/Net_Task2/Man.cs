namespace Net_Task2
{
    public class Man
    {
        private string name;
        private int age;
        private double weight;
        private int height;

        public Man(string name, int age, double weight, int height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }

        protected string Name
        {
            get
            {
                return name;
            }
                
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        protected int Age
        {
            get
            {
                return age;
            }
            set
            {
                if ((value > 0) && (value < 120))
                {
                    age = value;
                }
            }
        }

        protected double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if ((value > 0) && (value < 200))
                {
                    weight = value;
                }
            }
        }

        protected int Height
        {
            get
            {
                return height;
            }
            set
            {
                if ((value > 0) && (value < 250))
                {
                    height = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age} Weight: {Weight} Height: {Height} ";
        }
    }
}
