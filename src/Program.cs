using System;

namespace FunctionChallenges
{
    class Program
    {

        static void Main(string[] args)
        {

//Challenge 1
            Console.WriteLine("Challenge 1: String and Number Processor");
            StringNumberProcessor("Hello", 100, 200, "World");

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



//Challenge 2
            Console.WriteLine("\nChallenge 2: Object Swapper");

            string str1 = "HelloWorld", str2 = "Programming";
            int num1 = 25, num2 = 30;

            SwapObjects(ref str1, ref str2);
            SwapObjects(ref num1, ref num2);

            Console.WriteLine($"STR 1: {str1}");
            Console.WriteLine($"STR 2: {str2}");
            Console.WriteLine($"NUM 1: {num1}");
            Console.WriteLine($"NUM 2: {num2}");

            static void SwapObjects<T>(ref T obj1, ref T obj2)
            {
                T temp = obj1;
                obj1 = obj2;
                obj2 = temp;
                if (obj1 is string str1 && obj2 is string str2)
                {
                    if (str1.Length < 5 || str2.Length > 18)
                    {
                        Console.WriteLine("Error: Length must be more than 5");
                        return;
                    }
                }
                if (obj1 is int num1 && obj2 is int num2)
                {
                    if (num1 < 18 || num2 < 18)
                    {
                        Console.WriteLine("Error: Length must be more than 18");
                        return;
                    }
                }

            }
            //   - SwapObjects(ref num1, str 1) // Error: Objects must be of same types
            //   - SwapObjects(true, false) // Error: Unsuported type




            Console.WriteLine("\nChallenge 3: Guessing Game");
            Uncomment to test the GuessingGame method
            GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`











        }
    }
}
