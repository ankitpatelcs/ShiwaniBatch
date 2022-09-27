using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    abstract class Employee
    {
        virtual internal void display()
        {
            Console.WriteLine("calling from Employee");
        }
    }
    class Payroll : Employee
    {
        override internal void display()
        {
            Console.WriteLine("calling from Payroll");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Payroll();
            p.display();

            Console.Read();
        }
    }
}
