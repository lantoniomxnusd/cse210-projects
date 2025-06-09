public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    

    public ListingActivity()
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ")
    {
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who has had a positive impact on your life recently?");
        _prompts.Add("What accomplishments, big or small, have you achieved this week?");
        _prompts.Add("What things bring you peace or joy?");

    }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];


        Console.WriteLine($"List as many responses as you can to the following prompt: ");
        Console.WriteLine($"---{prompt}---");

        CountDownMessage("You may begin in:", 3);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write($"> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }
}