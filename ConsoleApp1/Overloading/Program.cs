using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Shape
    {
        internal void Area(int a)
        {
            Console.WriteLine($"Area of Square: {a * a}");
        }
        internal void Area(int l,int b)
        {
            Console.WriteLine($"Area of Rectangle: {l * b}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.Area(10,5);
            s.Area(30);

            Console.Read();
        }
    }
}
