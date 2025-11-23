using System;

public class SimpleGoal : Goal
{
  private bool _isComplete;

  public SimpleGoal(string name, string description, int points, bool isComplete = false) 
    : base(name, description, points)
  {
    _isComplete = isComplete;
  }

  public override int RecordEvent()
  {
    if (!_isComplete)
    {
      _isComplete = true;
      return _points;
    }
    return 0;
  }

  public override bool IsComplete()
  {
    return _isComplete;
  }

  public override string GetStringRepresentation()
  {
    return $"SimpleGoal:{_name}|{_description}|{_points}|{_isComplete}";
  }

  public static SimpleGoal CreateGoal()
  {
    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();
    
    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();
    
    Console.Write("What is the amount of points associated with this goal? ");
    int points = int.Parse(Console.ReadLine());
    
    return new SimpleGoal(name, description, points);
  }
}
