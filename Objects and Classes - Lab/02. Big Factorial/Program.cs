using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        // Objects and Classes - Lab - 02. Big Factorial
        int.TryParse(Console.ReadLine(), out int n);
        BigInteger fac = 1;

        for (int i = 1; i <= n; i++)
        {
            fac *= i;
        }
        Console.WriteLine(fac);
    }
}