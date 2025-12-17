using System;

public abstract class Event
{
    private readonly string _title;
    private readonly string _description;
    private readonly DateTime _dateTime;
    private readonly Address _address;

    protected Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    protected string GetCommonDetails()
    {
        return $"{_title}\n{_description}\nDate: {_dateTime:dd/MM/yyyy}\nTime: {_dateTime:HH:mm}\nAddress: {_address.GetFullAddress()}";
    }

    public string StandardDetails()
    {
        return GetCommonDetails();
    }

    public abstract string FullDetails();

    public string ShortDescription()
    {
        return $"{GetEventType()} - {_title} ({_dateTime:dd/MM/yyyy})";
    }

    protected abstract string GetEventType();
}
