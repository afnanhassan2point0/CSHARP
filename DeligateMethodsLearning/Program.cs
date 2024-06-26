// Func, Predicate, Action :: via un-named delegate & via Lambda & via named delegates Expressions

// used Action :: because nothing was to return
// predicate   :: to be used if true/false (1/0) is the return
// func        :: is used when something to be returned on method call
// syntax is almost same except their own functionality based modifications

// ::::: BUILT-IN DELEGATES
Action<int, int, int> MultiplyKaro = delegate (int a, int b, int c) // un-named delegates non-lambda expression
{
    Console.WriteLine("Multiplication: " + (a * b * c));
};
Action<int, int, int> AddKaro = (int a, int b, int c) => // lambda expression
{
    Console.WriteLine("Addition : " + (a + b + c));
};

AddKaro(2, 3, 4);
MultiplyKaro(2, 3, 4);




// ::::: DELEGATE METHOD FOR THE NAMED FUNCTIONS/METHODS
/*
Calculator AddNumbers = Addition;

AddNumbers(2, 2, 2);

void Addition(int a, int b, int c)
{
    Console.WriteLine(a + b + c);
}

delegate void Calculator(int x, int y, int z);
*/
