
namespace Net_Task3_2
{
    public abstract class Programmer : Employee
    {
        public Programmer(string name, string surname, int experience, Level level)
            : base(name, surname, experience, level)
        {
        }

        public abstract void WriteCode(int count);
        public abstract void FixBugs(int count);

        public abstract Programmer Clone();

    }
}
