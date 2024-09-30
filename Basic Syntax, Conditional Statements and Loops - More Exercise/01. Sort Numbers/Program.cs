int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

if (x > y && x > z)
{
    if (y > z)
    {
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }
    else
    {
        Console.WriteLine(x);
        Console.WriteLine(z);
        Console.WriteLine(y);
    }
}
else if (y > x && y > z)
{
    if (x > z)
    {
        Console.WriteLine(y);
        Console.WriteLine(x);
        Console.WriteLine(z);
    }
    else
    {
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(x);
    }
}
else if (z > x && z > y)
{
    if (x > y)
    {
        Console.WriteLine(z);
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
    else 
    {
        Console.WriteLine(z);
        Console.WriteLine(y);
        Console.WriteLine(x);
    }
}