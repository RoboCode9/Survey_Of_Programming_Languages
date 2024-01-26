Create a lottery game application. Generate four random numbers, each between 1 and 10. Allow the user
to guess four numbers. Compare each of the user’s guesses to the four random numbers and display a
message that includes the user’s guess, the randomly determined four numbers, and amount of money the
user has won as follows:
• Any one matching: $10
• Two matching: $30
• Three matching: $100
• Four matching, not in order: $1000
• Four matching, in exact order: $10000 No matches: $0
Make certain that your program accommodates repeating number. Save the file as Lottery.cs.
Hint:
Random RanNumber= new Random();
Int ran1;
ran1= RanNumber.Next(min,max);
