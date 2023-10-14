public abstract class Goal
{
  public string _name;
  public int _value;
  public bool _isCompleted;
  public string _type;
  public int _progress;

  public Goal(string name, int value)
  {
    _name = name;
    _value = value;
    _isCompleted = false;
  }

  public abstract void RecordEvent(); // Method to record an event for the goal
  public abstract string GetStatus(); // Method to get the status of the goal
}
