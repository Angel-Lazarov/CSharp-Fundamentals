
using System.Text.RegularExpressions;

List<Fighter> names = new List<Fighter>();

//string[] daemons = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.TrimEntries).ToArray(); // 90/100 ?????????????
string[] daemons = Console.ReadLine()
                                     .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(x => x.Trim())
                                     .ToArray();



string helthPattern = @"[^\d*\+\-\*\/\.]";
string demagePattern = @"[+|-]?\d+\.\d+|[+|-]?\d+";
string operationPattern = @"[*\/]";


foreach (string daemon in daemons) //за всеки демон в списъка
{
    int healthInt = 0;
    double demage = 0;

    //ползвай шаблона за health 
    foreach (Match match in Regex.Matches(daemon, helthPattern))
    {
        // string str = "A";
        // char character = char.Parse(str);

        char healthChar = char.Parse(match.Value);
        healthInt += healthChar;

    }
    //ползвай шаблона за demage 
    foreach (Match match in Regex.Matches(daemon, demagePattern))
    {
        demage += double.Parse(match.Value);
    }

    foreach (Match match in Regex.Matches(daemon, operationPattern))
    {
        if (match.Value == "*")
        {
            demage *= 2;
        }
        else if (match.Value == "/")
        {
            demage /= 2;
        }
    }
    
    Fighter fighter = new Fighter();
    fighter.Name = daemon;
    fighter.Health = healthInt;
    fighter.Demage = demage;
    names.Add(fighter);
}

List<Fighter> sortedList = names.OrderBy(f => f.Name).ToList();
sortedList.ForEach(x=>Console.WriteLine($"{x.Name} - {x.Health} health, {x.Demage:F2} damage"));

class Fighter
{
    public string Name { get; set; }

    public double Health { get; set; }

    public double Demage { get; set; }
}