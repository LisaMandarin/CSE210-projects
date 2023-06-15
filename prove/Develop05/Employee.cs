// public abstract class Employee
// {
    // private float salary = 100f;
    // public virtual float CalculatePay()
    // {
    //     return salary;
    // }
    // public string _employeeName;
    // public abstract float CalculatePay();

// }
public abstract class Employee
{
    protected string _name;
    protected string _id;

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
    public string GetId()
    {
        return _id;
    }
    public void SetId(string id)
    {
        _id = id;
    }
    public abstract float GetPay();
    
}