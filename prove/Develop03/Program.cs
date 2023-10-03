using System;

class Program
{
    private static Random random = new Random();

    public static void Main()
    {
        // Initialize scriptures
        Scripture scriptureOne = new Scripture("[John 3:16]", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Scripture scriptureTwo = new Scripture("[Matthew 21:1]", "When they came near to Jerusalem, and came to Bethsphage, to the Mount of Olives, then Jesus sent two disciples.");
        Scripture scriptureThree = new Scripture("[Ezekiel 30:3]", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Scripture scriptureFour = new Scripture("[Acts 6:8]", "Stephen, full of faith and power, performed great wonders and signs among the people.");
        Scripture scriptureFive = new Scripture("[1 Kings 2:1]", "Now the days of David drew nigh that he should die; and he charged Solomon his son, saying,");

        // Initialize a list of Scriptures
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(scriptureOne);
        scriptures.Add(scriptureTwo);
        scriptures.Add(scriptureThree);
        scriptures.Add(scriptureFour);
        scriptures.Add(scriptureFive);

        // Select a random scripture from the list
        Scripture scripture = scriptures[random.Next(1, scriptures.Count)];

        // Create a list of words from the scripture
        List<Word> words = new List<Word>();
        string[] wordArray = scripture.SplitText();

        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            words.Add(word);
        }

        // Main logic of the program
        Console.Clear();
        scripture.DisplayFullScripture();
        Console.WriteLine();

        bool allWordsHidden = false;

        while (true)
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (!allWordsHidden)
            {
                HideRandomWords(words);

                if (AreAllWordsHidden(words))
                    allWordsHidden = true;

                Console.Clear();
                scripture.DisplayReference();

                foreach (Word word in words)
                {
                    if (word._isHidden)
                        Console.Write("____ ");
                    else
                        word.DisplayText();
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("All words are hidden. Exiting the program.");
                break;
            }
        }
    }

    private static void HideRandomWords(List<Word> words)
    {
        int wordsToHide = random.Next(1, words.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(words.Count);

            if (!words[randomIndex]._isHidden)
                words[randomIndex]._isHidden = true;
        }
    }

    private static bool AreAllWordsHidden(List<Word> words)
    {
        foreach (Word word in words)
        {
            if (!word._isHidden)
                return false;
        }

        return true;
    }
}
