public class Reflecting : Activity
{
    public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }
    public void GetPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        List<string> prompts = new List<string>();
        prompts.Add("--- Think of a time when you stood up for someone else. ---");
        prompts.Add("--- Think of a time when you did something really difficult. ---");
        prompts.Add("--- Think of a time when you helped someone in need. ---");
        prompts.Add("--- Think of a time when you did somehting truly selfless ---");
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        Console.WriteLine(prompts[randomIndex]);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
    }
    public void GetExQuestions(int activityTime)
    {
        Console.Write("You may begin in: ");
        CountDown();
        Console.WriteLine();
        List<string> expQuestions = new List<string>();
        expQuestions.Add("Why was this experience meaningful to you?");
        expQuestions.Add("Have you ever done anything like this before?");
        expQuestions.Add("How did you get started?");
        expQuestions.Add("How did you feel when it was complete?");
        expQuestions.Add("What made this time different than other times when you were not as successful?");
        expQuestions.Add("What is your favorite thing about this experience?");
        expQuestions.Add("What could you learn from this experience that applies to other situations?");
        expQuestions.Add("What did you learn about yourself through this experience?");
        expQuestions.Add("How can you keep this experience in mind in the future?");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(activityTime);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string x = expQuestions[i];
            Console.Write(x);
            Spinner(8);
            Console.WriteLine();
            i++;
            if (i >= expQuestions.Count)
            {
                i = 0;
            }
        }
    }
    public void EndActivity(int activityTime)
    {
        Ready();
        GetPrompt();
        GetExQuestions(activityTime);
        EndMessage(activityTime);
    }
}