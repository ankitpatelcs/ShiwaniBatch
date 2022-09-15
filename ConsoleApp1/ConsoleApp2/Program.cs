using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum Weekdays
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Weekdays.Thursday);
            Console.Read();
        }
    }
}
