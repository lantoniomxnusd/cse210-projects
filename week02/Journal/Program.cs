using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        Console.WriteLine("Welcome to the Journal Program!");
        string input = "";

        while (input != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("\nWhat would you like to do? ");
            
            input = Console.ReadLine();

            if (input == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Response: ");
                string response = Console.ReadLine();
                journal.AddEntry(new Entry(prompt, response));
            }
            else if (input == "2")
            {
                journal.DisplayAll();
            }
            else if (input == "3")
            {
                Console.Write("Filename to load: ");
                journal.LoadFromFile(Console.ReadLine());
            }
            else if (input == "4")
            {
                Console.Write("Filename to save: ");
                journal.SaveToFile(Console.ReadLine());
            }
            else if (input == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try 1-5.");
            }
        }
    }
}