using System.Text;
using System.Text.RegularExpressions;

string text = Console.ReadLine();
string patern = @"\+359( |-)2(\1)\d{3}\1\d{4}\b";

Regex regex = new Regex(patern);
MatchCollection matches = regex.Matches(text);

List<string> list = new List<string>();

foreach (Match match in matches)
{
    list.Add(match.Value);
}

Console.WriteLine(string.Join(", ", list));

