using System;
using System.Collections.Generic;
namespace DecimalToBinarySTACK
{
    class Program
    {
        static long userInput; // stores user input on run time
        static long binaryNumber; // stores found binary number
        static void Main(string[] args)
        {
            Console.Write("Enter Decimal Number : ");
            userInput = Convert.ToInt64(Console.ReadLine()); // user input
            binaryNumber = findBinaryNumber(); // Binary calculations
            binaryNumber = binaryReverseKaro(binaryNumber); // Reverses the Binary Number
            Console.WriteLine("The Binary Number : " + binaryNumber);

            Console.ReadLine(); // raw line to keep the terminal
        }
        static long findBinaryNumber() // returns the reverse binary number
        {
            long decimalNumber = userInput; // temporary number to keep userInput Integrated
            long reverseBinary = 0;
            while (decimalNumber >= 0) // Factorization Process
            {
                int digit = Convert.ToInt16(decimalNumber % 2); // gets the last digit
                reverseBinary = reverseBinary * 10 + digit; // composing the binary number in reverse order
                decimalNumber = decimalNumber / 10; // moving on to the next factorization stage
            }
            return reverseBinary;
        }
        static long binaryReverseKaro(long givenNumber) // reversing the number
        {
            long finalBinary = 0;
            while (givenNumber >= 0)
            {
                finalBinary = (finalBinary * 10) + (givenNumber % 10); // last digit
                givenNumber = givenNumber / 10; // next number stage
            }
            return finalBinary;
        }
    }
}
