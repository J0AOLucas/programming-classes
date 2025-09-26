using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
     static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        int birthYear;

        PromptUserBirthYear(out birthYear);

        DisplayResult(name, square, birthYear);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string numberInput = Console.ReadLine();
        int number = int.Parse(numberInput);
        return number;
    }

    static void PromptUserBirthYear(out int birthYear){
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    
    static int SquareNumber(int number){
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear){
        Console.WriteLine($"Brother {name}, the square of your number is {square}.");
        Console.WriteLine($"Brother {name}, you will turn {2025 - birthYear}.");
    }

}