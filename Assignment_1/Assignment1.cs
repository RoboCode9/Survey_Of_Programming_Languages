using System;

namespace Welcome1
{
    class Welcome1
    {
        static void Main(string[] args)
        {
            //Initialize variables
            float oranges = 2.0f;
            float apples = 3.0f;
            float tomatoes = 5.0f;
            float bananas = 0.5f;
            float pears = 10f;
            float grapes = 4.8f;
            float orangesQuantity;
            float applesQuantity;
            float tomatoesQuantity;
            float bananasQuantity;
            float pearsQuantity;
            float grapesQuantity;
            float tax;
            float subtotal;
            float total;

            /* Task 1 */
            Console.Write("Enter your name: ");        //Prompt user to enter their name 
            string name = Console.ReadLine();          //Collect name of user and store on to variable name.

            Console.Write("Enter your phone#: ");      //Prompt user to enter their phone#
            string phoneNumber = Console.ReadLine();   //Collect phone# of user and store on to variable phoneNumber.

            Console.Write("Enter your address: ");       //Prompt user to enter their address
            string address = Console.ReadLine();       //Collect address of user and store on to variable address.

            Console.Write("Enter your email address: "); //Prompt user to enter their email address
            string email = Console.ReadLine();         //Collect email address of user and store on to variable email.

            Console.WriteLine("");

            /* Task 2 */
            Console.WriteLine($"Welcome {name}!");
            Console.WriteLine("");
            Console.WriteLine("Fruits Menu");
            Console.WriteLine("##############");
            Console.WriteLine("Oranges $2");
            Console.WriteLine("Apples $3");
            Console.WriteLine("Tomatoes $5");
            Console.WriteLine("Bananas $0.5");
            Console.WriteLine("Pears $0.5");
            Console.WriteLine("Grapes $4.8");

            /*Task 3*/

            Console.WriteLine("");
            Console.WriteLine("How many of each fruit do you want to buy?");

            Console.WriteLine("##############");

            Console.Write("How many oranges will you buy? ");
            orangesQuantity = int.Parse(Console.ReadLine());

            Console.Write("How many apples will you buy? ");
            applesQuantity = int.Parse(Console.ReadLine());

            Console.Write("How many tomatoes will you buy? ");
            tomatoesQuantity = int.Parse(Console.ReadLine());

            Console.Write("How many bananas will you buy? ");
            bananasQuantity = int.Parse(Console.ReadLine());

            Console.Write("How many pears will you buy? ");
            pearsQuantity = int.Parse(Console.ReadLine());

            Console.Write("How many grapes will you buy? ");
            grapesQuantity = int.Parse(Console.ReadLine());

            subtotal = (oranges * orangesQuantity) + (apples * applesQuantity) + (tomatoes * tomatoesQuantity) + (bananas * bananasQuantity) + (pears * pearsQuantity) + (grapes * grapesQuantity);

            tax = subtotal * 0.0825f;

            total = tax + subtotal;

            /* Task 4 */
            Console.WriteLine("");
            Console.WriteLine($"Your order amounts to:\n${oranges * orangesQuantity} in oranges\n${apples * applesQuantity} in apples\n${tomatoes * tomatoesQuantity} in tomatoes\n${bananas * bananasQuantity} in bananas\n${pears * pearsQuantity} in pears\n${grapes * grapesQuantity} in grapes");

            Console.WriteLine($"And your total before tax is:\n{subtotal}\nAnd your total after tax is:\n{total}");


            Console.WriteLine("");
            Console.WriteLine($"Here is the information you provided to the system:\nYour name is {name}\nYour phone number is {phoneNumber}\nYour address is {address}\nAnd your email is {email}");

            Console.WriteLine("");
            Console.WriteLine($"Thank you {name} for your business, have a great day!");
        }
    }
}
