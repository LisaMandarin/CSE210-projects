using System;

public class ChecklistGoal: Goal
{
    private int _targetTimes;
    private int _currentTimes;
    private int _bonus;
    
    public ChecklistGoal(string name, string description, int points, int targetTimes, int bonus): base()
    {
        _goalType = "ChecklistGoal";
        _name = name;
        _description = description;
        _points = points;
        _targetTimes = targetTimes;
        _bonus = bonus;
        _isCompleted = false;
    }
    public override int RecordEvent()
    {
        _currentTimes++;
        if (_currentTimes == _targetTimes)
        {
            _isCompleted = true;
            return _points+_bonus;
        }
        return _points;
    }
    public override bool IsComplete()
    {
        return _isCompleted;
    }
    public string Progress()
    {
        return $"Currently completed: {_currentTimes}/{_targetTimes}";
    }
    public int GetTargetTimes()
    {
        return _targetTimes;
    }
    public int GetCurrentTimes()
    {
        return _currentTimes;
    }
    public void SetCurrentTimes(int currentTime)
    {
        _currentTimes = currentTime;
    }
    public int GetBonus()
    {
        return _bonus;
    }
}