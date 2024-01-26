using System;
using System.IO;

class AutoDemo
{
    static Auto[] autos;

    static void Main(string[] args)
    {
        LoadData();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display");
            Console.WriteLine("2. AddAuto");
            Console.WriteLine("3. SellAuto");
            Console.WriteLine("4. SaveExit");
            Console.Write("Select an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayData();
                    break;
                case 2:
                    AddAuto();
                    break;
                case 3:
                    SellAuto();
                    break;
                case 4:
                    SaveExit();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    static void LoadData()
    {
        // Load the number of autos from the file
        int numAutos = int.Parse(File.ReadAllText("NumofAuto.txt"));
        autos = new Auto[numAutos];

        // Read data from the AutoData.txt file and populate the autos array
        string[] lines = File.ReadAllLines("AutoData.txt");
        int index = 0;
        for (int i = 0; i < lines.Length; i += 5)
        {
            string maker = lines[i];
            string model = lines[i + 1];
            int year = int.Parse(lines[i + 2]);
            double price = double.Parse(lines[i + 3]);
            int inStock = int.Parse(lines[i + 4]);

            autos[index] = new Auto(maker, model, year, price, inStock);
            index++;
        }
    }

    static void DisplayData()
    {
        // Display information about each auto in the autos array
        foreach (Auto auto in autos)
        {
            Console.WriteLine($"Maker: {auto.Maker}, Model: {auto.Model}, Year: {auto.Year}, Price: {auto.Price:C}, InStock: {auto.InStock}, InventoryCost: {auto.InventoryCost:C}");
        }
        Console.WriteLine($"TotalInventoryCost: {Auto.TotalInventoryCost:C}");
    }

    static void AddAuto()
    {
        // Prompt user to enter details of a new auto
        Console.Write("Enter Maker: ");
        string maker = Console.ReadLine();
        Console.Write("Enter Model: ");
        string model = Console.ReadLine();
        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Enter InStock: ");
        int inStock = int.Parse(Console.ReadLine());

        // Check if the auto already exists, update its stock if it does
        bool existingAuto = false;
        foreach (Auto auto in autos)
        {
            if (auto.Maker == maker && auto.Model == model)
            {
                auto.InStock += inStock;
                existingAuto = true;
                break;
            }
        }

        // If the auto doesn't exist, add it to the autos array
        if (!existingAuto)
        {
            Auto newAuto = new Auto(maker, model, year, price, inStock);
            Array.Resize(ref autos, autos.Length + 1);
            autos[autos.Length - 1] = newAuto;
        }
    }

    static void SellAuto()
    {
        // Prompt user to enter details of the auto to sell
        Console.Write("Enter Maker of the car to sell: ");
        string maker = Console.ReadLine();
        Console.Write("Enter Model of the car to sell: ");
        string model = Console.ReadLine();

        // Find the auto in the array and update its stock
        foreach (Auto auto in autos)
        {
            if (auto.Maker == maker && auto.Model == model)
            {
                Console.Write("Enter the quantity to sell: ");
                int quantity = int.Parse(Console.ReadLine());
                if (quantity <= auto.InStock)
                {
                    auto.InStock -= quantity;
                    break;
                }
                else
                {
                    Console.WriteLine("Not enough stock to sell.");
                    break;
                }
            }
        }
    }

    static void SaveExit()
    {
        // Save the number of autos to the file
        File.WriteAllText("NumofAuto.txt", autos.Length.ToString());

        // Write auto data to the AutoData.txt file
        using (StreamWriter writer = new StreamWriter("AutoData.txt"))
        {
            foreach (Auto auto in autos)
            {
                writer.WriteLine(auto.Maker);
                writer.WriteLine(auto.Model);
                writer.WriteLine(auto.Year);
                writer.WriteLine(auto.Price);
                writer.WriteLine(auto.InStock);
            }
        }

        // Exit the program
        Environment.Exit(0);
    }
}

class Auto
{
    // Properties for the auto attributes
    public string Maker { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public int InStock { get; set; }
    public double InventoryCost { get; private set; } // read only

    // Static property to keep track of the total inventory cost across all autos
    public static double TotalInventoryCost { get; private set; }

    // Constructor to initialize the auto object
    public Auto(string maker, string model, int year, double price, int inStock)
    {
        Maker = maker;
        Model = model;
        Year = year;
        Price = price;
        InStock = inStock;
        CalcInventoryCost(); // Calculate and update inventory cost
    }

    // Calculate inventory cost and update the static TotalInventoryCost
    public void CalcInventoryCost()
    {
        InventoryCost = Price * InStock;
        TotalInventoryCost += InventoryCost;
    }
}