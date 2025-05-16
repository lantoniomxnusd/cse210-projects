using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade >= 90)
        {
            Console.WriteLine($"Congratulations you passed! You're grade is an A");
        }
        else if (grade <= 89 && grade >= 80)
        {
            Console.WriteLine($"Congratulations you passed! You're grade is an B");
        }
        else if (grade <= 79 && grade >= 70)
        {
            Console.WriteLine($"Congratulations you passed! You're grade is an C");
        }
        else if (grade <= 69 && grade >= 60)
        {
            Console.WriteLine($"Your grade is a D. I'm sorry. You didn't pass");
        }
        else
        {
            Console.WriteLine("You did not pass. Your grade is an F");
        }
    }
}