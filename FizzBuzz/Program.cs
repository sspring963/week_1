using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // allow the user to give us upperBound, lowerBound (think validate)
            // allow the user to set condition for multiple 7, 11
            // count from 0 to 100, and print eaach number per line
            // if number is multiple of 3, print fizz
            // if number is multiple of 5, print buzz
            // if number is multiple of both, print fizzbuzz

            int start = InputInt("Input lowerBound:");
            int end = InputInt("Input upperBound:");
            while (end < start)
            {
                Console.WriteLine($"The upperBound, {end}, is less than the lowerBound. Please enter a number greater than {start}");
                end = InputInt("Input upperBound:");
            }
            int div1 = InputInt("Input div1 for fizz:");
            int div2 = InputInt("input div2 for buzz:");

            RunFizzBuzz(start, end, div1, div2);
        }

        private static void RunFizzBuzz(int start, int end, int div1, int div2, int inc = 1)
        {


            //loop
            for (var x = start; x <= end; x += inc)
            {
                PrintNumber(x, div1, div2);
            }
        }


        private static int InputInt(string promt)
        {
            //validates input is an int
            Console.WriteLine(promt);
            bool success = false;
            do
            {
                success = Int32.TryParse(Console.ReadLine(), out int value);
                if (success)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("That is not an number! Please enter a number");
                }
            } while (!success);

            return -1;
        }



        private static void PrintNumber(int num, int div1, int div2)
        {
            //algorithm
            string output = "";

            if (num % div1 == 0)
            {
                output = output + "fizz";
            }
            if (num % div2 == 0)
            {
                output = output + "buzz";
            }

            if (num == 0)
            {
                output = "0";
            }
            if (output.Equals(""))
            {
                output = $"{num}";
            }

            WriteToConsole(output);
        }

        private static void WriteToConsole(string input)
        {
            //prints input
            Console.WriteLine(input);
        }
    }
}
