using System;

/*
 * EXCEEDING REQUIREMENTS:
 * 
 * 1. Enhanced Goal Display: The ChecklistGoal displays detailed progress information
 *    (e.g., "Currently completed: 2/5") even before completion, providing users with
 *    clear visibility of their progress toward the goal.
 * 
 * 2. Static Factory Methods: Each goal type uses static CreateGoal() methods that
 *    encapsulate the goal creation logic, making the code more organized and following
 *    the factory pattern for better code structure.
 * 
 * 3. Comprehensive Status Display: The goal list shows completion status with [X] for
 *    completed goals and [ ] for incomplete goals, and ChecklistGoals also show their
 *    progress ratio, making it easy for users to see their overall progress at a glance.
 */

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        int answer = 0;

        while (answer != 6)
        {
            Console.WriteLine($"\nYou have {goalManager.GetScore()} points\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    CreateNewGoal(goalManager);
                    break;
                
                case 2:
                    goalManager.ListGoals();
                    break;
                
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    goalManager.SaveGoals(Console.ReadLine());
                    break;
                
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    goalManager.LoadGoals(Console.ReadLine());
                    break;
                
                case 5:
                    RecordEvent(goalManager);
                    break;
                
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        
        int goalType = int.Parse(Console.ReadLine());
        Goal newGoal = null;
        
        switch (goalType)
        {
            case 1:
                newGoal = SimpleGoal.CreateGoal();
                break;
            case 2:
                newGoal = EternalGoal.CreateGoal();
                break;
            case 3:
                newGoal = ChecklistGoal.CreateGoal();
                break;
        }
        
        if (newGoal != null)
        {
            goalManager.AddGoal(newGoal);
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("\nThe goals are:");
        goalManager.ListGoals();
        Console.Write("\nWhich goal did you accomplish? ");
        
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        goalManager.RecordEvent(goalIndex);
    }
}