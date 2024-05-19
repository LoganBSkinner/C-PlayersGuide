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
 