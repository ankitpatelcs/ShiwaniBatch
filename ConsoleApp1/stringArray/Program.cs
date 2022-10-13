using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] array = new String[5];

            array[0] = "abc";
            array[1] = "Shivani";
            array[2] = "Jaydeep";
            array[3] = "  ab";
            array[4] = "hello";

            array = array.OrderBy(d => d).ToArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            string name = "Shivani";
            char[] ary = name.ToCharArray();
            ary = ary.OrderBy(s => s).ToArray();
            foreach (var item in ary)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
