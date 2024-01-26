Create a class named “Auto” and it has the following variables:
• maker
• model
• year
• price
• inStock
• inventoryCost
• totalInventoryCost (variable type: public static)
It includes the constructors and properties for all data fields, but make the “inventoryCost” as read-­‐only
property. It also includes a “calcInventoryCost” function that calculate the inventoryCost by (price) *
(inStock) and the inventoryCost will be added into “totalinventoryCost” after the inventoryCost is
calculated.
Create an “AutoDemo” class. In the main function, the program declares an array of object and calls the
“loadData” function to read the number of autos from “NumofAuto.txt” file, create an array of the Auto
objects, and read the data from “AutoData.txt” file. The “loadData” function should be defined after the
main function.
Then the program display a menu:
1. Display: create a function “displayData” to display all the auto in the array (the “displayArray”
function should be defined after the main).
2. AddAuto: let the user add a new auto information into the database. If it is an existing car in the
data base, the program will update the current “inStock”. If it is not, the program will save all
the information.
3. SellAuto: if the user sell the car, the program will update the inventory (inStock).
4. SaveExit: if the user choose this option, the program exit the loop and update the files.
Otherwise, the user will continue to use this program.
Before exiting the program, your program will clear the screen and then display all the current auto
information and the “totalInventoryCost”.
