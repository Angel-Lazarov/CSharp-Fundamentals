int.TryParse(Console.ReadLine(), out int wagons);
int[] passengers = new int[wagons];
int sum = 0;

for (int i = 0; i < wagons; i++)
{
    passengers[i] = int.Parse(Console.ReadLine());
    sum += passengers[i];
}

Console.WriteLine(string.Join(" ", passengers));
Console.WriteLine(sum);