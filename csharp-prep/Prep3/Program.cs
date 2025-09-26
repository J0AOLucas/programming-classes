using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number and transform to integer.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        // Getting the guess number from user.
        int guess = 0;

        // Doing the loop everytime that the answer is different.
        while (guess != magicNumber) {
            Console.Write("What is your guess? ");
            string guessAnswer = Console.ReadLine();
            guess = int.Parse(guessAnswer);

            if (guess > magicNumber) {
                Console.WriteLine("Lower");
            } else if (guess < magicNumber) {
                Console.WriteLine("Higher");
            }
        }


        Console.WriteLine("You guessed it!");
    }
}