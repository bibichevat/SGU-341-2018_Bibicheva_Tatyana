using System;

namespace Net_Task3_2
{
    

    public abstract class Employee : Man
    {
        private int experience;
        private Level level;
        private int salary;

        public Employee(string name, string surname, int experience, Level level)
            : base(name, surname)
        {
            this.Experience = experience;
            this.Level = level;
            SetSalary();
        }

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                if ((value > 0) && (value < 90))
                {
                    experience = value;
                }
            }
        }

        public Level Level
        {
            get
            {
                return level;
            }
            set
            {
                if (Level.IsDefined(typeof (Level), value))
                {
                    level = value;
                }
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }
        }

        
        public void GetSalary()
        {
            Console.WriteLine("Сотрудник {0} {1} получил зарплату {2}", Name, Surname, Salary);
        }

        private void SetSalary()
        {
            salary = 100 * experience;
            if (this.Level == Level.Junior)
            {
                salary += 2000;
            }
            else if (this.Level == Level.Developer)
            {
                salary += 4000;
            }
            else if (this.Level == Level.Senior)
            {
                salary += 6000;
            }
            else
            {
                salary += 8000;
            }
        }
    }
}
