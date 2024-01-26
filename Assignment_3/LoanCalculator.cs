using System; //step 1

public class LoanTest //step 2
{
    static void Main(string[] args) //step 3
    {
        Console.WriteLine("Loan Calculator"); //step 4
        Console.WriteLine("-----------------"); //step 5
        Console.Write("Enter Loan Amount: "); //step 6
        double amount = Convert.ToDouble(Console.ReadLine());    // Prompt the user to enter the loan amount and convert it to a double *step 7*
        Console.Write("Enter Interest Rate: "); // step 8
        double interestRate = Convert.ToDouble(Console.ReadLine());    // Prompt the user to enter the interest rate and convert it to a double *step 9*
        Console.Write("Enter Finance Years: "); //step 10
        int financeYears = Convert.ToInt32(Console.ReadLine());   // Prompt the user to enter the number of finance years and convert it to an integer *step 11*
        Console.WriteLine(); // step 12

        Loan loan = new Loan(amount, interestRate, financeYears);   // Create a new Loan object with the provided values *step 13*
        loan.LoanTable();   // Call the LoanTable method to display the loan information and amortization schedule *step 14*

        Console.ReadKey();   // Wait for a key press before exiting the program *step 59*
    }
}

public class Loan
{
    private double amount;             // Private field to store the loan amount *step 15*
    private double interestRate;      // Private field to store the interest rate *step 16*
    private int financeYears;         // Private field to store the number of finance years *step 17*

    public Loan(double amount, double interestRate, int financeYears) //step 18
    {
        this.amount = amount;             // Assign the provided amount to the private field *step 19*
        this.interestRate = interestRate; // Assign the provided interest rate to the private field *step 20*
        this.financeYears = financeYears; // Assign the provided number of finance years to the private field *step 21*
    }

    public double CalculateMonthlyPayment() //Step 24 & step 33
    {
        double monthlyInterestRate = interestRate / 100 / 12;   // Calculate the monthly interest rate *step 25 & step 34*
        int numberOfPayments = financeYears * 12;               // Calculate the total number of payments *step 26 & step 35*
        double numerator = amount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments);  // Calculate the numerator of the monthly payment formula *step 27 & step 36*
        double denominator = Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1;   // Calculate the denominator of the monthly payment formula *step 28 & step 37*
        return numerator / denominator;   // Return the calculated monthly payment *step 29 & step 38*
    }

    public double CalculateTotalInterestPaid() //step 31
    {
        double monthlyPayment = CalculateMonthlyPayment();    // Calculate the monthly payment *step 32*
        int numberOfPayments = financeYears * 12;             // Calculate the total number of payments *step 39*
        double totalPayment = monthlyPayment * numberOfPayments;  // Calculate the total payment over the life of the loan *step 40*
        return totalPayment - amount;   // Return the total interest paid *step 41*
    }

    public void LoanTable() //Step 22
    {
        double monthlyPayment = CalculateMonthlyPayment();    // Calculate the monthly payment *Step 23*
        double totalInterestPaid = CalculateTotalInterestPaid();  // Calculate the total interest paid *step 30*
        double balance = amount;    // Initialize the loan balance as the loan amount *step 42*
        Console.WriteLine("Loan Information"); //Step 43
        Console.WriteLine("Amount Financed: {0:C}", amount);   // Display the loan amount in Local currency *step 44*
        Console.WriteLine("Interest Rate: {0}%", interestRate);   // Display the interest rate *step 45*
        Console.WriteLine("Finance Years: {0}", financeYears);    // Display the number of finance years *step 46*
        Console.WriteLine("Monthly Payment: {0:C}", monthlyPayment);   // Display the monthly payment in Local currency *step 47*
        Console.WriteLine("Total Interest Paid: {0:C}", totalInterestPaid);  // Display the total interest paid in Local currency *step 48*
        Console.WriteLine(); //step 49
        Console.WriteLine("Amortization Monthly Schedule"); //step 50
        Console.WriteLine("-----------------------------------------------------------------------"); //step 51
        Console.WriteLine("Cycle\tPayment\tPrincipal\tInterest\tTotal Interest\tBalance"); //step 52
        Console.WriteLine("-----------------------------------------------------------------------"); //step 53

        for (int cycle = 1; cycle <= financeYears * 12; cycle++) //step 54
        {
            double interest = balance * (interestRate / 100 / 12);   // Calculate the interest amount for the current cycle *step 55*
            double principal = monthlyPayment - interest;   // Calculate the principal amount for the current cycle *step 56*
            balance -= principal;   // Update the loan balance by subtracting the principal *step 57*
            Console.WriteLine("{0}\t{1:C}\t{2:C}\t\t{3:C}\t\t{4:C}\t\t{5:C}", cycle, monthlyPayment, principal, interest, (cycle * monthlyPayment), balance);  // Display the details of the current cycle *step 58*
        }
    }
}