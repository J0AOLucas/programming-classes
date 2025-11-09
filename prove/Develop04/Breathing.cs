using System;

public class Breathing : Activity
{
  public Breathing(string name, string description, int duration) : base(name, description, duration)
  {
  }

  public void Run()
  {
    DisplayStartingMessage();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
      Console.Write("Breathe in... ");
      ShowCountdown(4);
      Console.WriteLine();

      if (DateTime.Now >= endTime)
        break;

      Console.Write("Now breathe out... ");
      ShowCountdown(6);
      Console.WriteLine();
      Console.WriteLine();
    }

    DisplayEndingMessage();
  }
}