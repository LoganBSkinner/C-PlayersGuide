///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
Date: 05/26/2024
Page #: 106
Challenge: Taking a Number
EXP: 100XP

 Objectives:
• Make a method with the signautre int askForNumber(string text). Display the text paramter in the console window, get a response from the user, 
  convert it to an int, and return it. This might look like this: int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");
• Make a method with the signature int AskforNumberInRange(string text, int min, int max). Only return if the entered number is between the min and max values.
• Place these methods in at least one of your previous programs to improve it.
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
////////////////////////////////////////////////////////////////////////////
class TakingANumber
{
    static void AskForNumber()
    {
        bool isValid = false;
        int result2 = 0;
        while (!isValid)
        {
            Console.WriteLine("Please insert a number:");
            string result = Console.ReadLine();
            result2 = Convert.ToInt32(result);

            if (result2 >= 10 || result2 <= 0)
            {
                isValid = false;
                Console.WriteLine("Invalid entry;");
                Console.WriteLine("Entry must be between 0 and 10.");
            }
            else if (result2 >= 0 && result2 <= 10)
            {
                isValid = true;
                Console.WriteLine("The number entered was: " + result2);
                return;
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////////
    static void Main(string[] args)
    {
        AskForNumber();
    }
}