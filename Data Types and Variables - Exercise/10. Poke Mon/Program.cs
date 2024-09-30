//Data Types and Variables - Exercise - 10. Poke Mon
int startingPower = int.Parse(Console.ReadLine());
int distanceM = int.Parse(Console.ReadLine());
int factorY = int.Parse(Console.ReadLine());
int pokes = 0;
int powerN = startingPower;

while (powerN >= distanceM)
{
    powerN -= distanceM;
    pokes++;

    if (powerN == startingPower / 2 && factorY != 0)
    {
        powerN /= factorY;
    }
}
Console.WriteLine(powerN);
Console.WriteLine(pokes);