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