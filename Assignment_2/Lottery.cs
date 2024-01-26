using System;

class Lottery1
{
    static void Main()
    {
        Random RanNumber = new Random(); //random class initialized
        int ran1; // initialize 1st variable
        int ran2; // initialize 2nd variable
        int ran3; // initialize 3rd variable
        int ran4; // initialize 4th variable
        int guess1; // initialize guess 1
        int guess2; // initialize guess 2
        int guess3; // initialize guess 3
        int guess4; // initialize guess 4
        int Min = 1; // set min variable value to 1
        int Max = 10; // set max variable value to 10
        string answer = "yes"; //set answer with a string value of "yes"

        Console.WriteLine("Would you like to play a guessing game? Type no to quit or press any key to play.");
        answer = Console.ReadLine(); //wait for user input 

        while (answer != "No" && answer != "no") //while the user input is not equals to "no" or "No", run this block of code
        {
            int count = 0; // used as a integer for counting matches
            ran1 = RanNumber.Next(Min, Max); // generate a random number and assign it to ran1
            ran2 = RanNumber.Next(Min, Max); // generate a random number and assign it to ran2
            ran3 = RanNumber.Next(Min, Max); // generate a random number and assign it to ran3
            ran4 = RanNumber.Next(Min, Max); // generate a random number and assign it to ran4

            //prompt that describes how the game is played
            Console.WriteLine("You will guess four numbers and there five ways to win");
            Console.WriteLine("----------");
            Console.WriteLine("Match one number and win $10");
            Console.WriteLine("Match two numbers and win $30");
            Console.WriteLine("Match three numbers and win $100");
            Console.WriteLine("Match four not in order numbers and win $1K");
            Console.WriteLine("Match four in exact order and win 10k!!!");
            Console.WriteLine("Match none and you win nothing");
            Console.WriteLine("----------");

            //This section is where the user plays the game by entering their numbers between 1-10.
            Console.WriteLine("Enter your first number, it must be between 1-10");
            if (!int.TryParse(Console.ReadLine(), out guess1)) // This line of code will check if the value entered by the user can be converted to an integer.
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }
            Console.WriteLine("Enter your second number, it must be between 1-10");
            if (!int.TryParse(Console.ReadLine(), out guess2))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }
            Console.WriteLine("Enter your third number, it must be between 1-10");
            if (!int.TryParse(Console.ReadLine(), out guess3))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }
            Console.WriteLine("Enter your last number, it must be between 1-10");
            if (!int.TryParse(Console.ReadLine(), out guess4))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            //The program checks if the user entered a valid input such as if the number is to high or to low then asks the user if they want to play again.
            if (guess1 > 10 || guess2 > 10 || guess3 > 10 || guess4 > 10 || guess1 < 1 || guess2 < 1 || guess3 < 1 || guess4 < 1)
                {
                    Console.WriteLine("Number to high or to low");
                    Console.WriteLine("Would you like to play again?");
                    answer = Console.ReadLine();
                    continue;
                }

            //The program displays the results of the users numbers and the computers numbers and displays the winning or losing results
            Console.WriteLine("Here are the results:");
            Console.WriteLine("");
            Console.Write("Your guessed numbers: ");
            Console.WriteLine($"{guess1} {guess2} {guess3} {guess4}");
            Console.Write("The computers numbers: ");
            Console.WriteLine($"{ran1} {ran2} {ran3} {ran4}");

            // The grand prize and ask user if they want to play again
            if (guess1 == ran1 && guess2 == ran2 && guess3 == ran3 && guess4 == ran4) 
                {
                    Console.WriteLine("Congrats, you won $10k!!!");
                    Console.WriteLine("Would you like to play again?");
                    answer = Console.ReadLine();
                    continue;
                }

            //This section of the code will add to the "count" depending if any of the "guesses" match the "rans"
            if (guess1 == ran1 || guess1 == ran2 || guess1 == ran3 || guess1 == ran4)
                {
                    count++;
                }

            if (guess2 == ran1 || guess2 == ran2 || guess2 == ran3 || guess2 == ran4)
                {
                    count++;
                }

            if (guess3 == ran1 || guess3 == ran2 || guess3 == ran3 || guess3 == ran4)
                {
                    count++;
                }

            if (guess4 == ran1 || guess4 == ran2 || guess4 == ran3 || guess4 == ran4)
                {
                    count++;
                }

            //This section of the code will evaluate the value of "count" and depending on its value will enter the specified case otherwise it goes to default.
            switch (count)
                {
                    case 1:
                        Console.WriteLine("You won $10!");
                        Console.WriteLine("Would you like to play again?");
                        answer = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("You won $30!");
                        Console.WriteLine("Would you like to play again?");
                        answer = Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("You won $100!");
                        Console.WriteLine("Would you like to play again?");
                        answer = Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("You won $1K!!!");
                        Console.WriteLine("Would you like to play again?");
                        answer = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Sorry not a winner...");
                        Console.WriteLine("Would you like to play again?");
                        answer = Console.ReadLine();
                        break;
                }
        }
        if (answer == "no" || answer == "No") //if answer is equals to "no" or "No" display this message.
            {
                Console.WriteLine("Goodbye have a nice day!");
            }
    }
}