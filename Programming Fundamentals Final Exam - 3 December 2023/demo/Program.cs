int number = int.Parse(Console.ReadLine());
int digit = int.Parse(Console.ReadLine());
int count = 0;
while (number > 0) 
{
    int result = number % 2;
    if (result == digit) { count++; }

    number = number / 2;

}
Console.WriteLine(count);