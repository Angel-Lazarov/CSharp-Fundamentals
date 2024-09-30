//Data Types and Variables - Exercise - 11. Snowballs

using System.Numerics;

byte totalBalls = byte.Parse(Console.ReadLine());
BigInteger bestValue = 0;
short bestSnow = 0;
short bestTime = 0;
byte bestQuality = 0;

for (int i = 0; i < totalBalls; i++)
{
    short snowballSnow = short.Parse(Console.ReadLine());
    short snowballTime = short.Parse(Console.ReadLine());
    byte snowballQuality = byte.Parse(Console.ReadLine());

    BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

    if (snowballValue > bestValue)
    {
        bestValue = snowballValue;
        bestSnow = snowballSnow;
        bestTime = snowballTime;
        bestQuality = snowballQuality;

    }
}
Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");