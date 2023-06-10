public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.")
    {

    }

    public void GetInstruction(int activityTime)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(activityTime);
        
        List<string> breathInstruction = new List<string>();
        breathInstruction.Add("Breathe in...");
        breathInstruction.Add("Now breathe out...");

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string x = breathInstruction[i];
            Console.Write(x);
            CountDown();
            Console.WriteLine();
            i++;
            if (i >=breathInstruction.Count)
            {
                i = 0;
            }
        }
        
    }

    public void EndActivity(int activityTime)
    {
        Ready();
        GetInstruction(activityTime);
        EndMessage(activityTime);
    }
    
}