public abstract class Goal
{
  public string _name;
  public int _value;
  public bool _isCompleted;
  public string _type;

  public Goal(string name, int value, string type)
  {
    _name = name;
    _value = value;
    _type = type;
    _isCompleted = false;
  }

  public abstract void RecordEvent(); // Method to record an event for the goal
  public abstract string GetStatus(); // Method to get the status of the goal
}
