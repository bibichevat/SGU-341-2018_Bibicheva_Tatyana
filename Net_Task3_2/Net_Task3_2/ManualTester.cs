using System;

namespace Net_Task3_2
{
    public class ManualTester : Tester
    {
        public ManualTester(string name, string surname, int experience, Level level)
            : base(name, surname, experience, level)
        {
        }

        public override int FindBugs()
        {
            Random random = new Random();
            int count = random.Next(1, 10);
            int bugsNo = random.Next(1, 4);
            Bugs bugs;
            if (bugsNo == 1)
            {
                bugs = Bugs.Major;
            }
            else if (bugsNo == 2)
            {
                bugs = Bugs.Minor;
            }
            else
            {
                bugs = Bugs.Critical;
            }
            Console.WriteLine("Тестировщик ручного тестирования {0} {1} нашел {2} {3} багов", this.Name, this.Surname, count, bugs);
            return count;
        }

        public override void TestCode()
        {
            Console.WriteLine("Тестировщик ручного тестирования {0} {1} протестировал код", this.Name, this.Surname);
        }

        public override Tester Clone()
        {
            return new ManualTester(Name, Surname, Experience, Level);
        }
    }
}
