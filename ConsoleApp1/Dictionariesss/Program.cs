﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionariesss
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("ID","205");
            d.Add("Name","Shivani");
            d.Add("Salary","25000.5");
            d.Add("Gender","F");

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.Read();
        }
    }
}
