public abstract class Activity
{
  private int _duration;

  public abstract void StartActivity(int duration);

  public void SetActivityDuration(int duration)
  {
    _duration = duration;
  }

  public int GetActivityDuration()
  {
    return _duration;
  }

  public void PauseActivity()
  {
    Console.WriteLine("Pausing activity...");
    // Show animation or countdown timer
  }

  public void CompleteActivity()
  {
    Console.WriteLine("Good job! You have completed the activity.");
    Thread.Sleep(3000); // Pause for 3 seconds
  }
}
