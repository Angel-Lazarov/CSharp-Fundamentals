string text = Console.ReadLine();

foreach (char element in text)
{
    if (char.IsDigit(element))
    {
        Console.Write(element);
    }
}
Console.WriteLine();

foreach (char element in text)
{
    if (char.IsLetter(element))
    {
        Console.Write(element);
    }
}
Console.WriteLine();

foreach (char element in text)
{
    if (!char.IsDigit(element) && !char.IsLetter(element))
    {
        Console.Write(element);
    }
}
Console.WriteLine();