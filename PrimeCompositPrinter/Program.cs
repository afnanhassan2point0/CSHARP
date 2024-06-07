Console.Write("Enter starting point : ");
int startPoint = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter limiting point : ");
int limitPoint = Convert.ToInt32(Console.ReadLine());

printPrimeComposite(startPoint, limitPoint);

static void printPrimeComposite(int start, int last)
{
    List<int> primeNumbers = []; // dynamic array for creative output
    List<int> compositeNumbers = [];
    for (int number = start; number < last + 1; number++) // each no. within range
    {
        bool primeHey = true; // to check for prime
        for (int divisor = 2; divisor < (number / 2) + 1; divisor++) // d <= n/2 condition
        {
            if (number % divisor == 0) // agar n ksi ek d sy b divide hva,tu wo composite h
            {
                primeHey = false; // n is composite
                break; // further division will be stopped
            }
        }
        if (primeHey)
            primeNumbers.Add(number);
        else // composite hey
            compositeNumbers.Add(number);
    }
    Console.WriteLine();
    Console.WriteLine("Prime Numbers :: ");
    foreach (int i in primeNumbers)
        Console.Write(i + " , ");
    Console.WriteLine();
    Console.WriteLine("Composite Numbers :: ");
    foreach (int i in compositeNumbers)
        Console.Write(i + " , ");
}