using System;

public class Cycling : Activity
{
    private readonly double _speedMph;

    public Cycling(DateTime date, double minutes, double speedMph)
        : base(date, minutes)
    {
        _speedMph = speedMph;
    }

    public override double GetDistance()
    {
        return (_speedMph * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speedMph;
    }

    public override double GetPace()
    {
        return _speedMph <= 0 ? 0 : 60 / _speedMph;
    }

  public override double GetCalories()
  {
    return GetDistance() * 50; // moderate cycling estimate
  }

    protected override string GetTypeName()
    {
        return "Cycling";
    }
}
