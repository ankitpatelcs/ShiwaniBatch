using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name = "Shiwani";

            Console.Write("Enter ID: ");
            id= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.WriteLine("ID: {0}\nName: {1}", id, name);
            Console.Read();
        }
    }
}
