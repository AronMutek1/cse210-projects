using System;

class Program
{
    static void Main(string[] args)
    {
        // Sample scripture for testing
        string referenceText = "John 3:16";
        string scriptureText = "For God so loved the world that he gave his only begotten Son";

        // Create the scripture object
        Scripture scripture = new Scripture(referenceText, scriptureText);

        // Main loop to prompt the user and hide words
        while (!scripture.IsComplete())
        {
            scripture.DisplayScripture();
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
        }

        // Final display when all words are hidden
        scripture.DisplayScripture();
        Console.WriteLine("You have memorized the scripture!");
    }
}
