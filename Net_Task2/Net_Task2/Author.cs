using System;

namespace Net_Task2
{
    public class Author
    {
        private string name;
        private string surname;
        private DateTime year;

        public Author(string name, string surname, DateTime year)
        {
            this.Name = name;
            this.Surname = surname;
            this.Year = year;
        }

        protected string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        protected string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.surname = value;
            }
        }

        protected DateTime Year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (value.Date < DateTime.Today.Date)
                {
                    this.year = value.Date;
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} Surname: {Surname} Year: {Year.ToShortDateString()} ";
        }
    }
}
