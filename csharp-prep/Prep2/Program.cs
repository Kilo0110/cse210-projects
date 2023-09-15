using System;

class Program
{
    static void Main(string[] args)
    {
        char letter = 'X';
        char sign = ' ';

        Console.Write("What is your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else if (gradePercentage < 60)
        {
            letter = 'F';
        }

        // Determine the sign
        int lastDigit = gradePercentage % 10;
        if (lastDigit >= 7)
        {
            sign = '+';
        }
        else if (lastDigit < 3)
        {
            sign = '-';
        }

        // Handle exceptional cases
        if (letter == 'A' && sign == '+')
        {
            letter = 'A';
            sign = ' ';
        }
        else if (letter == 'F' && (sign == '+' || sign == '-'))
        {
            letter = 'F';
            sign = ' ';
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations!!! You passed!!! 🎊");
        }
        else
        {
            Console.WriteLine($"Uh oh!!! You failed to reach the pass mark this time, but don't worry, you can try again! 🦾");
        }
    }
}
