using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int answer = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (answer != 0) {
            Console.Write("Enter a number: ");
            string userAnswer = Console.ReadLine();
            answer = int.Parse(userAnswer);

            // Adding the number to the list.
            if (answer != 0) {
                numbers.Add(answer);
            }
        }

        // Calculating the total.
        float total = 0;
        foreach (int number in numbers) {
            total += number;
        }

        // Calculating the Average.
        float average = total / numbers.Count();

        // Getting the largest and smallest number.
        int biggestNumber = numbers[0];
        int smallestNumber = numbers[0];
        foreach (int number in numbers) {
            // Getting the bigger.
            if (number > biggestNumber) {
                biggestNumber = number;
            }
            // Getting the smaller.
            if (number < smallestNumber && number >= 0) {
                smallestNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {biggestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");

        // Sorting a list
        numbers.Sort();
        foreach (int number in numbers) {
            Console.WriteLine(number);
        }
    }
}