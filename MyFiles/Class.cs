//Class.cs

using System.ComponentModel.Design;

namespace VendingMachineManager
{
    public class VendingMachine
    {
        private string _product;
        private string[] Menu = new string[5];

        public void UpdateMenu() //method to update the menu.
        {
            for (int i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine("You have " + (Menu.Length - i) + " spaces left\n");
                Console.WriteLine("Enter a product name:\n");
                _product = Console.ReadLine();
                if (Menu[i] is null)
                {
                    Menu[i] = _product;

                }
                else if (Menu[i] is null)
                {
                    Menu[i] = Menu[i];

                }
                else
                {
                    break;
                }

            }

        }

        public void ReadMenu() //method to read what the vending machine has. Accepts no parameters.
        {
            Console.WriteLine("The vending machine contains the following:\n");

            for (int i = 0; i < Menu.Length; i++)
            {
                
                if (Menu[i] is null)
                {
                    Console.WriteLine("> EMPTY");
                    Console.WriteLine("\n");
                }

                else
                {
                    Console.WriteLine("> " + Menu[i]);
                    Console.WriteLine("\n");
                }

            }

        }
    }

}

