using System;

public class Address
{
    private int _number;
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    
    public Address(int number, string street, string city, string state, string country)
    {
        _number = number;
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country == "USA";
    }
    public string DisplayAddress()
    {
        string address1 = $"  {_number} {_street}";
        string address2 = $"  {_city} {_state}";
        string address3 = $"  {_country}";
        return $"{address1}\n{address2}\n{address3}";
    }
}