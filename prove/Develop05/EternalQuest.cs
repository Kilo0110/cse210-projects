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
        goal = new SimpleGoal(name, value);
        break;
      case "eternal":
        goal = new EternalGoal(name, value, totalValue);
        break;
      case "checklist":
        goal = new ChecklistGoal(name, value, requiredCount);
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
      score += goal._value;
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
        writer.WriteLine($"Goal name: {goal._name} \nGoal value:{goal._value} \nGoal type: {goal._type}\n Status: {(goal._isCompleted ? "Completed" : "Not Completed")}\n");
      }
    }
  }

  public void LoadGoals(string fileName)
  {
    _goals.Clear();

    using (StreamReader reader = new StreamReader(fileName))
    {
      string line;
      while ((line = reader.ReadLine()) != null)
      {
        string[] goalData = line.Split(',');

        string name = goalData[0];
        int value = int.Parse(goalData[1]);
        string type = goalData[2];
        int progress = int.Parse(goalData[3]);

        if (type.ToLower() == "simple")
        {
          SimpleGoal goal = new SimpleGoal(name, value);
          goal._progress = progress;
          _goals.Add(goal);
        }
        else if (type.ToLower() == "eternal")
        {
          EternalGoal goal = new EternalGoal(name, value, value);
          goal._progress = progress;
          _goals.Add(goal);
        }
        else if (type.ToLower() == "checklist")
        {
          int requiredCount = int.Parse(goalData[4]);
          ChecklistGoal goal = new ChecklistGoal(name, value, requiredCount);
          goal._progress = progress;
          _goals.Add(goal);
        }
      }
    }
  }

}
