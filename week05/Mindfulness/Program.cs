using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindful Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the Menu: ");
            string choice = Console.ReadLine();

            if (choice == "1") new BreathingActivity().Run();
            else if (choice == "2") new ReflectingActivity().Run();
            else if (choice == "3") new ListingActivity().Run();
            else if (choice == "4") break;
            else Console.WriteLine("Invalid Choice. Try again.");
            
        }
    }
}