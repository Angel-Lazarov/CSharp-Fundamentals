int.TryParse(Console.ReadLine(), out int number);
int sum = 0;

while (number > 0)
{
    sum += number % 10;
    number = number / 10;
}
Console.WriteLine(sum);