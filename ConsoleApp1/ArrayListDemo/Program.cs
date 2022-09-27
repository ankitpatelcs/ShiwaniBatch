using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList li = new ArrayList();
            li.Add("Shivani");
            li.Add(25000.5);
            li.Add(205);
            li.Add('F');
            li.Add(true);

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
