using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sumTotal = 0;
        int average = 0;

        bool isFinished = false;

        Console.WriteLine($"Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter a number: ");
            int newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            } else {
                isFinished = true;
            }

        } while (isFinished == false);
        foreach (int number in numbers)
        {
            sumTotal += number;
        }
        average = sumTotal / numbers.Count;

        Console.WriteLine($"The sum is: {sumTotal}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {numbers.Max()}");
    }
}
