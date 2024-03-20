using System;

namespace FunctionChallenges
{
    class Program
    {
        static void StringNumberProcessor(params object[] inputs)
        {

            string concatenatedString = " ";
            int sum = 0;

            foreach (var input in inputs)
            {
                if (input is string)
                {
                    concatenatedString += input + " ";
                }
                else if (input is int)
                {
                    sum += Convert.ToInt32(input);
                }
            }
            Console.WriteLine($"{concatenatedString}; {sum}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1: String and Number Processor");
            StringNumberProcessor("Hello", 100, 200, "World");








        }
    }
}
