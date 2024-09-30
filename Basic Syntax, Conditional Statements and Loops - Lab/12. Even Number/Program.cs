while (true) 
{
    int.TryParse(Console.ReadLine(), out int n);

    if (n % 2 == 0)
    {
        Console.WriteLine($"The number is: {Math.Abs(n)}");
        break;
    }
    else 
    {
        Console.WriteLine($"Please write an even number.");
    }
}