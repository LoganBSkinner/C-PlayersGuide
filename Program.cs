///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* 
Date: 04/25/2024
Page #: 75
Challenge: Repairing hte Clocktower
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

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* 
Date: 04/23/2024
Page #: 68
Challenge: The Defense of Consolas
EXP: 200 XP

 Objectives:
• Ask the user for the target row and column.
• Compute the neighboring rows and columns of where to deploy the squad.
• Display the deployment instructions in a different color of your choosing.
• Change the window title to be "Defense of Consolas".
• Play a sound with Console.Beep when the results have been computed and displayed.
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
using System.Net.NetworkInformation;

Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.White;
Console.Title = "The Defense of Consolas";
Console.WriteLine("Select a row to defend:");
string _chessRow = Console.ReadLine();
int _chessRowConverted = Convert.ToInt16(_chessRow);
Console.WriteLine("Select a column to defend:");
string _chessColumn = Console.ReadLine();
int _chessColumnConverted = Convert.ToInt16(_chessColumn);
Convert.ToInt16(_chessColumn);

// (row, column)

int _firstPlacementRow = _chessRowConverted + 1;
int _firstPlacementColumn = _chessColumnConverted;
int _secondPlacementRow = _chessRowConverted;
int _secondPlacementColumn = _chessColumnConverted - 1;
int _thirdPlacementRow = _chessRowConverted - 1;
int _thirdPlacementColumn = _chessColumnConverted;
int _fourthPlacementRow = _chessRowConverted;
int _fourthPlacementColumn = _chessColumnConverted + 1;

Console.WriteLine("Placement #1: (" + _firstPlacementRow + ", " + _firstPlacementColumn + ")");
Console.WriteLine("Placement #2: (" + _secondPlacementRow + ", " + _secondPlacementColumn + ")");
Console.WriteLine("Placement #3: (" + _thirdPlacementRow + ", " + _thirdPlacementColumn + ")");
Console.WriteLine("Placement #4: (" + _fourthPlacementRow + ", " + _fourthPlacementColumn + ")");

Console.Beep(500, 250);
*/
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

/*
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

*/

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* 
6Date: 04/16/2024
Page #: 56
Challenge: The Four Sisters and the Duckbear
EXP: 100 XP

 Objectives:
• Create a program that lets the user enter the number of chocolate eggs gathered that day.
• Compute how many eggs each sister should get and how many are left over for the duckbear.
• Answer the question: "What are three total egg counts where the duckbear gets more than each sister does?
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* 
string _totalEggs;
int _eggsPerSister, _totalEggsInt, _eggsForDuckbear;

Console.WriteLine("Enter the number of eggs received today:");
_totalEggs = Console.ReadLine();
_totalEggsInt = Convert.ToInt32(_totalEggs);

_eggsPerSister = _totalEggsInt / 4;
_eggsForDuckbear = _totalEggsInt % 4;



// Eggs = 15
// Sisters = 3
// Duckbear = 3

Console.WriteLine("The number of eggs received by each sister is " + _eggsPerSister + " for a total of " + (_eggsPerSister * 4) + " eggs.");
Console.WriteLine("The number of eggs received by the duckbear is " + _eggsForDuckbear + ".\n");

*/

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* 
Date: 04/15/2024
Page #: 53
Challenge: The Triangle Farmer
EXP: 100 XP

 Objectives:
• Write a program that lets you input the triangle's base size and height.
• Compute the area of a triangle by returning the above equation into code.
• Write the result of the computation.
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
 string triangleBase, triangleHeight;
double triangleBaseconversion, triangleHeightconversion, triangleArea;

Console.WriteLine("****************************************");
Console.WriteLine("Triangle Area Calculator");

Console.WriteLine("Enter the triangle's base in feet:");
triangleBase = Console.ReadLine();
triangleBaseconversion = Convert.ToDouble(triangleBase);

Console.WriteLine("Enter the triangle's height in feet:");
triangleHeight = Console.ReadLine();
triangleHeightconversion = Convert.ToDouble(triangleHeight);

triangleArea = (triangleBaseconversion * triangleHeightconversion) / 2;

Console.WriteLine("The area of this triangle is: " + triangleArea + " feet.");
Console.WriteLine("****************************************");
 */


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* 
Date: 04/14/2024
Page #: 45
Challenge: The Variable Shop Returns
EXP: 50 XP

 Objectives:
• Modify code from "The Variable Shop" activity to assign a new, different literal value to each of the 14 original variables.
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
 int age = 28;
short januaryDays = 31;
byte binary = 2;
sbyte temperature = 14;
uint numberOfStates = 50;
ushort imagePixels = 1250;
ulong totalAtoms = 1_000_000;
char Confirm = 'y';
string firstName = "Logan";
float gramsToOunces = 28.3495f;
double valueOfPi = 3.141579;
decimal gasPricePerGallon = 4.54m;
bool legalAge = true;

Convert.ToByte(age);
Convert.ToInt32(januaryDays);
Convert.ToInt16(binary);
Convert.ToDecimal(temperature);
Convert.ToSByte(numberOfStates);
Convert.ToUInt64(imagePixels);
Convert.ToInt64(totalAtoms);
Convert.ToString(Confirm);
Convert.ToSingle(gramsToOunces);
Convert.ToSingle(valueOfPi);
Convert.ToSingle(gasPricePerGallon);
Convert.ToString(legalAge);

Console.WriteLine(
    "Values are as follows:" +
    "\n intAge = " + age +
    "\n Days in January = " + januaryDays +
    "\n Binary value = " + binary +
    "\n Temperature = " + temperature +
    "\n  = " + numberOfStates +
    "\n # of Pixels = " + imagePixels +
    "\n Atoms in a hair follice = " + totalAtoms +
    "\n Character for Yes = " + Confirm +
    "\n My own first name = " + firstName +
    "\n Grams to ounces = " + gramsToOunces +
    "\n The value of pi = " + valueOfPi +
    "\n The price of gas per gallon = " + gasPricePerGallon +
    "\n Am I of legal age? = " + legalAge +
    "\n ");
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* 
Date: 04/14/2024
Page #: 45
Challenge: The Variable Shop
EXP: 100 XP

 Objectives:
• Build a program with a variable of all fourteen types described in this level.
    [✓] int
    [✓] short
    [✓] long
    [✓] byte
    [✓] sbyte
    [✓] uint
    [✓] ushort
    [✓] ulong
    [✓] Char
    [✓] String   
    [✓] Float
    [✓] Double
    [✓] Decimal
    [✓] Bool
• Assign each of them a value using a literal of the correct type.
• Use Console.WriteLine to display the contents of each variable.
 */
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
 int age = 28;
short januaryDays = 31;
long earthCircumference = 24_901;
byte binary = 2;
sbyte temperature = 14;
uint numberOfStates = 50;
ushort imagePixels = 1250;
ulong totalAtoms = 1_000_000;
char Confirm = 'y';
string firstName = "Logan";
float gramsToOunces = 28.3495f;
double valueOfPi = 3.141579;
decimal gasPricePerGallon = 4.54m;
bool legalAge = true;

Console.WriteLine(
    "Values are as follows:" +
    "\n intAge = " + age + 
    "\n Days in January = " + januaryDays +
    "\n Earth's circumference = " + earthCircumference + 
    "\n Binary value = " + binary +
    "\n Temperature = " + temperature +
    "\n  = " + numberOfStates +
    "\n # of Pixels = " + imagePixels +
    "\n Atoms in a hair follice = " + totalAtoms +
    "\n Character for Yes = " + Confirm +
    "\n My own first name = " + firstName +
    "\n Grams to ounces = " + gramsToOunces +
    "\n The value of pi = " + valueOfPi +
    "\n The price of gas per gallon = " + gasPricePerGallon +
    "\n Am I of legal age? = " + legalAge +
    "\n " );
 */

