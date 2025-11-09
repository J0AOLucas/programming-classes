using System;

/*
 * EXCEEDING REQUIREMENTS:
 * 
 * The Reflection activity now ensures that no random questions are selected 
 * until they have all been used at least once in that session. This prevents 
 * repetition and ensures users see a variety of reflection prompts during 
 * their activity session.
 */

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;

        while (answer != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out answer))
            {
                switch (answer)
                {
                    case 1:
                        Breathing breathing = new Breathing("Breathing Activity", 
                            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                        breathing.Run();
                        break;
                    
                    case 2:
                        Reflection reflection = new Reflection("Reflection Activity", 
                            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                        reflection.Run();
                        break;
                    
                    case 3:
                        Listing listing = new Listing("Listing Activity", 
                            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                        listing.Run();
                        break;
                    
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                        break;
                    
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Please select a number between 1-4.");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
        }
    }
}