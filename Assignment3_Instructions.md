Create an application that will allow a loan amount, interest rate, and number of finance years to
be entered for a given loan.
Determine the monthly payment amount. Calculate how much interest will be paid over the life
of the loan. Display an amortization schedule showing the new balance after each payment is
made.
Design an object-oriented solution. Use two classes.
Loan class: characteristics such as the amount to be financed, rate of interest, period of time for
the loan, and total interest paid will identify the current state of a loan object. Include methods to
determine the monthly payment amount, return the total interest paid over the life of the loan,
and Loantable function to display an amortization schedule that include: number of the cycle,
payment amount, principal paid, interest paid, total interest paid, balance
LoanTest class:
In the main class: instantiate an object of the loan class. Allow the user to input data about the
loan. Then use Loantable function to display the Loan information.
**Monthly Payment Formula: get monthly payment A from Loan Amount P, Interest Rate i, and
Loan Period n

A = P * i(1 + i)^n / (1 + i)^n - 1
