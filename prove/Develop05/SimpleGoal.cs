using System;

public class SimpleGoal: Goal
{
    public SimpleGoal(string name, string description, int points): base()
    {
        _goalType = "SimpleGoal";
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }
    public override int RecordEvent()
    {
        _isCompleted = true;
        return _points;
    }
    public override bool IsComplete()
    {
        return _isCompleted;
    }
}