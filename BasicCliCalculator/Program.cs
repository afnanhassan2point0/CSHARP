// A simple calculator program in C#, based on the concepts like: Top-Level Programming design, Lambda expression Methods, Loops, Conditions, Infinite-User-Control program & simple real life template design for console application
// credits :: Muhammad Afnan Hassan #2130 #BSIT #5th #Batch-01(2021-2025)


// Top Level commands
Func<long, long, long> AddKaro = (long n1, long n2) => { return n1 + n2; }; // :: Lambda Func method for AdditionKaro() on option "1. Addition"
Func<long, long, long> MinusKaro = (long n1, long n2) => { return n1 - n2; }; // :: Lambda Func for SubtractionKaro() on option 2
Func<long, long, long> ZarabKaro = (long n1, long n2) => { return n1 * n2; }; // :: Lambda Func for MultiplyKaro() on option 3
Action<long, long> TaqseemKaro = (long n1, long n2) => { Console.WriteLine($"{n1} / {n2}  =\tanswer: {n1 / n2} \t remainder: {n1 % n2}\n"); }; // :: Lambda Action method to divide & find Remainder for option 4, // It is Action as nothing returns

ShowMenu(); //   (^_^) MAIN MENU (^_^) :: smiles here

// main menu of program to go-with features
void ShowMenu()
{
    int choice; // to get the user choice
    Console.Write("\n-->\t BASIC CALCULATOR \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division \n5. Tables \n6. Shapes & Patterns \n0. Exit \n~  Enter choice here : ");   // TO-DO: ADD CALCULUS MATHEMATICS i.e TRIGONOMETRIC FUNCTIONS & POSSIBLE COMBINATIONS PRINTING
    choice = Convert.ToInt32(Console.ReadLine()); // string to int conversion for input is necessary
    switch (choice) // to match the required options & conditions
    {
        case 0: // to exit the program
            Console.WriteLine("\nProgram exited successfully\n");
            break;
        case 1:
            AdditionKaro();
            ShowMenu();
            break;
        case 2:
            SubtractionKaro();
            ShowMenu();
            break;
        case 3:
            MultiplyKaro();
            ShowMenu();
            break;
        case 4:
            DivideKaro();
            ShowMenu();
            break;
        case 5:
            PrintTable();
            ShowMenu();
            break;
        case 6:
            PrintPatterns();
            ShowMenu();
            break;
        default: // out of the range inputs will be handled here
            Console.WriteLine("\nerror: invalid input\n");
            ShowMenu(); // this will re-loop the menu to continue on errors
            break;
    }
}

// Actual user-defined required functions for "simple basic calculator"
void AdditionKaro()
{
    Console.Write("\nHow many numbers to add : ");
    int noCount = Convert.ToInt32(Console.ReadLine());
    long[] inputNumbers = new long[noCount]; // size of array on user-choice & demand
    int i = 0; // iterator
    long sum = 0; // sum
    while (i < noCount) // Taking the user inputs: the numbers // Addition formula is also applied here
    {
        Console.Write("Enter Number : ");
        inputNumbers[i] = Convert.ToInt64(Console.ReadLine());
        sum = AddKaro(sum, inputNumbers[i]); // quickly adds the input number // :: use of Lambda Delegate Method
        i++;
    }
    Console.Write($"\nThe sum of the given numbers is :: {sum}\n"); // output
    Console.ReadLine(); // to pause for a moment
}

void SubtractionKaro()
{
    // it will add 2 numbers
    Console.Write("\n\nEnter 1st Number : ");
    long firstInput = Convert.ToInt64(Console.ReadLine());
    Console.Write("Enter 2nd Number : ");
    long secondInput = Convert.ToInt64(Console.ReadLine());
    Console.WriteLine($"{firstInput} - {secondInput} = {MinusKaro(firstInput, secondInput)}"); // :: used Lambda Delegate method MinusKaro()
    Console.ReadLine(); // to stay on screen for a while
}

void MultiplyKaro()
{
    Console.Write("\n1. Find Power of a number \n2. Simple Multiplication \n3. Back to main menu \n0. Exit Program \n~~ Enter choice here : ");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1) // finding the power
    {
        Console.Write("\nEnter base value : ");
        long baseValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Exponent : ");
        long powerValue = Convert.ToInt32(Console.ReadLine());
        long ans = 1; // initialization to 1 for multiplication
        for (int i = 0; i < powerValue; i++) // power-times the loop will run
        {
            ans = ZarabKaro(ans, baseValue); // :: Lambda expression for multiplication that will work as power function, (line 08)
        }
        Console.WriteLine($"{baseValue}^{powerValue} = {ans}");
    }
    else if (choice == 2) // diverse multiplication
    {
        Console.Write("\nHow many numbers to multiply : ");
        int count = Convert.ToInt32(Console.ReadLine());
        long ans = 1; // multiplicative initialization
        while (count > 0) // step vise gets input and performs multiplication immediately on each step
        {
            Console.Write("Enter your number : ");
            long input = Convert.ToInt64(Console.ReadLine());
            ans = ZarabKaro(ans, input); // :: Lambda expression for multiplication, (line 08)
            count--;
        }
        Console.WriteLine($"\nProduct = {ans}\n");
    }
}

void DivideKaro()
{
    Console.Write("\n(only integers)\n\nEnter Dividend : ");
    int dividend = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Devisor : ");
    int devisor = Convert.ToInt32(Console.ReadLine());
    TaqseemKaro(dividend, devisor); // :: Lambda Action method, (line 09)
    Console.ReadLine(); // to stay for a while
}

void PrintTable()
{
    Console.Write("\nEnter Number : ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("How long the table should go (enter range) : ");
    int range = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i < range + 1; i++)
    {
        Console.WriteLine($"{number} x {i} = {number * i}");
    }
    Console.ReadLine();
}

void PrintPatterns()
{
    Console.Write("\n0.  Exit Program \n1.  Square \n2.  Parallelogram \n3.  Upper Triangle \n4.  Lower Triangle \n5.  Bird Row \n6.  Cross Pattern \n7.  Alphabets Triangles \n8.  Hollow Shapes \n9.  Left Counting \n10. Right Alphabets \n11. Up Right Triangle \n12. Up Left Triangle \n13. ABC & Counting \n14. Gap Counting \n15. Plus Sign \n~   Enter choice here : ");
    string? choice = Console.ReadLine(); // I used string? just for testing & fun purpose as an alternative to char/int data types
    switch (choice)
    {
        case "0":
            break; // this will go to main menu directly
        case "1":
            PrintSquarePatterns();
            PrintPatterns(); // back to the shapes printing menu
            break;
        case "2":
            PrintParallelograms();
            PrintPatterns();
            break;
        case "3":
            PrintUpperTriangles();
            PrintPatterns();
            break;
        case "4":
            PrintLowerTriangles();
            PrintPatterns();
            break;
        case "5":
            PrintBirdsRow();
            PrintPatterns();
            break;
        case "6":
            // PrintCrossPatterns();
            PrintPatterns();
            break;
        case "7":
            // PrintAlphabetTriangles();
            PrintPatterns();
            break;
        case "8":
            // PrintHollowShapes();
            PrintPatterns();
            break;
        case "9":
            // PrintLeftCounting();
            PrintPatterns();
            break;
        case "10":
            // PrintRightAlphabets();
            PrintPatterns();
            break;
        case "11":
            // PrintUpRightTriangle();
            PrintPatterns();
            break;
        case "12":
            // PrintUpLeftTriangle();
            PrintPatterns();
            break;
        case "13":
            // PrintABCandCounting();
            PrintPatterns();
            break;
        case "14":
            // PrintGapCounting();
            PrintPatterns();
            break;
        case "15":
            // PrintPlusSign();
            PrintPatterns();
            break;
        default:
            Console.WriteLine("\nerror: invalid input\n");
            PrintPatterns();
            break;
    }
}


// Print Patterns Menu Functions List
void PrintSquarePatterns()
{
    Console.Write("\nEnter Height of the Square : ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the Character to be Printed : ");
    char character = Convert.ToChar(Console.ReadLine());

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < height; j++)
            Console.Write(character + " ");
        Console.Write('\n');
    }
    Console.ReadLine(); // to stay for a while
}

void PrintParallelograms()
{
    Console.Write("\nEnter Height of Parallelogram : ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter width of Parallelogram : ");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter character to be printed : ");
    char character = Convert.ToChar(Console.ReadLine());

    for (int h = 0; h < height; h++)
    {
        for (int w = 0; w < width; w++)
            Console.Write(character + " ");
        Console.Write('\n');
    }
    Console.ReadLine(); // to stay for a while
}

void PrintUpperTriangles()
{
    Console.Write("\nEnter height : ");
    int height = Convert.ToInt32((Console.ReadLine()));
    Console.Write("Enter character : ");
    char ch = Convert.ToChar(Console.ReadLine());
    Console.Write("\n\n");
    for (int i = 0; i < height; i++)
    {
        for (int s = 0; s < i; s++)
            Console.Write("  ");
        for (int j = i; j < height; j++)
            Console.Write(ch + " ");
        Console.Write('\n');
    }
    Console.WriteLine("\nUpper Right Half Triangle\n\n"); // 1st
    for (int i = 0; i < height; i++)
    {
        for (int j = height; j > i; j--)
            Console.Write(ch + " ");
        Console.Write('\n');
    }
    Console.WriteLine("\nUpper Left Half Triangle\n\n"); // 2nd
    for (int i = height; i > 0; i--)
    {
        for (int s = height; s > i; s--)
            Console.Write(' ');
        for (int j = 0; j < (i * 2 - 1); j++)
            Console.Write(ch);
        Console.Write('\n');
    }
    Console.WriteLine("\nUpper Downside Pyramid"); // 3rd
}

void PrintLowerTriangles()
{
    Console.Write("\nEnter height : ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter character : ");
    char ch = Convert.ToChar(Console.ReadLine());

    Console.Write("\n\n");
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j <= i; j++)
            Console.Write(ch);
        Console.Write('\n');
    }
    Console.WriteLine("\nLower Left Triangle\n\n");
    for (int i = 0; i < height; i++)
    {
        for (int s = i; s < height - 1; s++)
            Console.Write(' '); // inserts spaces
        for (int j = 0; j <= (i * 2); j++)
            Console.Write(ch);
        Console.Write('\n');
    }
    Console.WriteLine("\nLower Upwards Pyramid\n\n");
    for (int i = 0; i < height; i++)
    {
        for (int s = i; s < height - 1; s++)
            Console.Write(' ');
        for (int j = 0; j <= i; j++)
            Console.Write(ch);
        Console.Write('\n');
    }
    Console.WriteLine("\nLower Right Triangle\n\n");
}

void PrintBirdsRow()
{
    Console.Write("\nEnter height : ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter character : ");
    char ch = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("\nview # 01\n");
    for (int i = height; i > -1; i--)
    {
        for (int s = height; s > i; s--)
            Console.Write(' ');
        for (int j = 0; j <= 2 * i; j++)
            if (j == 0 || j == (2 * i))
                Console.Write(ch);
            else
                Console.Write(' ');
        Console.Write('\n');
    }
    Console.WriteLine("\nview # 02\n");
    for (int i = 0; i < height; i++)
    {
        for (int s = i; s < height - 1; s++)
            Console.Write(' ');
        for (int j = 0; j <= (2 * i); j++)
        {
            if (j == 0 || j == (2 * i))
                Console.Write(ch);
            else
                Console.Write(' ');
        }
        Console.Write('\n');
    }
}

