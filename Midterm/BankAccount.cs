using System;

class BankAccountTest
{ // begin class bankaccounttest
    static void Main(string[] args)
    { //begin main
        //initialize checking and savings account
        BankAccount checkAccount = new BankAccount(0.005);
        BankAccount savingAccount = new BankAccount(0.023);

        // get user information
        Console.Write("Submit first name: ");
        checkAccount.FName = Console.ReadLine();
        Console.Write("Submit last name: ");
        checkAccount.LName = Console.ReadLine();
        Console.Write("Enter balance for the checkings account: ");
        checkAccount.Balance = GetPositiveInput();
        Console.Write("Enter balance for savings account: ");
        savingAccount.Balance = GetPositiveInput();

        //Display user's information.
        Console.WriteLine("Account Information:");
        Console.WriteLine("Name: {0} {1}", checkAccount.FName, checkAccount.LName);
        Console.WriteLine("Checking Balance: {0:C}", checkAccount.Balance);
        Console.WriteLine("Saving Balance: {0:C}\n", savingAccount.Balance);

        //compute & show balances after 1 & 2 years
        for (int i = 1; i <= 2; i++)
        { // begin for loop
            Console.WriteLine("After {0} year(s)", i);

            checkAccount.ComputeBalanceAfterAYear();
            savingAccount.ComputeBalanceAfterAYear();

            Console.WriteLine("Checking Balance: {0:C}", checkAccount.Balance);
            Console.WriteLine("Saving Balance: {0:C}", savingAccount.Balance);
        } // end for loop
    } // end main

    //method to confirm positive number
    static double GetPositiveInput()
    { // begin getpositiveinput
        double value;
        while (true)
        { // begin while loop
            if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                return value;

            Console.WriteLine("Not a positive amount please enter a positive amount: ");
        } // end while loop
    } // end getpositiveinput
} // end class bankaccounttest

class BankAccount
{ // begin class bankaccount
    // Variables
    private string fName;
    private string lName;
    private double yearlyInterest;
    private double balance;

    //constructor
    public BankAccount()
    {
        fName = "";
        lName = "";
        yearlyInterest = 0.0;
        balance = 0.0;
    }

    //constructor with a parameter
    public BankAccount(double yearlyInterest)
    {
        fName = "";
        lName = "";
        this.yearlyInterest = yearlyInterest;
        balance = 0.0;
    }

    //Property for first name
    public string FName
    {
        get { return fName; }
        set { fName = value; }
    }

    //Property for last name
    public string LName
    {
        get { return lName; }
        set { lName = value; }
    }

    //property for yearly interest rate
    public double YearlyInterest
    {
        get { return yearlyInterest; }
        set { yearlyInterest = value; }
    }

    //property for balance
    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    //method to compute balance after one year with interest
    public void ComputeBalanceAfterAYear()
    {
        double interest = balance * yearlyInterest;
        balance = balance + interest;
    }
}