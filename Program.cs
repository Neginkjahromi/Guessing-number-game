using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  **Guessing number game**");
            Console.WriteLine();
            Console.Write("    Guess a number between 1 to 100 --> ");
            try
            {
                Random randomNumber = new Random();
                Random randomNumber2 = new Random();
                int userGuess = 0, trys = 1, continuee, number = randomNumber.Next(100), number2 = randomNumber2.Next(1000);
                while (userGuess != number)
                {
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    if (userGuess < number)
                    {
                        Console.Write("    Guess a bigger number --> ");
                    }
                    else if (userGuess > number)
                    {
                        Console.Write("    Guess a smaller number --> ");
                    }
                    else
                    {
                        Console.WriteLine($"  **You win with {trys} trys**");
                    }
                    trys++;
                }
                Console.WriteLine();
                Console.WriteLine("    1 --> level 2");
                Console.WriteLine("    2 --> Exit");
                Console.Write("    ----> ");
                continuee = Convert.ToInt32(Console.ReadLine());
                if (continuee == 1)
                {
                    trys = 1;
                    Console.WriteLine("    **Level 2**");
                    Console.Write("    Guess a number between 1 to 1000 --> ");

                    while (userGuess != number2)
                    {
                        userGuess = Convert.ToInt32(Console.ReadLine());
                        if (userGuess < number2)
                        {
                            Console.Write("    Guess a bigger number --> ");
                        }
                        else if (userGuess > number2)
                        {
                            Console.Write("    Guess a smaller number --> ");
                        }
                        else
                        {
                            Console.WriteLine($"  **You win with {trys} trys**");
                        }
                        trys++;
                    }
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("    Enter a number");
                throw;
            }
            Console.ReadKey();
        }
    }
}