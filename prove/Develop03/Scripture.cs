public class Scripture
{
  private string _reference;
  private string _text;

  public Scripture(string reference, string text)
  {
    _reference = reference;
    _text = text;
  }

  public string[] SplitText()
  {
    return _text.Split(' ');
  }

  public void DisplayFullScripture()
  {
    DisplayReference();
    Console.WriteLine(_text);
  }

  public void DisplayReference()
  {
    Console.WriteLine($"{_reference}:");
  }
}
