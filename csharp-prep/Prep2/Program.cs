using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type your grade percentage: ");
        string gradeText = Console.ReadLine();
        int grade = int.Parse(gradeText);
        string letter;

        if (grade >= 90) {
            letter = "A";
        } else if (grade >= 80) {
            letter = "B";
        } else if (grade >= 70) {
            letter = "C";
        } else if (grade >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }
        
        int sign = grade % 10;
        string signSymbol;

        if (sign >= 7 && letter != "A" && letter != "F") {
            signSymbol = "+";
        } else if (sign < 3 && letter != "F") {
            signSymbol = "-";
        } else {
            signSymbol = "";
        }
        

        Console.WriteLine($"Your grade was {letter}{signSymbol}.");
        if (grade >= 70) {
            Console.WriteLine("Congratulations, you passed in the course!");
        } else {
            Console.WriteLine("You didn't pass in the course. But keep going, you were really good!");
        }

    }
}