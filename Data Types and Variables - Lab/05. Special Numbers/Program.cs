﻿int.TryParse(Console.ReadLine(), out int number);
for (int i = 1; i <= number; i++)
{
    int sum = 0;
    int currentNumber = i;

    while (currentNumber>0) 
    {
        sum += currentNumber % 10;
        currentNumber /= 10;
    }
    if (sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }    
    else 
    {
        Console.WriteLine($"{i} -> False"); 
    }
}