//27.11.23 -> 21:30-23:02
using System.Text.RegularExpressions;

int.TryParse(Console.ReadLine(), out int key);

string input = string.Empty;
while ((input = Console.ReadLine()) != "end")
{
    string decrypted = string.Empty;
    foreach (char ch in input)
    {
        decrypted += (char)(ch - key);
    }
    //any character except '@', '-', '!', ':' and '>'. ->>>>> [""-,.-9;-=? A-~]+ || [^@!:>-]*
    string pattern = @"(?:@(?<name>[A-Za-z]+))[""-,.-9;-=? A-~]+!(?<povedenie>[GN])!";
    Match match = Regex.Match(decrypted, pattern);

    if (match.Groups["povedenie"].Value == "G") 
    {
        Console.WriteLine(match.Groups["name"].Value);
    }
}