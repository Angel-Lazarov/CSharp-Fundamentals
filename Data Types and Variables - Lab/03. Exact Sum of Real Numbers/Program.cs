decimal.TryParse(Console.ReadLine(), out decimal numbers);
decimal sum = 0;
for (int i = 0; i < numbers; i++)
{
    sum += decimal.Parse(Console.ReadLine());
}
Console.WriteLine(sum);