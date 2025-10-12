using System;

/*
 * CREATIVITY AND EXCEED REQUIREMENTS:
 
 * Problem Addressed: Lack of motivation to keep journaling consistently
 * 
 * Solution Implemented: Statistics feature (Option 5) that shows:
 * - Total number of entries
 * - Entries written this month
 * - Date of last entry
 * - Motivational messages based on progress
  
 * This helps users see their progress and stay motivated to continue journaling.
 * The feature addresses the common problem of people losing motivation because
 * they don't see the value or progress in their journaling habit.
 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running) 
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Statistics");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice) 
            {
                case "1":
                    string prompt = promptGenerator.GetPrompt();
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    
                    Entry entry = new Entry();
                    entry._text = response;
                    entry._prompt = prompt;
                    entry._date = DateTime.Now;
                    
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry saved successfully!");
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("What is the filename? ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "4":
                    Console.Write("What is the filename? ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "5":
                    journal.ShowStatistics();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Thank you for using the Journal Program!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-6.");
                    break;
            }
        }
    }
}