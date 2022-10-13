using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listdemo
{
    class Employee
    {
        internal int id;
        internal string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { id = 1, name = "Shivani" });
            li.Add(new Employee { id = 2, name = "Disha" });
            li.Add(new Employee { id = 3, name = "Chirag" });
            li.Add(new Employee { id = 4, name = "Jay" });

            foreach (var item in li)
            {
                Console.WriteLine("ID: " + item.id);
                Console.WriteLine("Name: " + item.name);
            }
            Console.Read();
        }
    }
}
