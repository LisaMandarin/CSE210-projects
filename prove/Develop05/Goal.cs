using System;

public abstract class Goal
{
    
    protected string _goalType;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;
    public string GetGoalType()
    {
        return _goalType;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetIsCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
}

