using System;
using System.Collections.Generic;
using System.Security.Cryptography;

// The integer value clone the value to another point in memory while
// an array can't do that. Duplicating arrays in memory costs a lot of memory.
// int x = 10 and int y = x    it will be different points.
// int[] dataArray = new int[] {1,2,3,4} and int[] newArray = dataArray   - this will reference
// the name point in memory instead of creating a new one.

class Program {
  static void Main(string[] args) {
    int x = 2;
    int y = 3;
    int sum = Adder(x, y);
    Console.WriteLine(sum);
    string someonesName = "Lucas";
    GreetUser(someonesName);
    Console.WriteLine($"x before {x}");
    ChangeValue(x);
    Console.WriteLine($"x after {x}");

    int[] myArray = new int[] { 1, 2, 3, 4, 5};

    Console.Write("Before: ");

    foreach (int number in myArray) {
      Console.Write($"{number} ");
    }

    changeReference(myArray);
    Console.Write("After: ");
    foreach (int number in myArray) {
      Console.Write($"{number} ");
    }

  }

  static int Adder(int a, int b){
    return a + b;
  }

  static void ChangeValue(int x) {
    x = 100;
  }

  static void changeReference(int[] data) {
    data[2] = 100;
  }

  static void GreetUser(string firstName) {
    Console.WriteLine($"Hello, {firstName}");
  }
}