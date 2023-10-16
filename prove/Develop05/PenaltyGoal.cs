public class PenaltyGoal : Goal
{
  private int _timeCommitted;

  public override void RecordEvent()
  {
    _timeCommitted++;
  }

  public PenaltyGoal(string name, int value, string type) : base(name, value, type)
  { }

  public override string GetStatus()
  {
    if (_timeCommitted < 1)
    {
      return $"Goal has been kept so far. Keep it up";
    }
    else
    {
      return $"Goal has been broken {_timeCommitted} {(_timeCommitted < 2 ? "time" : "times")}";
    }
  }
}
