using System;

public class Account
{
  private double _balance = 0;

  public void Deposit(double amount)
  {
    _balance += amount;
  }

  public double GetBalance() 
  {
    return _balance;
  }

  public void WithDraw(double amount)
  {
    if (amount > 0 && amount > _balance)
    {
      _balance -= amount;
    } else {
      Console.WriteLine("Error, deposit must be positive");
    }
  }
}