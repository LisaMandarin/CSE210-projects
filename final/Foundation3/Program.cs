class Program
{
    static void Main(string[] args)
    {
        Address eventAdd = new Address("111 Main St.", "Palm Coast", "Florida", "USA");
        Lecture eventLecture = new Lecture("From a Street Kid in North Korea to a College Student in New York", "North Korean defector Joseph Kim shares his story of growing up in North Korea during the famine. In this TED Talk he shares how an “act of love and caring” can change someone’s life.", new DateTime(2023,06,08,09,00,00), new DateTime(2023,06,08,11,00,00),eventAdd, "Adam Smith", 100);
        Reception eventReception = new Reception("Summer Show Opening", "This show includes our 21 permanent artists and several members of the Waterford Weavers Guild.  There will be a demonstration of working with polymer by a member of the Potomac Polymer Clay Guild.", new DateTime(2023,09,09,14,00,00), new DateTime(2023,09,09,16,00,00), eventAdd, "lisachuang81@gmail.com");
        OutdoorGathering eventOutdoor = new OutdoorGathering("Alan's 11th Birthday Party", "This is a zoo theme party that celebrates Alan Johnson's 11th birthday.", new DateTime(2023,12,22,12,00,00), new DateTime(2023,12,22,16,00,00), eventAdd, "sunny");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(eventLecture.DisplayStandard());
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(eventLecture.DisplayFull());
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(eventLecture.DisplayShort());

        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(eventReception.DisplayStandard());
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(eventReception.DisplayFull());
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(eventReception.DisplayShort());

        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(eventOutdoor.DisplayStandard());
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(eventOutdoor.DisplayFull());
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(eventOutdoor.DisplayShort());
    }
}
