using System;

public class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected DateTime _startDate;
    protected DateTime _endDate;
    protected Address _address;

    public Event(string title, string description, DateTime startDate, DateTime endDate, Address address)
    {
        _title = title;
        _description = description;
        _startDate = startDate;
        _endDate = endDate;
        _address = address;
    }
    public string DisplayStandard()
    {
        string date = _startDate.ToShortDateString();
        string startTime = _startDate.ToString("h:mm tt");
        string endTime = _endDate.ToString("h:mm tt");
        return $"✦ Title: {_title}\n✦ Description: {_description}\n✦ Date: {date}\n✦ Time: {startTime} - {endTime}\n✦ Address: {_address.DisplayAddress()}";
    }
    public virtual string DisplayFull()
    {
        return DisplayStandard();
    }
    public string DisplayShort()
    {
        string date = _startDate.ToShortDateString();
        return $"✦ Type: {_type}\n✦ Title: {_title}\n✦ Date: {date}";
    }
}
