using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 90;
            string s = Convert.ToString(a);// Boxing

            string n = "55";
            int b = Convert.ToInt32(n); // UnBoxing
        }
    }
}
