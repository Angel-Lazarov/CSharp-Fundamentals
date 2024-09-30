//Arrays - More Exercise - 03. Recursive Fibonacci

int n = int.Parse(Console.ReadLine());
long[] array = new long[n];
if (n == 1)
{
    Console.WriteLine(1);
}
else
{
    array[0] = 1;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    Console.WriteLine(array[n - 1]);
}