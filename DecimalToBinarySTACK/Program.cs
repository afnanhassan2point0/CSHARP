﻿
namespace DecimalToBinarySTACK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Decimal Number : ");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            List<int> stack = new List<int>(); // to store the obtained digit in binary
            while (decimalNumber > 0) // calculation of binary & decimal
            {
                stack.add(decimalNumber % 2);
                decimalNumber /= 2; // next decimal input
            }
            for (int i = stack.Count; i > -1; i--)
            {
                Console.Write(stack[i]);
            }
            Console.WriteLine();
        }
    }
}
