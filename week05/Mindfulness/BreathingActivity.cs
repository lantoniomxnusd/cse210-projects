public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int timePassed = 0;

        while (timePassed < duration)
        {

            CountDownMessage("Breathe in...", 5);
            timePassed += 6;

            CountDownMessage("Breathe out...", 6);
            timePassed += 6;
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

}