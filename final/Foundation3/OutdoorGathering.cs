using System;

public class OutdoorGathering: Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime startDate, DateTime endDate, Address address, string weather):base(title, description, startDate, endDate, address)
    {
        _type = "Outdoor Gathering";
        _weather = weather;
    }

    public override string DisplayFull()
    {
        return $"{base.DisplayFull()}\n✦ Weather: {_weather}";
    }
}