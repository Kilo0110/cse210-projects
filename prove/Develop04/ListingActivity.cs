public class ListingActivity : Activity
{
  private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

  public override void StartActivity(int duration)
  {
    Console.WriteLine("");
    Console.WriteLine("Listing Activity");
    Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    Console.WriteLine("Please enter the duration of the activity in seconds:");

    int activityDuration = base.GetActivityDuration();

    Console.WriteLine("Prepare to begin...");
    Thread.Sleep(3000); // Pause for 3 seconds

    Random random = new Random();
    int promptIndex = random.Next(_prompts.Length);
    string prompt = _prompts[promptIndex];

    Console.WriteLine(prompt);
    Console.WriteLine($"You have {activityDuration} seconds to list as many items as you can.");

    int startTime = Environment.TickCount;
    int elapsedTime = 0;
    int itemCount = 0;

    while (elapsedTime < activityDuration * 1000)
    {
      string item = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(item))
      {
        itemCount++;
      }

      elapsedTime = Environment.TickCount - startTime;
    }

    if (itemCount < 2)
    {
      Console.WriteLine($"You listed {itemCount} item.");

    }
    else
    {
      Console.WriteLine($"You listed {itemCount} items.");

    }

    CompleteActivity();
  }
}
