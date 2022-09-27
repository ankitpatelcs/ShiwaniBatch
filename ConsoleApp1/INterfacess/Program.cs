using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterfacess
{
    interface IEmployee
    {
        void getdata();
        void showdata();
    }
    class Employee : IEmployee
    {
        public void getdata()
        {
            Console.WriteLine("Calling from GetData");
        }

        public void showdata()
        {
            Console.WriteLine("Calling from ShowData");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee e = new Employee();
            e.getdata();
            e.showdata();

            Console.Read();
        }
    }
}
