using fizzbuzz.library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {             
                Console.WriteLine(fizzbuzzer.GetValue(i));   
            }
            Console.ReadLine();
        }
    }
}
