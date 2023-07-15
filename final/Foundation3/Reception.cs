using System;

public class Reception: Event
{
    private string _email;
    public Reception(string title, string description, DateTime startDate, DateTime endDate, Address address, string email):base(title, description, startDate, endDate, address)
    {
        _type = "Reception";
        _email = email;
    }

    public override string DisplayFull()
    {
        return $"{base.DisplayFull()}\n✦ RSVP Email: {_email}";
    }
}
