using System;

class Employee
{
    
    int employeeId;
    string name;
    double salary;

    
    public Employee()
    {
        employeeId = 0;
        name = "Unknown";
        salary = 0;
    }

   
    public Employee(int id, string n, double sal)
    {
        employeeId = id;
        name = n;
        salary = sal;
    }

    
    public double CalculateAnnualSalary()
    {
        return salary * 12;
    }

   
    public void DisplayEmployee()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Monthly Salary: " + salary);
        Console.WriteLine("Annual Salary: " + CalculateAnnualSalary());
    }

   
    static void Main(string[] args)
    {
        
        Employee emp1 = new Employee(101, "Rahul", 25000);

        
        emp1.DisplayEmployee();

        Console.ReadLine();
    }
}