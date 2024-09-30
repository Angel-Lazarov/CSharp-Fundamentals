int.TryParse(Console.ReadLine(), out int lines);

int[] firstArray = new int[lines];
int[] secondArray = new int[lines];

for (int i = 0; i < lines; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (i % 2 == 0)
    {
        firstArray[i] = input[0];
        secondArray[i] = input[1];
    }
    else 
    {
        firstArray[i] = input[1];
        secondArray[i] = input[0];
    }
}
Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));