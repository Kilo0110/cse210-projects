using System.Collections.Generic;

public class Menu
{
  private List<string> _prompts = new List<string>();

  public void DisplayMenu()
  {
    Console.WriteLine("");
    foreach (string prompt in _prompts)
    {
      Console.WriteLine($"{_prompts.IndexOf(prompt) + 1}. {prompt}");
    }
  }

  public Menu()
  {
    _prompts.Add("Display scores.");
    _prompts.Add("Create a new goal.");
    _prompts.Add("Record an event.");
    _prompts.Add("Display all the goals.");
    _prompts.Add("Save goals.");
    _prompts.Add("Load goals.");
    _prompts.Add("Exit.");
  }
}
