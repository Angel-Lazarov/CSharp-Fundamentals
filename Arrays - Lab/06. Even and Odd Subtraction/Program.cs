int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sumEven = 0;
int  sumOdd = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        sumEven += array[i];
    }
    else 
    {
    sumOdd += array[i];
    }
}
Console.WriteLine(sumEven-sumOdd);
