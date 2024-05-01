///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* 
Date: 04/18/2024
Page #: 57
Challenge: The Dominion of Kings
EXP: 100 XP

 Objectives:
• Create a program that allows users to enter how many provinces, duchies, and estates they have.
• Add up the user's total score, giving 1 point per estate, 3 per duchy, and 6 per province.
• Display the point total to the user.
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

string King1 = "Melik";
string King2 = "Casik";
string King3 = "Balik";

int King1_Points, King2_Points, King3_Points;
string King1_estates, King1_duchies, King1_provinces, King2_estates, King2_duchies, King2_provinces, King3_estates, King3_duchies, King3_provinces;
int King1_estates_int, King1_duchies_int, King1_provinces_int, King2_estates_int, King2_duchies_int, King2_provinces_int, King3_estates_int, King3_duchies_int, King3_provinces_int;

int _estateValue = 1;
int _duchyValue = 3;
int _provinceValue = 6;

Console.WriteLine(King1 + ", please enter how many estates you have: ");
King1_estates = Console.ReadLine();
King1_estates_int = Convert.ToInt32(King1_estates);
Console.WriteLine(King1 + ", please enter how many duchies you have: ");
King1_duchies = Console.ReadLine();
King1_duchies_int = Convert.ToInt32(King1_duchies);
Console.WriteLine(King1 + ", please enter how many provinces you have: ");
King1_provinces = Console.ReadLine();
King1_provinces_int = Convert.ToInt32(King1_provinces);

Console.WriteLine(King2 + ", please enter how many estates you have: ");
King2_estates = Console.ReadLine();
King2_estates_int = Convert.ToInt32(King2_estates);
Console.WriteLine(King2 + ", please enter how many duchies you have: ");
King2_duchies = Console.ReadLine();
King2_duchies_int = Convert.ToInt32(King2_duchies);
Console.WriteLine(King2 + ", please enter how many provinces you have: ");
King2_provinces = Console.ReadLine();
King2_provinces_int = Convert.ToInt32(King2_provinces);

Console.WriteLine(King3 + ", please enter how many estates you have: ");
King3_estates = Console.ReadLine();
King3_estates_int = Convert.ToInt32(King3_estates);
Console.WriteLine(King3 + ", please enter how many duchies you have: ");
King3_duchies = Console.ReadLine();
King3_duchies_int = Convert.ToInt32(King3_duchies);
Console.WriteLine(King3 + ", please enter how many provinces you have: ");
King3_provinces = Console.ReadLine();
King3_provinces_int = Convert.ToInt32(King3_provinces);

King1_Points = (King1_estates_int * _estateValue) + (King1_duchies_int * _duchyValue) + (King1_provinces_int * _provinceValue);
King2_Points = (King2_estates_int * _estateValue) + (King2_duchies_int * _duchyValue) + (King2_provinces_int * _provinceValue);
King3_Points = (King3_estates_int * _estateValue) + (King3_duchies_int * _duchyValue) + (King3_provinces_int * _provinceValue);

Console.WriteLine("King " + King1 + " has " + King1_Points + " points.");
Console.WriteLine("King " + King2 + " has " + King2_Points + " points.");
Console.WriteLine("King " + King3 + " has " + King3_Points + " points.");



