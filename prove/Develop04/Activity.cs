using System;

public class Activity
{
  private string _name;
  protected string _description;
  protected int _duration;

  public Activity(string name, string description, int duration)
  {
    _name = name;
    _description = description;
    _duration = duration;
  }

  public void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name}.");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Get ready to begin...");
    ShowSpinner(3);
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine();
    Console.WriteLine("Well done!!");
    ShowSpinner(3);
    Console.WriteLine();
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    ShowSpinner(3);
  }

  protected void ShowSpinner(int seconds)
  {
    DateTime endTime = DateTime.Now.AddSeconds(seconds);
    string[] spinner = { "|", "/", "-", "\\" };
    int index = 0;

    while (DateTime.Now < endTime)
    {
      Console.Write(spinner[index]);
      Thread.Sleep(250);
      Console.Write("\b \b");
      index = (index + 1) % spinner.Length;
    }
  }

  protected void ShowCountdown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }
}