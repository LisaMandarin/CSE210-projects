using System;

public class Swimming: Activity
{
    private int _lapNumber;

    public Swimming(DateTime date, int activityLength, int lapNumber): base(date, activityLength)
    {
        _type = "Swimming";
        _lapNumber = lapNumber;
    }

    public override double GetDistance()
    {
        return _lapNumber * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _activityLength) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}