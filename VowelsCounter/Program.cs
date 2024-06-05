// a Program that counts the vowels in Given Text by User at Runtime
namespace Language;
public static class VowelsCounter // used class for general purpose
{
    public delegate int myDelegate(string stringParameter); // used delegate function

    public static void Main()
    {
        string userInput; // runtime user inputs
        System.Console.Write("\nHey, enter sentence here : "); // msg to take action
        userInput = System.Console.ReadLine(); // takes user input

        if (!string.IsNullOrEmpty(userInput)) // if input exists
        {
            userInput = userInput.ToLower(); // conversion to lower case for ease of operations
            myDelegate md = vowelsCounter;
            int countedVowels = md(userInput);
            System.Console.WriteLine($"\nTotal vowels in your Text are : {countedVowels}");// prints output
        }
        else // if input doesn't exist
        {
            System.Console.WriteLine("\nerror: invalid input\n");
        }
    }
    static int vowelsCounter(string input) // the basic function on vowels counting
    {
        int vowCount = 0; // actual vowels counting tracker
        for (int i = 0; i < input.Length; i++) // loop till text size ends
        {
            if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u') // comparison for vowels
            {
                vowCount++; // actual counting on vowels
            }
        }
        return vowCount;
    }
}