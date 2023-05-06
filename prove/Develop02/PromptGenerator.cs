using System;

public class PromptGenerator
{
    public string [] prompts =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How do you rate your level of happiness today from 1 to 5?  1 for extremely not happy, 5 for extremely happy"
    };
    public DateTime _currentDate = DateTime.Today;
    
    public string Generate()
    {
        Random rnd = new Random();
        string promptSelect = prompts[rnd.Next(prompts.Length)];
        string promptOutput = $"{_currentDate.Date.ToString("d")} - {promptSelect}";
        return promptOutput;
    }
    
}