using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  public int GetScore()
  {
    return _score;
  }

  public void AddGoal(Goal goal)
  {
    _goals.Add(goal);
  }

  public void ListGoals()
  {
    if (_goals.Count == 0)
    {
      Console.WriteLine("No goals have been created yet.");
      return;
    }

    Console.WriteLine("\nThe goals are:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
    }
  }

  public void RecordEvent(int goalIndex)
  {
    if (goalIndex >= 0 && goalIndex < _goals.Count)
    {
      int pointsEarned = _goals[goalIndex].RecordEvent();
      _score += pointsEarned;
      Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
      Console.WriteLine($"You now have {_score} points.");
    }
  }

  public int GetGoalCount()
  {
    return _goals.Count;
  }

  public void SaveGoals(string filename)
  {
    using (StreamWriter writer = new StreamWriter(filename))
    {
      writer.WriteLine(_score);
      
      foreach (Goal goal in _goals)
      {
        writer.WriteLine(goal.GetStringRepresentation());
      }
    }
    
    Console.WriteLine($"Goals saved to {filename}");
  }

  public void LoadGoals(string filename)
  {
    if (!File.Exists(filename))
    {
      Console.WriteLine($"File {filename} not found.");
      return;
    }

    _goals.Clear();
    
    using (StreamReader reader = new StreamReader(filename))
    {
      _score = int.Parse(reader.ReadLine());
      
      string line;
      while ((line = reader.ReadLine()) != null)
      {
        Goal goal = ParseGoal(line);
        if (goal != null)
        {
          _goals.Add(goal);
        }
      }
    }
    
    Console.WriteLine($"Goals loaded from {filename}");
  }

  private Goal ParseGoal(string line)
  {
    string[] parts = line.Split(':');
    string goalType = parts[0];
    string[] data = parts[1].Split('|');

    switch (goalType)
    {
      case "SimpleGoal":
        return new SimpleGoal(
          data[0], 
          data[1], 
          int.Parse(data[2]), 
          bool.Parse(data[3])
        );
      
      case "EternalGoal":
        return new EternalGoal(
          data[0], 
          data[1], 
          int.Parse(data[2])
        );
      
      case "ChecklistGoal":
        return new ChecklistGoal(
          data[0], 
          data[1], 
          int.Parse(data[2]), 
          int.Parse(data[4]), 
          int.Parse(data[3]), 
          int.Parse(data[5])
        );
      
      default:
        return null;
    }
  }
}

