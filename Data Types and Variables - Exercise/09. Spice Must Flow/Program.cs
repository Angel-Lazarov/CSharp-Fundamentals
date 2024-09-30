//Data Types and Variables - Exercise - 09. Spice Must Flow
int startingYield = int.Parse(Console.ReadLine());

int days = 0;
int minedTotal = 0;

while (startingYield >= 100)
{
    minedTotal += startingYield - 26;
    days++;
    startingYield -= 10;


    if (startingYield < 100)
    {
        minedTotal -= 26;
    }
}
Console.WriteLine(days);
Console.WriteLine(minedTotal);