using System;

// RoomInfoDemo class created
class RoomInfoDemo
{
    static void Main()
    {
        RoomInfo[] rooms = new RoomInfo[4]; // Create an array of four RoomInfo objects

        // Loop to collect room data from the user
        for (int i = 0; i < rooms.Length; i++)
        {
            rooms[i] = new RoomInfo(); // Initialize each element of the array
            Console.WriteLine($"Enter the length of Room {i + 1} (in meters):");
            rooms[i].Length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter the width of Room {i + 1} (in meters):");
            rooms[i].Width = Convert.ToDouble(Console.ReadLine());

            // Loop to validate TV availability input
            Console.WriteLine($"Is there a TV in Room {i + 1}? (Y/N):");
            char hasTVInput;
            while (true)
            {
                hasTVInput = Console.ReadKey().KeyChar;
                if (hasTVInput == 'Y' || hasTVInput == 'y')
                {
                    rooms[i].HasTV = true;
                    break;
                }
                else if (hasTVInput == 'N' || hasTVInput == 'n')
                {
                    rooms[i].HasTV = false;
                    break;
                }
                else // if not y, Y, N, or n then go to this else statement
                {
                    Console.WriteLine("\nInvalid input. Please enter 'Y' or 'N'.");
                }
            }
            Console.WriteLine("\n");
        }

        // Loop to display room information for each room
        foreach (RoomInfo room in rooms)
        {
            room.CalcRoomSize(); // Calculate the room size for each room
            Console.WriteLine($"Room size: {room.Length}m x {room.Width}m"); // Display room size
            Console.WriteLine($"Room has TV: {(room.HasTV ? "Yes" : "No")}\n"); // Display whether the room has a TV
        }

        Console.WriteLine($"Total house size: {RoomInfo.HouseSize} square meters"); // Display the total house size
        Console.WriteLine($"Number of rooms with TV: {CountRoomsWithTV(rooms)}"); // Display the number of rooms with a TV
    }

    // Function to count the number of rooms with a TV
    static int CountRoomsWithTV(RoomInfo[] rooms)
    {
        int count = 0;
        foreach (RoomInfo room in rooms)
        {
            if (room.HasTV)
                count++;
        }
        return count;
    }
}

// RoomInfo class that represents room information
class RoomInfo
{
    private double length; // Private variable to store room length
    private double width; // Private variable to store room width
    private bool hasTV; // Private variable to store whether the room has a TV
    private static double houseSize; // Static variable to store the total house size

    // Constructor to initialize room information with default values
    public RoomInfo()
    {
        length = 0.0;
        width = 0.0;
        hasTV = false;
    }

    // Properties to get and set the room length, width, and hasTV values
    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public bool HasTV
    {
        get { return hasTV; }
        set { hasTV = value; }
    }

    // Static property to get the total house size
    public static double HouseSize
    {
        get { return houseSize; }
    }

    // Function to calculate room size and update the total house size
    public void CalcRoomSize()
    {
        double roomSize = length * width;
        houseSize += roomSize;
    }
}