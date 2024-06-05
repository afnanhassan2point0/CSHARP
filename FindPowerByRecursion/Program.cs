using System;

namespace Language;

class RecursivePower
{
    static void Main()
    {
        int x = findPower(2, 3);
        Console.Write(x);

        static int findPower(int baseValue, int powerFactor)
        {
            if (powerFactor == 0)
                return 1;
            return baseValue * findPower(baseValue, powerFactor - 1);
        }
    }
}