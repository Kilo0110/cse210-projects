public class EternalGoal : Goal
{
  public int _totalValue;

  public EternalGoal(string name, int value, int totalValue) : base(name, value)
  {
    _totalValue = totalValue;
  }

  public override void RecordEvent()
  {
    _value += _totalValue;
  }

  public override string GetStatus()
  {
    return $"Current Value: {_value}";
  }
}
