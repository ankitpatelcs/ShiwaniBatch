using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexersss
{
    class MyClass
    {
        string[] names = new string[5];
        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m[0] = "Shivani";
            m[3] = "Disha";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Value[{i}] : {m[i]}");
            }

            Console.Read();
        }
    }
}
