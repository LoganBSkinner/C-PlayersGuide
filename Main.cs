///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
Date: 06/02/2024
Page #: 101248
Challenge: Hunting the Manticore
EXP: 250XP

 Objectives:
• Ask the player to choose the Manticore's distance.
• Display round #, City HP, and Manticore HP.
• Have the player attempt to find the distance through cannon shots.
• Calculate the damage done by the cannon through the modulus operator.
• The city should take 1 damage for every overshot or undershot.
• Terminate when either party reaches 0 health points.
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

class HuntingManticore
{
    // Declare variables at the class level!
    int ManticoreHealth = 10;
    int CityHealth = 15;
    int Round = 0;
    int CannonDamage = 0;
    int TilesInt = 0;
    int CannonShot = 0;

    public static void Main(string[] args)
    {
        HuntingManticore game = new HuntingManticore();
        game.StartGame();
    }

    void StartGame()
    {
        // Declare distance of ship and clear screen.
        Console.WriteLine("How many tiles away is the Manticore? (0-100)");
        string TilesString = Console.ReadLine();
        TilesInt = Convert.ToInt32(TilesString);
        Console.Clear();

        // "Only stop when someone dies."
        while (ManticoreHealth > 0 && CityHealth > 0)
        {
            RoundIncrease();
            CaculateCannonDamage();
            Console.WriteLine("STATUS: Round " + Round + "| City HP: " + CityHealth + "| Manticore HP: " + ManticoreHealth);
            Console.WriteLine("The cannon is expected to deal " + CannonDamage + " damage this round.");
            Console.WriteLine("Enter desired cannon range: ");
            string ShotString = Console.ReadLine();
            CannonShot = Convert.ToInt32(ShotString);
            DetermineCannotShot();

        }

    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    void RoundIncrease()
    {
        Round++;
    }
    void CaculateCannonDamage()
    {
        if (Round % 3 == 0 && Round % 5 == 0) // If round # is a multiple of 3 AND 5, fire electric damage of 10 is done.

        {
            CannonDamage = 10;
            return;
        }
        else if (Round % 3 == 0 || Round % 5 == 0) // If round # is a multiple of 3 OR 5, fire or electric damage of 3 is done.
        {
            CannonDamage = 3;
            return;
        }
        else
        {
            CannonDamage = 1;
            return;
        }
    }
    void DetermineCannotShot()
    {
        if (CannonShot > TilesInt) // 
        {
            CityHealth = CityHealth - 1;
            if (CityHealth <= 0)
            {
                Console.WriteLine("Oh no! The city has fallen! Retreat!");
            }
            else
            {
                Console.WriteLine("That round OVERSHOT the target!");
            }
            return;
        }
        else if (CannonShot < TilesInt) // 
        {
            CityHealth = CityHealth - 1;
            if (CityHealth <= 0)
            {
                Console.WriteLine("Oh no! The city has fallen! Retreat!");
            }
            else
            {
                Console.WriteLine("That round UNDERSHOT the target!");
            }
            return;

        }
        else
        {
            ManticoreHealth = ManticoreHealth - CannonDamage;
            if (ManticoreHealth <= 0)
            {
                Console.WriteLine("Hooray! The Manticore has fallen!");
            }
            else
            {
                Console.WriteLine("That round was a DIRECT HIT for " + CannonDamage + " damage!");
            }

            return;
        }
    }

}