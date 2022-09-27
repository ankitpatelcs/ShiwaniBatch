using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedclass
{
    sealed class MyClass
    {
        int id;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
        }
    }
}
