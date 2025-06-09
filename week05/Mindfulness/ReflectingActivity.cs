public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This wil help you recognize the power you have and how you can ue it in other aspects of your life.")
    {
        _prompts.Add("---Think of a time when you overcame a difficult challenge.---");
        _prompts.Add("---Think of a time when you overcame a difficult challenge.---");
        _prompts.Add("---Think of a time when you overcame a difficult challenge.---");

        _questions.Add(" Why was this experience meaningful to you?");
        _questions.Add(" What did you learn about yourself?");
        _questions.Add(" How can you apply this lesson in the future?");
        _questions.Add(" What did this experience teach you about resilience?");
        _questions.Add(" How did this make you stronger?");

        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nConsider the following prompt:\n {prompt}\n");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions. Press Enter when you're ready to move to the next one.");
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        CountDownMessage("You may begin in ...", 3);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            Console.ReadLine();

        }

        DisplayEndingMessage();
    }
}