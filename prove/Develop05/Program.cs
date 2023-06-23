using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.White;
        DataManager data = new DataManager();
        Reward reward = new Reward();
        int option = -1;
        while(option != 6)
        {
            Console.WriteLine();
            Console.WriteLine("===============Program Starts=======================");
            int score = data.GetScore();
            Console.WriteLine($"You have {score} points");

            Console.WriteLine("   ***** Fun Fact *****   ");
            reward.GetFact(score);
            
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create a New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record an Event");
            Console.WriteLine("     6. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine();
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine();

                int choice;
                Console.Write("Which type of goal would you like to create? ");
                choice = int.Parse(Console.ReadLine());
                
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of point associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
            
                if (choice == 1)
                {
                    SimpleGoal goal1 = new SimpleGoal(name, description, points);
                    data.AddGoal(goal1);
                }
                else if (choice == 2)
                {
                    EternalGoal goal2 = new EternalGoal(name, description, points);
                    data.AddGoal(goal2);
                }
                else if (choice == 3)
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int targetTimes = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal goal3 = new ChecklistGoal(name, description, points, targetTimes, bonus);
                    data.AddGoal(goal3);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            if (option == 2)
            {
                data.DisplayGoals();
            }
            if (option == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                data.SaveGoals(filename);
            }
            if (option == 4)
                {
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();
                    data.LoadGoals(filename);
                }
            if (option == 5)
            {
                data.RecordEvent();
            }
        }
        Console.WriteLine("Bye bye");
        
    }
}