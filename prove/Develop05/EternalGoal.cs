using System;

public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, int points) 
    : base(name, description, points)
  {
  }

  public override int RecordEvent()
  {
    return _points;
  }

  public override bool IsComplete()
  {
    return false;
  }

  public override string GetStringRepresentation()
  {
    return $"EternalGoal:{_name}|{_description}|{_points}";
  }

  public override string GetDisplayString()
  {
    return $"[ ] {_name} ({_description})";
  }

  public static EternalGoal CreateGoal()
  {
    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();
    
    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();
    
    Console.Write("What is the amount of points associated with this goal? ");
    int points = int.Parse(Console.ReadLine());
    
    return new EternalGoal(name, description, points);
  }
}
