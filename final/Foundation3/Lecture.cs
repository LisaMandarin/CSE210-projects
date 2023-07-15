using System;

public class Lecture: Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime startDate, DateTime endDate, Address address, string speaker, int capacity): base(title, description, startDate, endDate, address)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string DisplayFull()
    {
        return $"{base.DisplayFull()}\n✦ Speaker: {_speaker}\n✦ Capacity: {_capacity}";
    }
}
