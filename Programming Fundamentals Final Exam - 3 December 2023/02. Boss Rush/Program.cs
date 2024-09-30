using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());


string pattern = @"\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]* [A-Za-z]+)#";

for (int i = 0; i < n; i++) 
{
    string input = Console.ReadLine();
    Match match = Regex.Match(input, pattern);

    if (match.Success)
    {
        string name = match.Groups["name"].Value;
        string title = match.Groups["title"].Value;

        int strength = name.Length;
        int armor = title.Length;

        Console.WriteLine($"{name}, The {title}");
        Console.WriteLine($">> Strength: {strength}");
        Console.WriteLine($">> Armor: {armor}");

    }
    else 
    {
        Console.WriteLine("Access denied!");
    }
}