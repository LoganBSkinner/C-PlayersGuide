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
