using System;

namespace Net_Task3_2
{
    public class FrontEndProgrammer : Programmer
    {
        public FrontEndProgrammer(string name, string surname, int experience, Level level) 
            : base(name, surname, experience, level)
        {
        }

        public override void FixBugs(int count)
        {
            Console.WriteLine("Фронт-енд разработчик {0} {1} исправил {2} ошибок", this.Name, this.Surname, count);
        }

        public override void WriteCode(int count)
        {
            Console.WriteLine("Фронт-енд разработчик {0} {1} написал {2} строк кода", this.Name, this.Surname, count);
        }

        public override Programmer Clone()
        {
            return new FrontEndProgrammer(Name, Surname, Experience, Level);
        }

    }
}
