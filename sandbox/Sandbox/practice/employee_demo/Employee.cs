public abstract class Employee
{
    private string _name;
    private string _idNumber;

    public Employee()
    {
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }

    public void SetIdNumber(string idNumber)
    {
        _idNumber = idNumber;
    }

    public abstract float GetPay();

}