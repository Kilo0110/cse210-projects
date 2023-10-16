using System;
using System.Collections.Generic;

public class EternalQuestProgram
{
  private List<Goal> _goals;
  private int score;

  public EternalQuestProgram()
  {
    _goals = new List<Goal>();
    score = 0;
  }

  public void CreateGoal(string name, int value, string type, int requiredCount, int totalValue = 0)
  {
    Goal goal;
    switch (type.ToLower())
    {
      case "simple":
        goal = new SimpleGoal(name, value, "Simple Goal");
        break;
      case "eternal":
        goal = new EternalGoal(name, value, "Eternal Goal", totalValue);
        break;
      case "checklist":
        goal = new ChecklistGoal(name, value, "Checklist Goal", requiredCount);
        break;
      case "penalty":
        goal = new PenaltyGoal(name, value, "Penalty Goal");
        break;
      default:
        throw new ArgumentException("Invalid goal type.");
    }
    _goals.Add(goal);
  }

  public void RecordEvent(int index)
  {
    int goalIndex = index - 1;
    if (goalIndex >= 0 && goalIndex < _goals.Count)
    {
      var goal = _goals[goalIndex];
      goal.RecordEvent();

      if (goal._type == "penalty")
      {
        score -= goal._value;
      }
      else
      {
        score += goal._value;
      }

    }
    else
    {
      throw new IndexOutOfRangeException("Invalid goal index.");
    }
  }

  public void DisplayGoals()
  {
    Console.WriteLine("Goals:");
    foreach (Goal goal in _goals)
    {
      Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal._name} - Status: {goal.GetStatus()}");
    }
  }

  public void DisplayScore()
  {
    Console.WriteLine($"Score: {score}");
  }

  public void SaveGoals(string fileName)
  {
    using (StreamWriter writer = new StreamWriter(fileName))
    {
      foreach (Goal goal in _goals)
      {
        writer.WriteLine($"Goal name: {goal._name} \nGoal value: {goal._value} \nGoal type: {goal._type}\nStatus: {(goal._isCompleted ? "Completed" : "Not Completed")}\n");
      }
    }
  }

  public void LoadGoals(string fileName)
  {
    _goals.Clear();

    using (StreamReader reader = new StreamReader(fileName))
    {
      string line;
      Dictionary<string, string> goalData = new Dictionary<string, string>();

      while ((line = reader.ReadLine()) != null)
      {
        if (string.IsNullOrWhiteSpace(line))
        {
          // Empty line indicates the end of a goal's data, process the goal
          ProcessGoal(goalData);
          goalData.Clear();
        }
        else
        {
          string[] parts = line.Split(": ");
          if (parts.Length == 2)
          {
            string key = parts[0].Trim();
            string value = parts[1].Trim();
            goalData[key] = value;
          }
        }
      }

      // Process the last goal if there is any remaining data
      if (goalData.Count > 0)
      {
        ProcessGoal(goalData);
      }

    }

    void ProcessGoal(Dictionary<string, string> goalData)
    {
      string name = goalData["Goal name"];
      int value = int.Parse(goalData["Goal value"]);
      string type = goalData["Goal type"];
      string status = goalData["Status"];

      if (type.ToLower() == "simple goal")
      {
        SimpleGoal goal = new SimpleGoal(name, value, type);
        goal._isCompleted = status == "Completed" ? true : (status == "Not Completed" ? false : false);
        _goals.Add(goal);
      }
      else if (type.ToLower() == "eternal goal")
      {
        EternalGoal goal = new EternalGoal(name, value, type, value);
        goal._isCompleted = status == "Completed" ? true : (status == "Not Completed" ? false : false);
        _goals.Add(goal);
      }
      else if (type.ToLower() == "checklist goal")
      {
        ChecklistGoal goal = new ChecklistGoal(name, value, type, 0);
        goal._isCompleted = status == "Completed" ? true : (status == "Not Completed" ? false : false);
        _goals.Add(goal);
      }
      Console.WriteLine($"{_goals}");

    }

    /* using (StreamReader reader = new StreamReader(fileName))
    {
      string line;
      while ((line = reader.ReadLine()) != null)
      {
        string[] goalData = line.Split("\n");


        string name = goalData[0];
        int value = int.Parse(goalData[1]);
        string type = goalData[2];
        string status = goalData[3];

        if (type.ToLower() == "simple")
        {
          SimpleGoal goal = new SimpleGoal(name, value, type);
          goal._isCompleted = status == "Completed" ? true : (status == "Not Completed" ? false : false);
          _goals.Add(goal);
        }
        else if (type.ToLower() == "eternal")
        {
          EternalGoal goal = new EternalGoal(name, value, type, value);
          goal._isCompleted = status == "Completed" ? true : (status == "Not Completed" ? false : false);
          _goals.Add(goal);
        }
        else if (type.ToLower() == "checklist")
        {
          int requiredCount = int.Parse(goalData[4]);
          ChecklistGoal goal = new ChecklistGoal(name, value, type, requiredCount);
          goal._isCompleted = status == "Completed" ? true : (status == "Not Completed" ? false : false);
          _goals.Add(goal);
        }
      }
    } */
  }

}
