using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();
        Running activity1 = new Running(new DateTime(2023,7,9), 30, 3.0);
        Cycling activity2 = new Cycling(new DateTime(2023, 7, 10), 30, 9.7);
        Swimming activity3 = new Swimming(new DateTime(2023, 7,11), 30, 20);

        _activities.Add(activity1);
        _activities.Add(activity2);
        _activities.Add(activity3);

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}