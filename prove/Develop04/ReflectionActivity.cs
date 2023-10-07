public class ReflectionActivity : Activity
{
  private string[] _prompts = {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
  };

  private string[] _followUpPrompts = {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
  };

  public override void StartActivity(int duration)
  {
    Console.WriteLine("");
    Console.WriteLine("Reflection Activity");
    Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    int activityDuration = base.GetActivityDuration();

    Console.WriteLine($"It will last for {activityDuration} seconds.");

    Console.WriteLine("");

    Console.WriteLine("Prepare to begin...");
    Thread.Sleep(3000); // Pause for 3 seconds

    Random random = new Random();
    int promptIndex = random.Next(_prompts.Length);
    string prompt = _prompts[promptIndex];

    Console.WriteLine(prompt);

    Thread.Sleep(3000);

    int followUpIndex = random.Next(_followUpPrompts.Length);
    string followUp = _followUpPrompts[followUpIndex];

    Console.WriteLine(followUp);

    int startTime = Environment.TickCount;
    int elapsedTime = 0;

    while (elapsedTime < activityDuration * 1000)
    {
      string item = Console.ReadLine();

      elapsedTime = Environment.TickCount - startTime;

      if (item != "")
      {
        StartActivity(activityDuration - elapsedTime);
      }
    }

    CompleteActivity();
  }
}
