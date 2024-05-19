///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
Date: 05/12/2024
Page #: 82
Challenge: Buying Inventory
EXP: 100XP

 Objectives:
• Build a program that will show the menu illustrated on page 82.
• Ask the user to enter a number from the menu.
• Using the information above, use a switch (either type) to show the item's cost.
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

string menu;
int cost = 0;
bool exit = false;

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("Welcome to Tortuga's shop. Select an item to see it's price.");
Console.WriteLine("------------------------------------------------------------");

while (exit = !false)
{
    Console.WriteLine("1 - Rope");
    Console.WriteLine("2 - Torches");
    Console.WriteLine("3 - Climbing Equipment");
    Console.WriteLine("4 - Clean Water");
    Console.WriteLine("5 - Machete");
    Console.WriteLine("6 - Canoe");
    Console.WriteLine("7 - Food Supplies");
    Console.WriteLine("------------------------------------------------------------");

    menu = Console.ReadLine();

    switch (menu)
    {
        case "1":
            cost = 10;
            Console.WriteLine("\n*Rope*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");

            break;
        case "2":
            cost = 15;
            Console.WriteLine("\n*Torches*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");
            break;
        case "3":
            cost = 25;
            Console.WriteLine("\n*Climbing Equipment*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");
            break;
        case "4":
            cost = 1;
            Console.WriteLine("\n*Clean Water*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");
            break;
        case "5":
            cost = 20;
            Console.WriteLine("\n*Machete*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");
            break;
        case "6":
            cost = 200;
            Console.WriteLine("\n*Canoe*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");
            break;
        case "7":
            cost = 1;
            Console.WriteLine("\n*Food Supplies*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");
            break;
            break;
        case "8":
            exit = true;
            break;
        default:
            Console.WriteLine("\nInvalid entry. Please try again");
            continue;
    }

}