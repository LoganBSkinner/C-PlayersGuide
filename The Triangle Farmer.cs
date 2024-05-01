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


using System;

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