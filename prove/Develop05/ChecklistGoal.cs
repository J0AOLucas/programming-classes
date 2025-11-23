using System;

public class ChecklistGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;

  public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) 
    : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;
    _amountCompleted = amountCompleted;
  }

  public override int RecordEvent()
  {
    _amountCompleted++;
    
    if (_amountCompleted >= _target)
    {
      return _points + _bonus;
    }
    
    return _points;
  }

  public override bool IsComplete()
  {
    return _amountCompleted >= _target;
  }

  public override string GetStringRepresentation()
  {
    return $"ChecklistGoal:{_name}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
  }

  public override string GetDisplayString()
  {
    string status = IsComplete() ? "[X]" : "[ ]";
    return $"{status} {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
  }

  public static ChecklistGoal CreateGoal()
  {
    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();
    
    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();
    
    Console.Write("What is the amount of points associated with this goal? ");
    int points = int.Parse(Console.ReadLine());
    
    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
    int target = int.Parse(Console.ReadLine());
    
    Console.Write("What is the bonus for accomplishing it that many times? ");
    int bonus = int.Parse(Console.ReadLine());
    
    return new ChecklistGoal(name, description, points, target, bonus);
  }
}
