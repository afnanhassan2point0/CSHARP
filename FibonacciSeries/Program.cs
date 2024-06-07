Console.Write("Enter First term : ");
int firstInput = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Last/Limit term : ");
int lastInput = Convert.ToInt32(Console.ReadLine());

FibonacciPrintKaro(firstInput, lastInput);

static void FibonacciPrintKaro(int first, int last)
{
    int f = 0, n = 1, s = f + n;
    while (s <= last)
    {
        if (s >= first)
            Console.Write(s + " , ");
        f = n;
        n = s;
        s = f + n;
    }
}