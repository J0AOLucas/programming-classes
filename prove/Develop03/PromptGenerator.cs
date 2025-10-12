using System;
using System.Collections.Generic;

public class PromptGenerator
{
  public List<string> _prompts = new List<string>();
  Random random = new Random();

  public PromptGenerator() {
    _prompts.Add("Who was the most interesting person I interacted with today?");
    _prompts.Add("What was the best part of my day?");
    _prompts.Add("What was the worst part of my day?");
    _prompts.Add("How did I see the hand of the Lord in my life today?");
    _prompts.Add("What was the strongest emotion I felt today?");
    _prompts.Add("If I had one thing I could do over today, what would it be?");
    _prompts.Add("What was something new I learned today?");
    _prompts.Add("What am I grateful for today?");
    _prompts.Add("What challenge did I overcome today?");
    _prompts.Add("What did I learn today?");
    _prompts.Add("What did I achieve today?");
    _prompts.Add("What did I struggle with today?");
    _prompts.Add("What did I enjoy today?");
    _prompts.Add("What did I feel today?");
    _prompts.Add("What did I think about today?");
  }

  public string GetPrompt() {
    int list_size = _prompts.Count;
    int idx = random.Next(list_size);
    return _prompts[idx];
  }
}