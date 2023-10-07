using System;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Activities Program");
        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");

        int activityChoice;
        do
        {
            Console.Write("Enter your choice (1-3): ");
            int.TryParse(Console.ReadLine(), out activityChoice);
        } while (activityChoice < 1 || activityChoice > 3);

        Activity activity;

        if (activityChoice == 1)
        {
            activity = new BreathingActivity();
        }
        else if (activityChoice == 2)
        {
            activity = new ReflectionActivity();
        }
        else
        {
            activity = new ListingActivity();
        }

        Console.WriteLine("Please enter the duration of the activity in seconds:");

        activity.SetActivityDuration(int.Parse(Console.ReadLine()));

        int duration = activity.GetActivityDuration();

        activity.StartActivity(duration);
    }
}
