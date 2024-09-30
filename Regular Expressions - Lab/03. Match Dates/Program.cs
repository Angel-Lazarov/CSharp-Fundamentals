using System.Text.RegularExpressions;

string input = Console.ReadLine();
string patern = @"\b(?<day>\d{2})([\.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

MatchCollection matches = Regex.Matches(input, patern);

//Console.WriteLine(matches.Count);

foreach (Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
}