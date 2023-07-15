using System;

public class Cycling: Activity
{
    private double _speed;

    public Cycling(DateTime date, int activityLength, double speed): base(date, activityLength)
    {
        _type = "Cycling";
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed / 60 * _activityLength;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    
    public override double GetPace()
    {
        return 60 / _speed;
    }

}