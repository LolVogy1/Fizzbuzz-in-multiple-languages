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
            // Multiples and fizzbuzz strings
            string[] fizzBuzz = { "Fizz", "Buzz" };
            int[] multiples = { 3, 5 };

            // Loop from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                // Empty string 
                string output = "";
                for (int j = 0; j < multiples.Length; j++)
                {
                    // If a multiple
                    if (i % multiples[j] == 0)
                    {
                        // Add the relevant string
                        output += fizzBuzz[j];
                    }
                }
                // If the string is empty it is not a multiple of anything
                if (output == "")
                {
                    // Print the number
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
