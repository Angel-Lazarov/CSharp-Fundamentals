int charNumber = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= charNumber; i++)
{
    int letter = char.Parse(Console.ReadLine());
    sum += letter;
}
Console.WriteLine($"The sum equals: {sum}");