using System;

public class Running : Activity
{
    private readonly double _distanceMiles;

    public Running(DateTime date, double minutes, double distanceMiles)
        : base(date, minutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return _distanceMiles;
    }

    protected override string GetTypeName()
    {
        return "Running";
    }
}
