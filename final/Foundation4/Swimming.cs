using System;

public class Swimming : Activity
{
    private readonly int _laps;

    public Swimming(DateTime date, double minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; // miles
    }

  public override double GetCalories()
  {
    return GetDistance() * 130; // lap swimming estimate
  }

    protected override string GetTypeName()
    {
        return "Swimming";
    }
}
