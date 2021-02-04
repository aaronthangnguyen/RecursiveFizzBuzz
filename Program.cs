using System;

namespace RecursiveFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RECURSIVE FIZZBUZZ");
            Console.WriteLine("------------------");
            int number = ReadInt(min: 1, max: 9999, prompt: "INPUT: Enter a number: ");
            DoRecursiveFizzBuzz(1, number);
        }

        static int ReadInt(int min, int max, string prompt)
        {
            Console.Write(prompt);
            string resultString = Console.ReadLine();
            int result = int.Parse(resultString);

            if ((result < min) || (result > max))
            {
                Console.WriteLine("PROMPT: Please enter a number between 1 and 9999");
                return ReadInt(min, max, prompt);
            }
            else
            {
                return result;
            }
        }

        static void DoRecursiveFizzBuzz(int current, int max)
        {
            if (current > max)
            {
                return; // WHY: return void
            }
            else
            {
                string result = "";
                if (current % 3 == 0)
                    result += "Fizz";
                if (current % 5 == 0)
                    result += "Buzz";
                if (result == "")
                    result += current;

                Console.WriteLine(result);

                DoRecursiveFizzBuzz(current + 1, max);
            }
        }
    }
}
