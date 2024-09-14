using System.Text.RegularExpressions;

string patern = @"\b(?<firstName>[A-Z][a-z]+) (?<lastName>[A-Z][a-z]+)\b";
string names = Console.ReadLine();
//------------variant 1 Begin-----------
//Regex regex = new Regex(patern);
//MatchCollection matchedNames = regex.Matches(names);
//------------variant 1 End-----------

//------------variant 2 Begin-----------
MatchCollection matchedNames = Regex.Matches(names, patern);
//------------variant 2 End-----------



//Console.WriteLine(matches.Count);

foreach (Match match in matchedNames) 
{
    //Console.WriteLine($"There is a match!: {match.Groups["firstName"]} {match.Groups[2]}");
    //Console.WriteLine($"With first name: {match.Groups["firstName"]}");
    //Console.WriteLine($"And last name: { match.Groups["lastName"]}");
    //Console.WriteLine(match.Groups[0]);
    Console.Write(match.Value + " ");
}
Console.WriteLine();