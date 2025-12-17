using System;

public class OutdoorGathering : Event
{
    private readonly string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weatherForecast)
        : base(title, description, dateTime, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string FullDetails()
    {
        return $"Type: {GetEventType()}\n{StandardDetails()}\nExpected weather: {_weatherForecast}";
    }

    protected override string GetEventType()
    {
        return "Outdoor Gathering";
    }
}
