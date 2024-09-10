//  The top level command is here that will initiate the whole program
//
ShowMainMenu();

// All the user defined functions are written here
void ShowMainMenu()
{
    int menuChoice;
    Console.Write("\n1. Decimal to Binary conversion \n2. Binary to Decimal conversion \n0. Enter '0' to Exit \n~~ Enter a choice here :: ");
    menuChoice = Convert.ToInt32(Console.ReadLine());
    switch (menuChoice)
    {
        case 0:
            Console.WriteLine("\nProgram exited successfully\n");
            break;
        case 1:
            ConvertDecimalToBinary();
            ShowMainMenu();
            break;
        case 2:
            ConvertBinaryToDecimal();
            ShowMainMenu();
            break;
        default:
            Console.WriteLine("\nerror: invalid input.\n");
            ShowMainMenu();
            break;
    }
}

void ConvertDecimalToBinary()
{
    long userInput; // to catch user Decimal number
    string binaryNumber = ""; // to make sure starting 0's to be added clearly
    Console.Write("\nEnter decimal number : ");
    userInput = Convert.ToInt64(Console.ReadLine());
    long decimalNo = userInput; // temporary var that vanishes with the process in looping
    while (decimalNo > 0) // FACTORIZATION
    {
        long digit = decimalNo % 2; // factorized value as remainder by 2
        binaryNumber += digit; // it can even add the 1st 0 that is ignored in integer types
        decimalNo /= 2; // next number
    }
    string reversedBinary = new(binaryNumber.Reverse().ToArray()); // reversing the string
    Console.WriteLine($"Decimal : {userInput} = Binary : {reversedBinary}"); // string literal for output
}

void ConvertBinaryToDecimal()
{
    long userInput, binaryNumber; // inputs manipulations
    long decimalNumber = 0; // answer variable
    long power = 1; // power of base 2
    Console.Write("\nEnter binary number : ");
    userInput = Convert.ToInt64(Console.ReadLine());
    binaryNumber = userInput;
    while (binaryNumber > 0) // decimal number to binary number conversion occurs here
    {
        decimalNumber += binaryNumber % 10 * power; // main formula & calculation happens here
        binaryNumber /= 10; // next value
        power *= 2; // next & power increments
    }
    Console.WriteLine($"Binary : {userInput} = Decimal : {decimalNumber}"); // string literal for output
}
