public class BreathingActivity : Activity
{
  public override void StartActivity(int duration)
  {
    Console.WriteLine("");
    Console.WriteLine("> Breathing Activity");
    Console.WriteLine("This activity will guide you through a breathing exercise to help you relax and focus.");

    int activityDuration = base.GetActivityDuration();

    Console.WriteLine($"It will last for {activityDuration} seconds.");

    Console.WriteLine("");

    Console.WriteLine("Prepare to begin...");
    Thread.Sleep(3000); // Pause for 3 seconds

    Console.WriteLine("Focus on your breath and follow the instructions:");

    int startTime = Environment.TickCount;
    int elapsedTime = 0;

    while (elapsedTime < activityDuration * 1000)
    {
      Console.WriteLine("Inhale deeply...");
      Thread.Sleep(2000); // Pause for 2 seconds

      Console.WriteLine("Exhale slowly...");
      Thread.Sleep(2000); // Pause for 2 seconds

      elapsedTime = Environment.TickCount - startTime;
    }

    CompleteActivity();
  }
}
