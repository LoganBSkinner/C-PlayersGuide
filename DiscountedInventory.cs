///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
Date: 05/12/2024
Page #: 83
Challenge: Discounted Inventory
EXP: 50XP

 Objectives:
• Modify the "Buying Inventory" script to ask the user for their name.
• If their name equals your name, divide the cost in half.
•
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

string menu, discountMenu, name;
int cost = 0;
bool exit = false, halfOff = false;

Console.WriteLine("What is your first name?");
name = Console.ReadLine();

if (name == "Logan") // Use '==' for comparison, not '='
{
    halfOff = true;
}
else
{
    halfOff = false;
}

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("Welcome to Tortuga's shop. Select an item to see it's price.");
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.WriteLine("------------------------------------------------------------");

while (exit == !false && halfOff == !false)
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

while (!exit && halfOff)
{
    Console.WriteLine("1 - Rope");
    Console.WriteLine("2 - Torches");
    Console.WriteLine("3 - Climbing Equipment");
    Console.WriteLine("4 - Clean Water");
    Console.WriteLine("5 - Machete");
    Console.WriteLine("6 - Canoe");
    Console.WriteLine("7 - Food Supplies");
    Console.WriteLine("------------------------------------------------------------");

    discountMenu = Console.ReadLine();

    switch (discountMenu)
    {
        case "1":
            cost = 5;
            Console.WriteLine("\n*Rope*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");

            break;
        case "2":
            cost = 7;
            Console.WriteLine("\n*Torches*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");
            break;
        case "3":
            cost = 13;
            Console.WriteLine("\n*Climbing Equipment*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");
            break;
        case "4":
            cost = 1;
            Console.WriteLine("\n*Clean Water*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");
            break;
        case "5":
            cost = 10;
            Console.WriteLine("\n*Machete*");
            Console.WriteLine("The cost of this item is: " + cost + " gold.");
            break;
        case "6":
            cost = 100;
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