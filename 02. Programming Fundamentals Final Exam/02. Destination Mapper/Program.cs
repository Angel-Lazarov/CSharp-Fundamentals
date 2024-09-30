using System.Text.RegularExpressions;

string input = Console.ReadLine();
List<string> destinations = new List<string>();
string pattern = @"(=|\/)(?<body>[A-Z]{1}[A-Za-z]{2,})(\1)";

MatchCollection matches = Regex.Matches(input, pattern);
int travelPoints = 0;

foreach (Match match in matches) 
{
    int bodyPoints = match.Groups["body"].Length;
    string body = match.Groups["body"].Value;
    destinations.Add(body);
    travelPoints += bodyPoints;
}
Console.WriteLine($"Destinations: " + string.Join(", ", destinations));
Console.WriteLine($"Travel Points: {travelPoints}");