using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            if (a > 5)
            {
                if (a % 5 == 0)
                {
                    Console.WriteLine("Greater");
                }
                else
                {
                    Console.WriteLine("not divisible");
                }
            }

            Console.Read();
        }
    }
}
