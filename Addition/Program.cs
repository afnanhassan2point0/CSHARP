Func<long, long, long> AddKaro = (long x, long y) => { return x + y; }; // Lambda Expression
Func<long, long, long> MinusKaro = (long n1, long n2) => { return n1 - n2; }; // :: Lambda Func for SubtractionKaro() on option 2


// :: 1
// Console.Write("\nHow many numbers to add : ");
// int noCount = Convert.ToInt32(Console.ReadLine());
// long[] inputNumbers = new long[noCount]; // size of array on user-choice & demand
// int i = 0; // iterator
// long sum = 0; // sum
// while (i < noCount) // Taking the user inputs: the numbers // Addition formula is also applied here
// {
//     Console.Write("Enter Number : ");
//     inputNumbers[i] = Convert.ToInt64(Console.ReadLine());
//     sum = AddKaro(sum, inputNumbers[i]); // quickly adds the input number
//     i++;
// }
// Console.Write($"\nThe sum of the given numbers is :: {sum}\n"); // output
// Console.ReadLine(); // to pause for a moment


// :: 2
Console.Write("\n\nEnter 1st Number : ");
long firstInput = Convert.ToInt64(Console.ReadLine());
Console.Write("Enter 2nd Number : ");
long secondInput = Convert.ToInt64(Console.ReadLine());
Console.WriteLine($"{firstInput} - {secondInput} = {MinusKaro(firstInput, secondInput)}"); // :: used Lambda Delegate method MinusKaro()
Console.ReadLine(); // to stay on screen for a while