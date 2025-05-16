using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade <= 89 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade <= 79 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade <= 69 && grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Try again! You can do it!");
        }
    }
}