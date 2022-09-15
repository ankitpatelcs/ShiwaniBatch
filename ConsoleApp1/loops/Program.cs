using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Hello TOPS.");
                i++;
            }

            Console.WriteLine("---Do-While loop---");
            i = 5;
            do
            {
                Console.WriteLine("Hello TOPS.");
                i++;

            } while (i<5);
            Console.WriteLine("---for loop---");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello Tops");
            }

            Console.Read();
        }
    }
}
