using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palindrome
            //Get Input
            //validate input only numbers and characters
            //run if input is a palindrome
            //index input
            //1st char = 0
            //lastChar

            //11111
            //racecar


            RunPalindrome();
        }

        private static string GetInput()
        {
            //get input 
            Console.WriteLine("Input string to check Palindrome");
            return Console.ReadLine().ToLower();
        }

        private static void RunPalindrome()
        {
            //loop
            string input = GetInput();
            bool isPalindrome = false;

            if (input.Length == 0)
            {
                Console.WriteLine($"{input} is a Palindrome");
            }
            else
            {
                for (int i = 0; i <= input.Length / 2; i += 1)
                {
                    isPalindrome = CheckCharacter(input[i], input[input.Length - i - 1]);
                    if (!isPalindrome)
                    {
                        Console.WriteLine($"{input} is not a Palindrome");
                        break;
                    }
                }

                if (isPalindrome)
                {
                    Console.WriteLine($"{input} is a Palindrome");
                }
            }

        }
        private static bool CheckCharacter(char one, char two)
        {
            //algorithm
            if (one == two)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
