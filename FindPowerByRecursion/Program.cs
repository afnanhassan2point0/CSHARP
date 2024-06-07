Console.Write("Enter the base value : ");
int baseInput = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the power factor : ");
int powerInput = Convert.ToInt32(Console.ReadLine());
decimal powerValue = findPower(baseInput, powerInput); // i.e 10^10
Console.Write(powerValue);

static decimal findPower(int baseValue, int powerFactor)
{
    if (powerFactor == 0)
        return 1;
    return baseValue * findPower(baseValue, powerFactor - 1);
}