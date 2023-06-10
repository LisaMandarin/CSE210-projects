public class Listing : Activity
{
    public Listing() : base ("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    
    public void GetPrompt(int activityTime)
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt that Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        Console.WriteLine(prompts[randomIndex]);
        Console.Write("You may begin in: ");
        CountDown();
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(activityTime);
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            responses.Add(response);
        }
        int number = responses.Count;
        Console.WriteLine($"You have listed {number} items!");
        Console.WriteLine();
               
    }
    public void EndActivity(int activityTime)
    {
        Ready();
        GetPrompt(activityTime);
        EndMessage(activityTime);
    }
}