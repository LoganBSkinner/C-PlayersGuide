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

using System;

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