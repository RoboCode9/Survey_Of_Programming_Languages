using System;
using System.IO;

// EmployeeDemo class with the main function
class EmployeeDemo
{
    static void Main()
    {
        try
        {
            // Prompt the user to enter the current year and store it in the 'currentYear' variable
            Console.Write("Enter the current year: ");
            int currentYear = int.Parse(Console.ReadLine()); // read user input and convert to int if possible

            // Read employee information from the "EmployeeInfo.txt" file and store it in an array of Employee objects
            string[] lines = File.ReadAllLines("EmployeeInfo.txt"); // read each line of the text and store each on an element in the lines array. 3 total
            Employee[] employees = new Employee[lines.Length]; // then create a array of employee objects equal to the size to the # of lines in the text

            // Parse each line of data from the file and create Employee objects for each employee
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(','); /* this code is used to split the line based on the comma and store each seperated onto an new element on data array. data[0] = John, data[1] = doe, etc.... */
                string firstName = data[0]; 
                string lastName = data[1]; 
                int idNumber = int.Parse(data[2]);
                double initialSalary = double.Parse(data[3]);
                int startYear = int.Parse(data[4]);
                employees[i] = new Employee(firstName, lastName, idNumber, initialSalary, startYear, currentYear); /* Create a new Employee object with the extracted data and store it in the employees array.
                 Each loop creates a employee object representing information on each employee.*/
            } // end for loop

            // Prompt the user to enter the range of current salary and store the minimum and maximum values in variables
            Console.Write("Enter the range of current salary (minimum salary, maximum salary): ");
            string[] salaryRange = Console.ReadLine().Split(',');
            double minSalary = double.Parse(salaryRange[0]);
            double maxSalary = double.Parse(salaryRange[1]);

            // Display employee information whose current salary is in the given range
            Console.WriteLine("\nEmployees with current salary in the specified range:");
            foreach (Employee employee in employees)
            {
                if (employee.CurSalary >= minSalary && employee.CurSalary <= maxSalary) // if salary if greater than max salary or smaller than min salary do not print this
                {
                    // Print employee information with the specified format
                    Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, ID: {employee.IDNumber}, Current Salary: {employee.CurSalary:C}");
                } // end if
            } //end foreach
        } // end try
        catch (Exception ex)
        {
            // Handle any exceptions that may occur during the execution of the program such as when entering a wrong character.
            Console.WriteLine("An error occurred: " + ex.Message);
        } // end catch
    } // end main
} // end class EmployeeDemo

// Employee class
class Employee
{
    // Private fields to store employee data
    private string firstName;
    private string lastName;
    private int idNumber;
    private double initialSalary;
    private int startYear;
    private double currentSalary;

    // Public properties to access and set the first name and last name of the employee
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    // Constructor to initialize the Employee object with provided data
    public Employee(string firstName, string lastName, int idNumber, double initialSalary, int startYear, int currentYear)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.idNumber = idNumber;
        this.initialSalary = initialSalary;
        this.startYear = startYear;
        this.currentSalary = CalcCurSalary(currentYear); // Calculate and set the current salary upon object creation
    }

    // Public property to get the read-only current salary of the employee
    public double CurSalary
    {
        get { return currentSalary; }
    }

    // Public property to get the ID number of the employee
    public int IDNumber
    {
        get { return idNumber; }
    }

    // Private method to calculate the current salary based on a 5% yearly increment from the startYear
    private double CalcCurSalary(int currentYear)
    {
        int yearsPassed = currentYear - startYear;
        double incrementPercentage = 0.05;
        double updatedSalary = initialSalary;

        // Apply the yearly increment to the initial salary for each year passed
        for (int i = 0; i < yearsPassed; i++)
        {
            updatedSalary += updatedSalary * incrementPercentage;
        } // end for loop

        return updatedSalary; // Return the calculated current salary
    } // end calculatecursalary
} // end employee class