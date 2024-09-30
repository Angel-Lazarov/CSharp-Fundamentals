using System.Text;
using System.Text.RegularExpressions;

string[] names = Console.ReadLine().Split(", ");

List<Participiant> participiants = new List<Participiant>();

foreach (string name in names)
{
    participiants.Add(new Participiant(name));
}



string input = string.Empty;
while ((input = Console.ReadLine()) != "end of race")
{

    StringBuilder nameBuilder = new StringBuilder();
    string paternLeters = @"[A-Za-z]";
    foreach (Match match in Regex.Matches(input, paternLeters))
    {
        nameBuilder.Append(match.Value);
    }
    string currentName = nameBuilder.ToString();

    ulong distance = 0;
    string paternNumbers = @"\d";
    foreach (Match match in Regex.Matches(input, paternNumbers))
    {
        distance += ulong.Parse(match.Value);
    }

    foreach (Participiant participiant in participiants)
    {
        if (participiant.Name == currentName)
        {
            participiant.Distance += distance;
        }
    }
}

participiants = participiants.OrderByDescending(x => x.Distance).Take(3).ToList();

Console.WriteLine($"1st place: {participiants[0].Name}");
Console.WriteLine($"2nd place: {participiants[1].Name}");
Console.WriteLine($"3rd place: {participiants[2].Name}");


class Participiant
{
    public Participiant(string name)
    {
        Name = name;
    }
    public string Name { get; set; }

    public ulong Distance { get; set; }
}
