public class Word
{
  private string _word;
  private bool _hidden;

  public Word(string word)
  {
    _word = word;
    _hidden = false;
  }

  public void Hide()
  {
    _hidden = true;
  }

  public void UnHide()
  {
    _hidden = false;
  }

  public string Display()
  {
    string word;
    if (_hidden == false)
    {
      word = _word;
    } else {
      word = new string('_', _word.Count());
    }
    return word;
  }

  public bool IsHidden()
  {
    return _hidden;
  }
}