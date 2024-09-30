int.TryParse(Console.ReadLine(), out int n);
int.TryParse(Console.ReadLine(), out int x);

do
{
    Console.WriteLine($"{n} X {x} = {n * x}");
    x++;
} while (x<=10);

