
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Psalm", 144, 1);
        string text = " Blessed be the Lord my strength, which teacheth my hands to war, and my fingers to fight:";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Press enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}