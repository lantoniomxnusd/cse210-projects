using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);

        Console.WriteLine("What is your guess?");
        string userGuess = Console.ReadLine();
        var
        int count = 1;

        while (guess != randomNumber)
        {
            if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

            Console.WriteLine("What is your guess?");
            userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            count++; 
        }

        Console.WriteLine("You guessed it!");
        Console.Write($"You guessed {count} times.");
     }
}