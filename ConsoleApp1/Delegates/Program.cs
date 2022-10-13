using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void FirstDelegate();
    class MyClass
    {
        internal void display()
        {
            Console.WriteLine("Calling Display");
        }
        internal void show()
        {
            Console.WriteLine("Calling Show");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            FirstDelegate del1 = new FirstDelegate(m.display);
            //numticasting
            del1 += new FirstDelegate(m.show);
            del1();

            del1 -= new FirstDelegate(m.display);
            del1();

            Console.Read();
        }
    }
}
