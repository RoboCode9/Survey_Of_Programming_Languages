using System;

class Assignment4
{
    static void Main()
    {
        // Call the functions to get the rectangle's length, width, and area
        double length = GetLength();
        double width = GetWidth();
        double area = GetArea(length, width);

        // Display the rectangle's length, width, and area
        DisplayData(length, width, area);
    }

    // Function to get the rectangle's length
    static double GetLength()
    {
        double length;
        do
        {
            Console.Write("Enter the length of the rectangle: ");
        } while (!double.TryParse(Console.ReadLine(), out length) || length < 0);

        /* !double.TryParse(Console.ReadLine(), out length), will check if the input gathered by the user can be converted to a double if it cannot it will return true and vice versa thus continuing the while loop if true. After the double.tryparse successfuly converts the input from the user to a double it will check if the double is less than zero "length < 0", if the input is less than zero it will also return true thus continuing the while loop again until it is false.*/

        return length;
    }

    // Function to get the rectangle's width
    static double GetWidth()
    {
        double width;
        do
        {
            Console.Write("Enter the width of the rectangle: ");
        } while (!double.TryParse(Console.ReadLine(), out width) || width < 0); // same concept as on line 23, but instead its for the width.

        return width;
    }

    // Function to calculate the rectangle's area
    static double GetArea(double length, double width)
    {
        return length * width; // multiply length & width to get area
    }

    // Function to display the rectangle's length, width, and area
    static void DisplayData(double length, double width, double area)
    {
        Console.WriteLine("Rectangle Information:");
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + area);
    }
}
