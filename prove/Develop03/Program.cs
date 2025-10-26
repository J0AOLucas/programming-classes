using System;

// Exceeding requirements: I added a file with different scriptures.
// My code can read it and check for a random scripture.

class Program
{
    static void Main(string[] args)
    {
        Scripture temp = new Scripture("", new Reference("Book", 1, 1));
        var (text, reference) = temp.GetRandomScripture();

        Scripture scripture = new Scripture(text, reference);

        string answer = "";

        while (answer != "quit")
        {
            Console.Clear();
            Console.Write(reference.GetReference());
            scripture.DisplayScripture();
            Console.WriteLine("\n");

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();

            if (scripture.AllWordsHidden())
            {
                answer = "quit";
            }

            scripture.HideWords();
        }
    }
}