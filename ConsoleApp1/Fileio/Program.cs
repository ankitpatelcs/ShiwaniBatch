using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fileio
{
    class MyClass
    {
        internal void WriteFile(string filename)
        {
            StreamWriter sw = File.CreateText(filename);
            Console.Write("Enter text in file: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
            Console.WriteLine("File write success.");
        }

        internal void ReadFile(string filename)
        {
            StreamReader sr = File.OpenText(filename);
            Console.WriteLine("\nText from file: "+sr.ReadToEnd());
            sr.Close();
            Console.WriteLine("Read Success.");
        }

        internal void AppendFile(string filename)
        {
            StreamWriter sw = File.AppendText(filename);
            Console.Write("\nEnter text to append: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
            Console.WriteLine("File Append success.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            string filename = @"C:\Ankit Patel\Shiwani.txt";
            m.WriteFile(filename);
            m.ReadFile(filename);

            m.AppendFile(filename);
            m.ReadFile(filename);

            Console.Read();
        }
    }
}
