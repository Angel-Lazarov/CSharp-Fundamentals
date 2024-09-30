int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int.TryParse(Console.ReadLine(), out int rotation);

for (int j = 0; j < rotation; j++)
{
    int firstNumber = array[0];
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = array[i + 1];
    }
    array[array.Length - 1] = firstNumber;
}
Console.WriteLine(string.Join(" ", array));