//A12b s17G

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


decimal sum = 0;

foreach (string str in input)
{
    char firstLetter = str[0];
    char lastLetter = str[str.Length - 1];

    decimal result = 0;

    string numberString = str.Substring(1, str.Length - 2);
    decimal number = decimal.Parse(numberString);

    if (char.IsUpper(firstLetter))
    {
        decimal position = decimal.Parse((firstLetter - 'A' + 1).ToString());
        result = number / position;
    }
    else if (char.IsLower(firstLetter))
    {
        int position = int.Parse((firstLetter - 'a' + 1).ToString());
        result = number * position;
    }

    if (char.IsUpper(lastLetter))
    {
        int position = int.Parse((lastLetter - 'A' + 1).ToString());
        result -= position;
    }
    else if (char.IsLower(lastLetter))
    {
        int position = int.Parse((lastLetter - 'a' + 1).ToString());
        result += position;
    }
    sum += result;
}

Console.WriteLine($"{sum:F2}");