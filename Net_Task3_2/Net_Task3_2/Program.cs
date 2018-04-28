using System.Collections.Generic;

namespace Net_Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Project project = new Project("web", new Customer("Петр", "Петров", "СГУ"));
            List<Programmer> programmers = new List<Programmer>();
            programmers.Add(new BackEndProgrammer("Иван", "Иванов", 10, Level.Lead));
            programmers.Add(new FrontEndProgrammer("Андрей", "Иванов", 2, Level.Junior));
            project.Programmers = programmers;
            List<Tester> testers = new List<Tester>();
            testers.Add(new AutoTester("Сергей", "Семенов", 8, Level.Senior));
            testers.Add(new ManualTester("Александр", "Александров", 4, Level.Developer));
            project.Testers = testers;

            project.AddEmployee(new AutoTester("Сергей", "Сергеев", 7, Level.Senior));
            project.AddEmployee(new BackEndProgrammer("Иван", "Сергеев", 10, Level.Lead));

            project.Programmers[0].GetSalary();
            project.Programmers[0].WriteCode(300);
            project.Programmers[1].WriteCode(400);
            project.Programmers[2].WriteCode(200);
            project.Testers[0].TestCode();
            int count = project.Testers[0].FindBugs();
            project.Programmers[0].FixBugs(count);
            project.Programmers[1].FixBugs(count);
            project.Testers[1].TestCode();
            project.Testers[2].TestCode();

        }
    }
}
