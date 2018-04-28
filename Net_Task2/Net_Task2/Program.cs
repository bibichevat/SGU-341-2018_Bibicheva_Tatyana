using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("Владимир", 26, 85, 187);
            Student student = new Student("Иван", 20, 80, 180, 2017, 1, "141");
            Console.WriteLine(man);
            Console.WriteLine(student);

            //Author author = new Author("Курт", "Воннегут", new DateTime(1922, 11, 11));
            //Console.WriteLine(author);
            Book book = new Book("Колыбель для кошки", 282, "АСТ", new DateTime(1963, 1, 1), new DateTime(1963, 2, 2), new Author("Курт", "Воннегут", new DateTime(1922, 11, 11)));
            Console.WriteLine(book);            
        }
    }
}
