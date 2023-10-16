public class SimpleGoal : Goal
{
  public SimpleGoal(string name, int value, string type) : base(name, value, type)
  {
  }

  public override void RecordEvent()
  {
    _isCompleted = true;
  }

  public override string GetStatus()
  {
    return _isCompleted ? "Completed" : "Not Completed";
  }
}
