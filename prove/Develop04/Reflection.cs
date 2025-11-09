using System;
using System.Collections.Generic;

public class Reflection : Activity
{
  private List<string> _prompts = new List<string>
  {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };

  private List<string> _questions = new List<string>
  {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
  };

  public Reflection(string name, string description, int duration) : base(name, description, duration)
  {
  }

  public void Run()
  {
    DisplayStartingMessage();

    Random random = new Random();
    string prompt = _prompts[random.Next(_prompts.Count)];
    
    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine();
    Console.WriteLine($"--- {prompt} ---");
    Console.WriteLine();
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
    Console.Write("You may begin in: ");
    ShowCountdown(5);
    Console.WriteLine();
    Console.WriteLine();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);
    List<string> usedQuestions = new List<string>();

    while (DateTime.Now < endTime)
    {
      string question;
      
      // Get a random question that hasn't been used yet
      if (usedQuestions.Count < _questions.Count)
      {
        do
        {
          question = _questions[random.Next(_questions.Count)];
        } while (usedQuestions.Contains(question));
        usedQuestions.Add(question);
      }
      else
      {
        // All questions used, reset and reuse
        usedQuestions.Clear();
        question = _questions[random.Next(_questions.Count)];
        usedQuestions.Add(question);
      }

      Console.Write($"> {question} ");
      ShowSpinner(10);
      Console.WriteLine();
      Console.WriteLine();
    }

    DisplayEndingMessage();
  }
}
