using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public Journal()
  {

  }

  public void AddEntry(Entry entry)
  {
    _entries.Add(entry);
    Console.WriteLine($"Entry added successfully");
  }

  private void WriteEntry(string username, string filename)
  {
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      outputFile.WriteLine($"{username}'s Journal");

      foreach (var entry in _entries)
      {
        outputFile.WriteLine($"Date: {entry._date}");
        outputFile.WriteLine($"Prompt: {entry._prompt}");
        outputFile.WriteLine($"Response: {entry._response}");
        outputFile.WriteLine();
      }
    }
  }

  public void DisplayEntries()
  {
    foreach (var entry in _entries)
    {
      Console.WriteLine($"Date: {entry._date}");
      Console.WriteLine($"Prompt: {entry._prompt}");
      Console.WriteLine($"Response: {entry._response}");
      Console.WriteLine();
    }
  }

  public void SaveToFile(string username, string filename)
  {
    // Implement saving journal entries to a file.
    WriteEntry(username, filename);
    Console.WriteLine($"File saved successfully");
  }

  public void LoadFromFile(string filename)
  {
    // Clear the previous entries
    _entries.Clear();

    try
    {
      string[] lines = File.ReadAllLines(filename);
      for (int i = 1; i < lines.Length; i += 4)
      {
        if (i + 3 < lines.Length)
        {
          string dateStr = lines[i].Substring(lines[i].IndexOf(':') + 2);
          string prompt = lines[i + 1].Substring(lines[i + 1].IndexOf(':') + 2);
          string response = lines[i + 2].Substring(lines[i + 2].IndexOf(':') + 2);

          if (DateTime.TryParse(dateStr, out DateTime date))
          {
            Entry newEntry = new Entry(date, prompt, response);
            _entries.Add(newEntry);
          }
          else
          {
            Console.WriteLine($"Error parsing date on line {i + 1}");
          }
        }
        else
        {
          Console.WriteLine($"Incomplete entry starting at line {i + 1}");
        }
      }

      Console.WriteLine("Journal loaded successfully.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error loading journal from file: {ex.Message}");
    }
  }

}
