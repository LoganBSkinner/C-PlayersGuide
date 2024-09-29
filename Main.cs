//Main.cs

/*
Requirements met:

 [x] Allow the vending machine to display a list of available products.
 [x] Allow the user to input products into the vending machine.
 [ ] Associate each product with a price.
 [ ] Track the quantity of each product (stocking).
 [ ] Implement a way for users to buy products from the vending machine.
 [ ] Track money inserted by the user.
 [ ] Provide feedback on the total cost and balance.
 [ ] Handle insufficient funds when purchasing products.
 [ ] Implement restocking functionality to refill or add more products.
 [ ] Simulate returning change after a purchase.
 [ ] Provide a menu for user interaction (view menu, insert money, buy product, exit).
 [ ] Implement loops to keep the program running until the user exits.

Feedback from Ben:

 [x] Change file names to something that more closely follows best practice.
 [x] Update C# comments to use triple slashs "///".
 [x] Make fixes to case of fields and properties to more closely follow best practice.
 [x] Rename the Menu array to something more specific (i.e avoid code smell).
 [ ] Resolve debugging scenario that Ben proposed (i.e You have an array with an allocated space of 5. The 0th item is null and the 1st item is NOT null. What would happen in this case?
 [ ] Remove artifacts that Ben called out.
 [ ] Approach the array setup for my vending machine a little differently using a list or dictionary.

*/

using System.Linq.Expressions;
using VendingMachineManager;
public class Program
{
    public static void Main(string[] args)
    {
        VendingMachine vendingMachine = new VendingMachine();
        Console.WriteLine("--------------------\nVending Machine Menu\nPlease input your user type:\n(1) Operator\n--------------------");
        string Response = Console.ReadLine();
        int userType = Convert.ToInt32(Response);
        switch (userType)
        {
            case 1:
                //(1) Operator                
                vendingMachine.ReadOperatorMenu();// call method to read the operator's menu.
                break;
            default:
                Console.WriteLine("No valid option selected.\nClosing...");
                break;
        }
    }

}

