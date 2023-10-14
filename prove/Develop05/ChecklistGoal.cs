public class ChecklistGoal : Goal
{
  private int _requiredCount;
  private int _completedCount;

  public ChecklistGoal(string name, int value, int requiredCount) : base(name, value)
  {
    _requiredCount = requiredCount;
    _completedCount = 0;
  }

  public override void RecordEvent()
  {
    _completedCount++;
    if (_completedCount >= _requiredCount)
    {
      _isCompleted = true;
      _value += _value * _requiredCount; // Bonus points
    }
    else
    {
      _value += _value; // Regular points
    }
  }

  public override string GetStatus()
  {
    return $"Completed {_completedCount}/{_requiredCount} times";
  }
}
