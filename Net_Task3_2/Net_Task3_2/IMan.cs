namespace Net_Task3_2
{
    public abstract class Man
    {
        private string name;
        private string surname;

        protected Man(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    surname = value;
                }
            }
        }

    }
}
