using System.Numerics;

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
  }

  public void ShowComments()
  {
    if (_comments != null)
    {
      foreach(Comment comment in _comments)
      {
        Console.WriteLine($"\tAuthor: {comment._name}");
        Console.WriteLine($"\tText: {comment._text}");
        Console.WriteLine("\t------------------");
      }
    }
  }

  public int NumberOfComments()
  {
    return _comments.Count();
  }
  
}