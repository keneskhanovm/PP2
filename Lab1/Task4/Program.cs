using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //read the input from console
            for (int i = 1; i <= a; i++) 
            { //double loop
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("[*]");
                }
                Console.Write("\n");
            }
        }
    }
}
