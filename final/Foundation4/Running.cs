using System;

public class Running: Activity
{
    private double _distnace;

    public Running (DateTime date, int activityLength, double distance): base(date, activityLength)
    {
        _type = "Running";
        _distnace = distance;
    }

    public override double GetDistance()
    {
        return _distnace;
    }

    public override double GetSpeed()
    {
        return (_distnace / _activityLength) * 60;
    }

    public override double GetPace()
    {
        return _activityLength / _distnace;
    }

}