using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the program!");
        }

        static string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber ()
        {
            Console.Write("Please enter your favourite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber (int favouriteNumber)
        {
            int numberSquared = favouriteNumber * favouriteNumber;
            return numberSquared;
        }

        static void DisplayResult (string userName, int favouriteNumberSquared)
        {
            Console.WriteLine($"{userName}, the square of your number is {favouriteNumberSquared}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int favouriteNumberSquared = SquareNumber(userNumber);
        DisplayResult(userName, favouriteNumberSquared);
    }
}
