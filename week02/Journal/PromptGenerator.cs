using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are you genuinely looking forward to, and why?",
        "What would make today feel meaningful or fulfilling to you?",
        "What thought, belief, or habit are you ready to question or shift?",
        "What did you notice about your emotions today, and how did you respond to them?",
        "What challenged you, and how did you handle it?", 
        "How can you be gentler with yourself right now?"
        
    };

    private Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
