using System;
using System.Numerics;
using System.Text;

public class Video
{
  public string _title;
  public string _author;
  public int _lenght;
  public List<Comment> _comments;

  public Video(string title, string author, int lenght) {
    _title = title;
    _author = author;
    _lenght = lenght;
    _comments = new List<Comment>();
  }
  
  public void ShowDetails()
  {
    Console.WriteLine($"Video Title: {_title}");
    Console.WriteLine($"Video Author: {_author}");
    Console.WriteLine($"Duration: {GetDurationFormatted()}");
    Console.WriteLine($"Total Comments: {NumberOfComments()}");
  }

  public void ShowComments()
  {
    if (_comments != null && _comments.Count > 0)
    {
      foreach(Comment comment in _comments)
      {
        Console.WriteLine($"\tAuthor: {comment._name}");
        Console.WriteLine($"\tText: {comment._text}");
        Console.WriteLine("\t------------------");
      }
    }
    else
    {
      Console.WriteLine("\tNo comments yet.");
    }
  }

  public int NumberOfComments()
  {
    return _comments?.Count ?? 0;
  }

  public string GetSummaryLine()
  {
    return $"{_title} by {_author} - {GetDurationFormatted()} ({NumberOfComments()} comments)";
  }

  public string GetDurationFormatted()
  {
    TimeSpan duration = TimeSpan.FromSeconds(_lenght);
    return $"{(int)duration.TotalMinutes:D2}m {duration.Seconds:D2}s";
  }
  
}