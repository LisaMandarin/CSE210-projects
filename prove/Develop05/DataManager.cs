using System;

public class DataManager
{
    private List<Goal> goals;
    private int _score;
    public DataManager()
    {
        goals = new List<Goal>();
        _score = 0;
    }
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i+1}. {goal.GetName()}");
        }
        
        Console.Write("What goal did you accomplish? ");
        int index;
        string input = Console.ReadLine();

        if (int.TryParse(input, out index))
        {
            if (index >0 && index <= goals.Count)
            {
                Goal goalChosen = goals[index-1];
                int pointsEarned = goalChosen.RecordEvent();
                _score += pointsEarned;
                Console.WriteLine();
                Console.WriteLine($"Congratulations!  You have earned {goalChosen.GetPoints()} points!");
                Console.WriteLine($"You now have {_score} points");         
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
    
    public void DisplayGoals()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i+1}. [{(goal.IsComplete() ? "X" : " ")}] {goal.GetName()} ({goal.GetDescription()})");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"       {checklistGoal.Progress()})");
            }
        }
    }
    public int GetScore()
    {
        return _score;
    }
    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int score = GetScore();
            outputFile.WriteLine(score);
            foreach (Goal goal in goals)
            {
                string goalType = goal.GetGoalType();
                string name = goal.GetName();
                string description = goal.GetDescription();
                int points = goal.GetPoints();
                bool value = goal.IsComplete();
                string line = "";
                if (goal is SimpleGoal simpleGoal)
                {
                    line = $"{goalType},{name},{description},{points},{value}";
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    line = $"{goalType},{name},{description},{points}";
                }
                else if (goal is ChecklistGoal checklist)
                {
                    int targetTimes = checklist.GetTargetTimes();
                    int currentTimes = checklist.GetCurrentTimes();
                    int bonus = checklist.GetBonus();
                    line = $"{goalType},{name},{description},{points},{bonus},{targetTimes},{currentTimes}";
                }
                outputFile.WriteLine(line);
            }
        }
    }
    public void LoadGoals(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist!");
            return;
        }
        goals.Clear();

        using (StreamReader inputFile = new StreamReader(fileName))
        {
            string scoreLine = inputFile.ReadLine();
            int score = int.Parse(scoreLine);
            _score = score;
            
            
            string line = inputFile.ReadLine();
            while (line != null)
            {
                string [] goalData = line.Split(",");
                string goalType = goalData[0];
                string name = goalData[1];
                string description = goalData[2];
                int points = int.Parse(goalData[3]);

                if (goalType == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    AddGoal(eternalGoal);
                }
                
                else if (goalType == "SimpleGoal")
                {
                    bool isCompleted = bool.Parse(goalData[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    simpleGoal.SetIsCompleted(isCompleted);
                    AddGoal(simpleGoal);
                }            
                else if(goalType == "ChecklistGoal")
                {
                    int bonus = int.Parse(goalData[4]);
                    int targetTimes = int.Parse(goalData[5]);
                    int currentTimes = int.Parse(goalData[6]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetTimes, bonus);
                    checklistGoal.SetCurrentTimes(currentTimes);
                    AddGoal(checklistGoal);
                }
                
                line = inputFile.ReadLine();
            }
        }
    }
}
