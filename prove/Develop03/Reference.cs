public class Reference
{
  private int _chapter;
  private int _startVerse;
  private int? _endVerse;

  public Reference(int chapter, int startVerse, int? endVerse = null)
  {
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = endVerse;
  }

  public override string ToString()
  {
    if (_endVerse.HasValue)
      return $"Chapter {_chapter}, Verses {_startVerse}-{_endVerse}";
    else
      return $"Chapter {_chapter}, Verse {_startVerse}";
  }
}
