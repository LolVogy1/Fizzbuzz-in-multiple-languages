using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCS
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            string[] fizzBuzz = { "Fizz", "Buzz" };
            int[] multiples = { 3, 5 };

            for (int i = 0; i <= 100; i++)
            {
                string output = "";
                for (int j = 0; j < multiples.Length; j++)
                {
                    if (i % multiples[j] == 0)
                    {
                        output += fizzBuzz[j];
                    }
                }
                if (output == "")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(output);
                }
            }
        }
    }
}
