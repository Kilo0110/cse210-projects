using System;

class Program
{
	static void Main(string[] args)
	{
		Journal journal = new Journal();
		PromptGenerator promptGenerator = new PromptGenerator();

		Console.Write("Welcome to your journal. What's your name? ");
		string name = Console.ReadLine();
		Console.WriteLine($"Welcome {name}");


		while (true)
		{
			Console.WriteLine($"");

			Console.WriteLine("1. Write a new entry");
			Console.WriteLine("2. Display the journal");
			Console.WriteLine("3. Save the journal to a file");
			Console.WriteLine("4. Load the journal from a file");
			Console.WriteLine("5. Exit");
			Console.Write("Enter your choice: ");

			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					DateTime date = DateTime.Now;
					string prompt = promptGenerator.GetRandomPrompt();
					Console.WriteLine("Prompt: " + prompt);
					Console.Write("Response: ");
					string response = Console.ReadLine();
					Entry newEntry = new Entry(date, prompt, response);
					journal.AddEntry(newEntry);
					break;

				case "2":
					journal.DisplayEntries();
					break;

				case "3":
					Console.Write("Enter the filename to save the journal: ");
					string saveFilename = Console.ReadLine();
					journal.SaveToFile(name, saveFilename);
					break;

				case "4":
					Console.Write("Enter the filename to load the journal: ");
					string loadFilename = Console.ReadLine();
					journal.LoadFromFile(loadFilename);
					break;

				case "5":
					Environment.Exit(0);
					break;

				default:
					Console.WriteLine("Invalid choice. Please try again.");
					break;
			}
		}
	}
}
