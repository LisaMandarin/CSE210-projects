using System;

public class Activity
{
    protected DateTime _date;
    protected int _activityLength;
    protected string _type;

    public Activity(DateTime date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return $"{_date.ToShortDateString()} {_type} ({_activityLength}) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
