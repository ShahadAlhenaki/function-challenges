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

            //Challenge 3
            Console.WriteLine("\nChallenge 3: Guessing Game");

            static void GuessingGame()
            {
                Random random = new Random();
                int numberToGuess = random.Next(1, 101);
                int attempts = 0;
                int guess = 0;

                Console.WriteLine("Welcome to the Number Guessing Game!");
                Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it!");

                while (guess != numberToGuess)
                {
                    Console.Write("Enter your guess: ");
                    string? input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 100.");
                        continue;
                    }
                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100.");
                        continue;
                    }
                    attempts++;
                    if (guess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} in {attempts} attempts!");
                    }
                }
            }
            GuessingGame();

            //Challenge 4
            Console.WriteLine("\nChallenge 4: Simple Word Reversal");

            string sentence = "This is the original sentence!";
            string reversed = ReverseWords(sentence);
            Console.WriteLine(reversed);

            string ReverseWords(string sentence)
            {
                string[] words = sentence.Split();
                List<string> reversedWords = [];
                foreach (string word in words)
                {
                    string reversed = string.Join("", word.Reverse());
                    reversedWords.Add(reversed);
                }
                return string.Join(" ", reversedWords);
            }
        }
    }
}
