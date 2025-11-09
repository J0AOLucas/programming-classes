using System;
using System.Collections.Generic;

public class Listing : Activity
{
  private List<string> _prompts = new List<string>
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };

  public Listing(string name, string description, int duration) : base(name, description, duration)
  {
  }

  public void Run()
  {
    DisplayStartingMessage();

    Random random = new Random();
    string prompt = _prompts[random.Next(_prompts.Count)];
    
    Console.WriteLine("List as many responses you can to the following prompt:");
    Console.WriteLine();
    Console.WriteLine($"--- {prompt} ---");
    Console.WriteLine();
    Console.Write("You may begin in: ");
    ShowCountdown(5);
    Console.WriteLine();
    Console.WriteLine();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);
    List<string> items = new List<string>();

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      string item = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(item))
      {
        items.Add(item);
      }
    }

    Console.WriteLine();
    Console.WriteLine($"You listed {items.Count} items!");
    Console.WriteLine();

    DisplayEndingMessage();
  }
}
