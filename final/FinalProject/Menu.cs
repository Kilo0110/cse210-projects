using System.Collections.Generic;

public class Menu
{
  private List<Prompt> _mainMenuPrompts = new List<Prompt>();

  public Menu()
  {
    string[] prompts = { "Book a ticket", "View all events", "Remove events", "Exit" };

    foreach (string prompt in prompts)
    {
      Prompt menuPrompt = new Prompt(prompt);
      _mainMenuPrompts.Add(menuPrompt);
    }
  }

  public void DisplayMenu()
  {

    _mainMenuPrompts.ForEach(prompt =>
    {
      Console.WriteLine($"{_mainMenuPrompts.IndexOf(prompt) + 1}. {prompt.GetPrompt()}");

    });
  }
}
