using System;

public abstract class Activity
{
    private readonly DateTime _date;
    private readonly double _minutes;

    protected Activity(DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected double GetMinutes() => _minutes;

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        double distance = GetDistance();
        return distance <= 0 ? 0 : (distance / _minutes) * 60;
    }

    public virtual double GetPace()
    {
        double distance = GetDistance();
        return distance <= 0 ? 0 : _minutes / distance;
    }

    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{_date:dd MMM yyyy} {GetTypeName()} ({_minutes} min) - Distance {distance:F1} miles, Speed {speed:F1} mph, Pace: {pace:F2} min per mile";
    }

    protected abstract string GetTypeName();
}
