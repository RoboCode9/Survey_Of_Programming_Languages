using System;

class EmployeeTest
{
    static void Main(string[] args)
    {
        // Create two Employee objects
        Employee emp1 = new Employee("John", "Doe", -1000); //used negative number for testing purposes.
        Employee emp2 = new Employee("Jane", "Smith", 6000);

        // Display initial yearly salaries
        Console.WriteLine("Initial Yearly Salaries:");
        PrintYearlySalary(emp1);
        PrintYearlySalary(emp2);

        // Give a 10% raise to both employees
        emp1.GiveRaise();
        emp2.GiveRaise();

        // Display updated yearly salaries
        Console.WriteLine("\nAfter 10% Raise:");
        PrintYearlySalary(emp1);
        PrintYearlySalary(emp2);

        Console.ReadLine();
    }

    // Method to print yearly salary
    static void PrintYearlySalary(Employee emp)
    {
        Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.GetYearlySalary()}");
    }
}

class Employee
{
    // Auto-implemented properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double MonthlySalary { get; set; }

    // Default constructor
    public Employee()
    {
    }

    // Constructor with initialization
    public Employee(string firstName, string lastName, double monthlySalary)
    {
        FirstName = firstName;
        LastName = lastName;
        MonthlySalary = monthlySalary >= 0 ? monthlySalary : 0; 
        /* if "monthlySalary" is greater than or equal to zero then set it to "MonthlySalary", otherwise if this is false assign "monthlySalary" to zero then assign "monthlySalary" to "MonthlySalary" */
    }

    // Calculate and return yearly salary
    public double GetYearlySalary()
    {
        return MonthlySalary * 12;
    }

    // Give a 10% raise to the monthly salary
    public void GiveRaise()
    {
        MonthlySalary *= 1.1;
    }
}