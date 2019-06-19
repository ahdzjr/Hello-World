using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Good day, " + name + "!");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();


        }
    }
}

