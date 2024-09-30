int numbers = int.Parse(Console.ReadLine());

for (int i = 1; i <= numbers; i++)
{
    bool isMagic = false;
    int sum = 0;
    int currentNumber = i;

    while (currentNumber > 0)
    {
        sum += currentNumber % 10;
        currentNumber /= 10;
    }
    isMagic = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", i, isMagic);
}
