// Program that uses Lambda expression for sending method as parameter to another method
// this program prints different patterns, like square, parallelogram & pyramid etc

Printer((ch, h, w) => // ch: symbol/character, h: height, w: width
 {
     for (int i = 0; i < h; i++)
     {
         for (int j = 0; j < w; j++)
             Console.Write(ch); // prints user given character on looping
         Console.Write('\n'); // inserts end line, new line on inner loop end
     }
 }); // top level statement

void Printer(Action<char, int, int> pattern) // gets user values, inputs
{
    Console.Write("\nEnter the height : ");
    int height = Convert.ToInt32(Console.ReadLine()); // height of the shape as number of rows
    Console.WriteLine("Enter the width : ");
    int width = Convert.ToInt32(Console.ReadLine()); // width as the number of columns
    Console.Write("Enter your desired character : ");
    char symbol = Convert.ToChar(Console.ReadLine()); // symbol to be printed in the shape
    pattern(symbol, width, height); // calling to the Lambda method
}