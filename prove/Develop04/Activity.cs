public class Activity
{
    protected string _activityName = "";
    protected string _description = "";

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void GetWelcomeMesssage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine();
    }
    public void GetDescription()
    {
        Console.WriteLine(_description);
        Console.WriteLine();
    }
    public void GetDuration()
    {
        Console.Write($"How long, in seconds, would you like for your session? ");
    }
    public void Ready()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(5);
        Console.WriteLine();
    }
    public void EndMessage(int activityTime)
    {
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Spinner(5);
        Console.WriteLine($"You have completed another {activityTime} seconds of {_activityName} Activity.");
        Spinner(5);
        Console.Clear();
    }
    public void StartActivity()
    {
        GetWelcomeMesssage();
        GetDescription();
        GetDuration();
    }
    public void Spinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string symbol = spinner[i];
            Console.Write(symbol);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }
    
    public void CountDown()
    {for (int i = 5; i>0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}