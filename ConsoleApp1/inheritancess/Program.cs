using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancess
{
    class Employee
    {
        int id;
        string name;
        internal void Getdata()
        {
            Console.WriteLine("Enter ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
        }

        internal void Showdata()
        {
            Console.WriteLine("Employee ID: {0}", id);
            Console.WriteLine("Employee Name: {0}", name);
        }
    }
    class Payroll : Employee
    {
        int salary;
        internal void GetPayroll()
        {
            Getdata();
            Console.WriteLine("Enter Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowPayroll()
        {
            Showdata();
            Console.WriteLine("Employee Salary: {0}", salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payroll p = new Payroll();
            p.GetPayroll();
            p.ShowPayroll();

            Console.Read();
        }
    }
}
