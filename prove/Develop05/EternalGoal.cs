public class EternalGoal : Goal
{
  public int _totalValue;

  public EternalGoal(string name, int value, string type, int totalValue) : base(name, value, type)
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
