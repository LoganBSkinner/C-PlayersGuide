///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* 
Date: 04/25/2024
Page #: 75
Challenge: Repairing the Clocktower
EXP: 100 XP

 Objectives:
• Take a number as input from the console.
• Display the word "Tick" if the number is even. Display the word "Tock" if the number is odd.
• Hint: Remember that you can use the remainder operator to determine if a number is even or odd.
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Input a number to the clock:");

string input = Console.ReadLine();
int clockSound = Convert.ToInt32(input);

if
    (clockSound % 2 == 0)
    Console.WriteLine("Tick");
else
    Console.WriteLine("Tock");






