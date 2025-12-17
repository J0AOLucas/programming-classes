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

    protected override string GetTypeName()
    {
        return "Swimming";
    }
}
