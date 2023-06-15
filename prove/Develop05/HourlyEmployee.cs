// public class HourlyEmployee : Employee
// {
//     private float rate = 9f;
//     private float hours = 100f;
//     public override float CalculatePay()
//     {
//         return rate * hours;
//     }
// }

public class HourlyEmployee: Employee
{
    private float _rate = 0;
    private int _hours = 0;
    public float GetRate()
    {
        return _rate;
    }
    public void SetRate(float rate)
    {
        _rate = rate;
    }
    public int GetHours()
    {
        return _hours;
    }
    public void SetHours(int hours)
    {
        _hours = hours;
    }
    public override float GetPay()
    {
        return _rate * _hours;
    }
}
