using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStmts
{
    class Program
    {
        static void Main(string[] args)
        {
        lbl2:
            Console.WriteLine("showing goto working");
            goto lbl1;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Looping");
            }

        lbl1:
            Console.WriteLine("After completing.");
            goto lbl2;

            Console.Read();
        }
    }
}
