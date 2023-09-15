using System;

class Program
{
    static void Main(string[] args)
    {
        int userGuess;

        Console.WriteLine($"Guess My Number Game");
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        userGuess = int.Parse(Console.ReadLine());

        do
        {
            if (userGuess < number)
            {
                Console.WriteLine($"Higher ⬆️");
                Console.Write("Try again: ");
                userGuess = int.Parse(Console.ReadLine());
            } else if (userGuess > number) {
                Console.WriteLine($"Lower ⬇️");
                Console.Write("Try again: ");
                userGuess = int.Parse(Console.ReadLine());
            } else if (userGuess == number) {
                Console.WriteLine($"Congrats!!! You guessed it correctly");
            }
        } while (userGuess != number) ;
        Console.WriteLine($"Congrats!!! You guessed it correctly 🎊");
    }
}
