using System.Collections.Generic;
using System.Text.Json;

public class Scripture
{
  private List<Word> _words = new List<Word>();
  private Reference _reference = new Reference("Book",2,3);

  public Scripture(string text, Reference reference)
  {
    List<string> _newWords = text.Split(" ").ToList();
    for (int i = 0; i < _newWords.Count();i++)
    {
      Word word = new Word(_newWords[i]);
      _words.Add(word);
    }
    _reference = reference;
  }

  public void DisplayScripture()
  {
    for (int i = 0; i < _words.Count(); i++)
    {
      Console.Write($"{_words[i].Display()} ");
    }
  }

  public void HideWords()
  {
    Random random = new Random();
    int idx = random.Next(0, _words.Count());
    for (int i = 0; i < 3; i++)
    {
      while (_words[idx].IsHidden() && AllWordsHidden() == false)
      {
        idx = random.Next(0, _words.Count());
      }
      _words[idx].Hide();
    }
  }

  public bool AllWordsHidden()
  {
    for (int i = 0; i < _words.Count(); i++)
    {
      if (_words[i].IsHidden() == false)
      {
        return false;
      }
    }
    return true;
  }

  public (string, Reference) GetRandomScripture()
  {
      string filePath = "scriptures.json";
      string jsonString = File.ReadAllText(filePath);

      var scripturesList = JsonSerializer.Deserialize<List<ScriptureJSON>>(
          JsonDocument.Parse(jsonString).RootElement.GetProperty("scriptures").GetRawText()
      );

      Random random = new Random();
      int idx = random.Next(scripturesList.Count);
      var selected = scripturesList[idx];

      Reference reference;
      if (selected.endVerse > 0) {
          reference = new Reference(selected.book, selected.chapter, selected.verse, selected.endVerse);
      } else {
          reference = new Reference(selected.book, selected.chapter, selected.verse);
      }

      return (selected.text, reference);
  }

  public class ScriptureJSON
  {
      public string book { get; set; }
      public int chapter { get; set; }
      public int verse { get; set; }
      public int endVerse { get; set; }
      public string text { get; set; }
  }
}