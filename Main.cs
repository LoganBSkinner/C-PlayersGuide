//Main.cs

/*
Requirements met:

 [x] Allow the vending machine to display a list of available products.
 [x] Allow the user to input products into the vending machine.

Requirements not met:

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
*/

using VendingMachineManager;
public class Program
{
    public static void Main(string[] args)
    {
        VendingMachine vendingMachine = new VendingMachine();
        vendingMachine.UpdateMenu();
        Console.WriteLine("Vending machine inventory:");
        vendingMachine.ReadMenu();
    }

}


