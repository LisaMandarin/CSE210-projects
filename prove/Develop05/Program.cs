using System;

class Program
{
    static void Main(string[] args)
    {
        // List<Employee> employees = new List<Employee>();
        // employees.Add(new Employee());
        // employees.Add(new HourlyEmployee());
        // foreach (Employee employee in employees)
        // {
        //     Console.WriteLine(employee.CalculatePay());
        // }
        // HourlyEmployee e1 = new HourlyEmployee();
        // e1._employeeName = "Amanda";
        // float pay1 = e1.CalculatePay();
        // SalaryEmployee e2 = new SalaryEmployee();
        // e2._employeeName = "Bella";
        // float pay2 = e2.CalculatePay();
        // Console.WriteLine($"{e1._employeeName} - {pay1}");
        // Console.WriteLine($"{e2._employeeName} - {pay2}");
    // }
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("John");
        hEmployee.SetId("123abc");
        hEmployee.SetRate(15);
        hEmployee.SetHours(35);
        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetId("456def");
        sEmployee.SetSalary(60000);

        DisplayEmployeeInfo(hEmployee);
        DisplayEmployeeInfo(sEmployee);

        List<Employee> employees = new List<Employee>();
        employees.Add(hEmployee);
        employees.Add(sEmployee);
        foreach (Employee emp in employees)
        {
            string name = emp.GetName();
            string id = emp.GetId();
            float pay = emp.GetPay();
            Console.WriteLine($"{name}({id}) will be paid {pay}.");
        }
    }
    public static void DisplayEmployeeInfo(Employee employee)
        {
            // Console.WriteLine($"{employee.GetName()}");
            float pay = employee.GetPay();
            Console.WriteLine($"{employee.GetName()} will be paid ${pay}");
        }
}