//VendingMachineManager.cs

using C_PlayersGuide;
using System.ComponentModel.Design;

namespace VendingMachineManager
{
    public class VendingMachine
    {
        private string Product;
        private string[] SnackInventory = new string[Configuration.VendingMachineCapacity];
        private decimal[] SnackPrice = new decimal[Configuration.VendingMachineCapacity];

        ////////////////////////////////////////OPERATOR///////////////////////////////////////////////
        public void ReadOperatorMenu()
        {
            Console.WriteLine("--------------------\nOperator menu\nWhat would you like to do?\n--------------------\n(1) Add new product to inventory\n(2) Remove a product.\n(3) View product list\n--------------------");
            string Response = Console.ReadLine();
            int OperatorResponse = Convert.ToInt32(Response);
            switch (OperatorResponse)
            {
                case 1:
                    this.AddNewProducts(); // (1) Add a product.
                    this.ReadOperatorMenu();
                    break;
                case 2:
                    this.RemoveExistingProducts();// (2) Remove a product.
                    this.ReadOperatorMenu();
                    break;
                case 3:
                    this.ReadStock();// (3) View product list.
                    this.ReadOperatorMenu();
                    break;
                default:
                    Console.WriteLine("Invalid entry; returning to operator menu.");
                    this.ReadOperatorMenu();
                    break;
            }
        }


        ////////////////////////////////////////MISCELLANEOUS///////////////////////////////////////////////

        /// <summary>
        /// Method to update the menu.
        /// </summary>

        public void AddNewProducts()
        {
            for (int i = 0; i < SnackInventory.Length; i++)
            {
                Console.WriteLine("You have " + (SnackInventory.Length - i) + " spaces left\n");
                Console.WriteLine("Enter a product name:\n");
                Product = Console.ReadLine();
                if (SnackInventory[i] is null)
                {
                    SnackInventory[i] = Product;
                }
                else if (SnackInventory[i] is null)
                {
                    SnackInventory[i] = SnackInventory[i];

                }
                else
                {
                    break;
                }

            }

        }

        /// <summary>
        /// Reads the items that the vending machine has available.
        /// </summary>
        public void ReadStock()
        {
            Console.WriteLine("Current vending machine inventory:\n");

            for (int i = 0; i < SnackInventory.Length; i++)
            {
                Console.WriteLine($"Item #{i+1}: {SnackInventory[i]}");

            }

        }

        /// <summary>
        /// Reads the items that the vending machine has available.
        /// </summary>
        public void RemoveExistingProducts()
        {
            this.ReadStock();
            Console.WriteLine("What would you like to remove? (1-6)\n");
            string Response = Console.ReadLine();
            int OperatorResponse = Convert.ToInt32(Response);
            switch (OperatorResponse)
            {
                case 1:
                    SnackInventory[0] = null;
                    Console.WriteLine($"{SnackInventory[0]} has been removed.");
                    this.ReadOperatorMenu();
                    break;
                case 2:
                    SnackInventory[1] = null;
                    Console.WriteLine($"{SnackInventory[1]} has been removed.");
                    this.ReadOperatorMenu();
                    break;
                case 3:
                    SnackInventory[2] = null;
                    Console.WriteLine($"{SnackInventory[2]} has been removed.");
                    this.ReadOperatorMenu();
                    break;
                case 4:
                    SnackInventory[3] = null;
                    Console.WriteLine($"{SnackInventory[3]} has been removed.");
                    this.ReadOperatorMenu();
                    break;
                case 5:
                    SnackInventory[4] = null;
                    Console.WriteLine($"{SnackInventory[4]} has been removed.");
                    this.ReadOperatorMenu();
                    break;
                case 6:
                    SnackInventory[5] = null;
                    Console.WriteLine($"{SnackInventory[5]} has been removed.");
                    this.ReadOperatorMenu();
                    break;
                default:
                    Console.WriteLine("No valid option selected.\nClosing...");
                    break;
            }

        }
    }

}

