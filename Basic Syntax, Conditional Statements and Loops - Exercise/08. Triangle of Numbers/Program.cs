int.TryParse(Console.ReadLine(), out int number);

for (int row = 1; row <= number; row++)
{
    for (int column = 1; column <= row; column++)
    {
        Console.Write(row + " ");
    }
    Console.WriteLine();
}