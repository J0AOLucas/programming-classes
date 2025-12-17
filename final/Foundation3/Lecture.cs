using System;

public class Lecture : Event
{
    private readonly string _speaker;
    private readonly int _capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity)
        : base(title, description, dateTime, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"Type: {GetEventType()}\n{StandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity} people";
    }

    protected override string GetEventType()
    {
        return "Lecture";
    }
}
