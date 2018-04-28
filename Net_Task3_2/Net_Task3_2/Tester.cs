using System;

namespace Net_Task3_2
{    
    public abstract class Tester : Employee
    {
        public Tester(string name, string surname, int experience, Level level)
            : base(name, surname, experience, level)
        {
        }

        public abstract void TestCode();
        public abstract int FindBugs();

        public abstract Tester Clone();        
    }
}
