using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;

public class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        // Console.WriteLine(randomPrompt);
        // To test prompt generator

        Console.WriteLine("Welcome to the Journal Program!")
    while (!== 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("\nWhat would you like to do? ");

            string choice = Console.ReadLine();
    }
}
    
}