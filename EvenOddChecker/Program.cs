//
CheckEvenOdd();


void CheckEvenOdd()
{
    Console.Write("Enter a number : ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput % 2 == 0) { Console.WriteLine($"The Given Number {userInput} is an EVEN"); }
    else Console.WriteLine($"The Given Number {userInput} is an ODD");
    Console.ReadLine();
}