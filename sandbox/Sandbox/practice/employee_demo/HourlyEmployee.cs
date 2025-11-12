public class HourlyEmployee : Employee
{
    private float _payRate = 0;
    private int _hoursWorked = 0;

    public float GetPayRate()
    {
        return _payRate;
    }

    public void SetPayRate(float payrate)
    {
        _payRate = payrate;
    }

    public int GetHoursWorded()
    {
        return _hoursWorked;
    }

    public void SetHoursWorked(int hoursWorded)
    {
        _hoursWorked = hoursWorded;
    }

    public override float GetPay()
    {
        return _hoursWorked * _payRate;
    }
}