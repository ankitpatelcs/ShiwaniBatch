using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Employee
    {
        int id;
        string name;

        //public Employee()   // default constructor
        //{
        //    id = -1;
        //    name = "--";
        //}
        //internal Employee(int id,string name)   // parametarized constructor
        //{
        //    this.id = id;
        //    this.name = name;
        //}

        internal void Getdata()
        {
            Console.WriteLine("Enter ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
        }

        public void Showdata()
        {
            Console.WriteLine("Employee ID: {0}", id);
            Console.WriteLine("Employee Name: {0}", name);
        }

        //~Employee()
        //{

        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee(12,"Shivani");    // declaring an object of Employee class
            Employee[] e = new Employee[3];
            for (int i = 0; i < e.Length; i++)
            {
                e[i] = new Employee();
                e[i].Getdata();
            }
            for (int i = 0; i < e.Length; i++)
            {
                e[i].Showdata();
            }
            

            Console.Read();
        }
    }
}
