public class Entry
{
  public string _prompt;
  public string _response;
  public DateTime _date;

  public Entry(DateTime entryDate, string prompt, string response)
  {
    _date = entryDate;
    _prompt = prompt;
    _response = response;
  }

}
