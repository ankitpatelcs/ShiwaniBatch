﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclass
{
    partial class MyClass
    {
        internal int id;
    }
    partial class MyClass
    {
        internal string name;
    }
    partial class MyClass
    {
        internal void display()
        {
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.id = 90;
            m.name = "Shivani";
            m.display();
        }
    }
}
