
namespace Net_Task3_2
{
    public class Customer : Man
    {
        private string company;

        public Customer(string name, string surname, string company)
            : base(name, surname)
        {
            this.Company = company;
        }

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    company = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Имя {Name} Фамилия {Surname} Компания {Company}";
        }
    }
}
