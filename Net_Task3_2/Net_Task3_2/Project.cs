using System.Collections.Generic;
using System.Linq;

namespace Net_Task3_2
{
    public class Project
    {
        private string name;
        private Customer customer;
        private List<Programmer> programmers;
        private List<Tester> testers;

        public Project(string name, Customer customer, List<Programmer> programmers, List<Tester> testers)
        {
            this.Name = name;
            this.Customer = customer;
            this.Programmers = programmers;
            this.Testers = testers;
        }

        public Project(string name, Customer customer)
        {
            this.Name = name;
            this.Customer = customer;            
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

        public Customer Customer
        {
            get
            {
                return customer;
            }
            set
            {
                if (value != null)
                {
                    customer = value;
                }
            }
        }

        public List<Programmer> Programmers
        {
            get
            {
                return programmers;
            }
            set
            {
                if (value != null)
                {
                    programmers = value.Select(x => x.Clone()).ToList();
                }
                else
                {
                    programmers = new List<Programmer>();
                }
            }
        }

        public List<Tester> Testers
        {
            get
            {
                return testers;
            }
            set
            {
                if (value != null)
                {
                    testers = value.Select(x => x.Clone()).ToList();
                }
                else
                {
                    testers = new List<Tester>();
                }
            }
        }

        public void AddEmployee(Employee employee)
        {
            if (employee is Programmer)
            {
                Programmers.Add((Programmer)employee);
            }
            else if (employee is Tester)
            {
                Testers.Add((Tester)employee);
            }
        }

    }
}
