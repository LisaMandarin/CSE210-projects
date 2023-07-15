using System;

class Program
{
    static void Main(string[] args)
    {
        // TimeSpan startTime = new TimeSpan(9, 30,00);
        // TimeSpan endTime = new TimeSpan(10,00,00);
        // string timeRange = $"{startTime:h\\:mm} - {endTime:H\\:mm}";
        // Console.WriteLine(startTime);
        // Console.WriteLine(timeRange);
        
        // DateTime dateTime1 = new DateTime(2023, 06, 08, 19,0,0);
        // Console.WriteLine(dateTime1.ToString("yyyy-MMMM-dd"));
        // Console.WriteLine(dateTime1.ToString("h:mm tt"));

        DateTime _dateTime = new DateTime(2023,6,8,9,30,0);
        string date = $"{_dateTime.ToString("yyyy-MMMM-dd")}";
        string startTime = $"{_dateTime.ToString("h:mm tt")}";
        string endTime = $"{_dateTime.AddMinutes(90).ToString("h:mm tt")}";
        string timeRange = $"{startTime} - {endTime}";
        Console.WriteLine($"Date: {date}\nTime: {timeRange}");
    }
}