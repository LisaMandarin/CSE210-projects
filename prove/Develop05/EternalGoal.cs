using System;

public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, int points): base()
    {
        _goalType = "EternalGoal";
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }
    public override int RecordEvent()
    {
        return _points;
    }
    public override bool IsComplete()
    {
        return _isCompleted;
    }
}