using System;

sealed class EmployeePayroll
{
    private double salary;

    public EmployeePayroll(double salary)
    {
        this.salary = salary;
    }

    public double CalculateSalary()
    {
        return salary;
    }

    public double CalculateTax()
    {
        return salary * 0.10;
    }

    public double CalculateNetSalary()
    {
        return salary - CalculateTax();
    }

    static void Main()
    {
        EmployeePayroll employee = new EmployeePayroll(50000);

        Console.WriteLine("Salary: " + employee.CalculateSalary());
        Console.WriteLine("Tax: " + employee.CalculateTax());
        Console.WriteLine("Net Salary: " + employee.CalculateNetSalary());
    }
}
