using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CIAO A TUTTI");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Ciao a persona {i}");
            }
            Console.ReadKey();
        }
    }
}
