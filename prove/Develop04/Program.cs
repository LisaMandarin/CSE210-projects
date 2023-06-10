using System;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start Reflecting Activity");
        Console.WriteLine("  3. Start Listing Activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");

        int option;
        Log log = new Log();
        while ((option = int.Parse(Console.ReadLine())) !=4)
        {
            int activityTime;
            if (option == 1)
            {
                Breathing Breathing = new Breathing();
                Breathing.StartActivity();
                activityTime = int.Parse(Console.ReadLine());
                Breathing.EndActivity(activityTime);
                log.getLogs("Breathing", activityTime);
            }
            else if (option == 2)
            {
                Reflecting reflecting = new Reflecting();
                reflecting.StartActivity();
                activityTime = int.Parse(Console.ReadLine());
                reflecting.EndActivity(activityTime);
                log.getLogs("Reflecting", activityTime);
            }
            
            else if (option ==3)
            {
                Listing Listing = new Listing();
                Listing.StartActivity();
                activityTime = int.Parse(Console.ReadLine());
                Listing.EndActivity(activityTime);
                log.getLogs("Listing", activityTime);
            }
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
        }
        Console.WriteLine(log.GetLogMessage());
        Console.WriteLine("Bye Bye");
        

    }
}