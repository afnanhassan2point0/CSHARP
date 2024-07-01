/* Program takes user inputs in a list, Finds Maximum & Minimum Number and Prints them on screen 
// Muhammad Afnan #30 BSiT#5th */

Console.Write("How many numbers you are going to enter : ");
int listSize = Convert.ToInt32(Console.ReadLine()); // to loop for user inputs
List<int> numList = []; // an empty list

for (int i = 0; i < listSize; i++)
{
    Console.Write($"Enter number ({i + 1}) :: ");
    numList.Add(Convert.ToInt32(Console.ReadLine()));
}

int maxNum = int.MinValue;
int minNum = int.MaxValue;
foreach (int i in numList) // ForEach loop
{
    maxNum = i > maxNum ? i : maxNum; // ternary operator MAX finder
    minNum = i < minNum ? i : minNum; // MIN finder
}

Console.Write($"\nThe Maximum Number is {maxNum}\n&\nThe Minimum Number is {minNum}\n");