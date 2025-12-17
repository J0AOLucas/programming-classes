using System;

public class Reception : Event
{
    private readonly string _rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail)
        : base(title, description, dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return $"Type: {GetEventType()}\n{StandardDetails()}\nRSVP: {_rsvpEmail}";
    }

    protected override string GetEventType()
    {
        return "Reception";
    }
}
