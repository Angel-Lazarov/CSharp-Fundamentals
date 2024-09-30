/*
 2
STCDoghudd4=63333$D$0A53333
EHfsytsnhf?8555&I&2C9555SR
 
 */

using System.Text;
using System.Text.RegularExpressions;

int number = int.Parse(Console.ReadLine());
List<Message> messages = new List<Message>();
string pattern = @"@(?<name>[A-Z][a-z]+)[^@\-,!:>]*:(?<population>\d+)[^@\-,!:>]*!(?<action>[A|D])![^@\*,!:>]*->(?<soldiers>\d+)";


for (int i = 0; i < number; i++)
{
    int keyCount = 0;
    string encrypted = Console.ReadLine();

    foreach (char letter in encrypted)
    {
        if (letter == 's' || letter == 'S'
            || letter == 't' || letter == 'T'
            || letter == 'a' || letter == 'A'
            || letter == 'r' || letter == 'R')
        {
            keyCount++;
        }
    }

    StringBuilder decryptedSB = new StringBuilder();
    foreach (char letter in encrypted)
    {
        char ch = (char)(letter - keyCount);
        decryptedSB.Append(ch);
    }
    string message = decryptedSB.ToString();

    MatchCollection command = Regex.Matches(message, pattern);

    if (!Regex.IsMatch(message, pattern)) 
    {
        continue; 
    }

    foreach (Match word in command)
    {
        string name = word.Groups["name"].Value;
        int population = int.Parse(word.Groups["population"].Value);
        string action = (word.Groups["action"].Value);
        int soldiers = int.Parse(word.Groups["soldiers"].Value);

        Message planet = new Message(name, population, action, soldiers);
        messages.Add(planet);
    }
}


List<Message> filtered = messages.Where(m => m.Action == "A").OrderBy(m => m.Name).ToList();
Console.WriteLine($"Attacked planets: {filtered.Count}");
filtered.ForEach(m => Console.WriteLine($"-> {m.Name}"));

filtered = messages.Where(m => m.Action == "D").OrderBy(m => m.Name).ToList();
Console.WriteLine($"Destroyed planets: {filtered.Count}");
filtered.ForEach(m => Console.WriteLine($"-> {m.Name}"));

class Message
{
    public Message(string name, int population, string action, int soldiers)
    {
        Name = name;
        Population = population;
        Action = action;
        Soldiers = soldiers;
    }

    public string Name { get; set; }
    public int Population { get; set; }
    public string Action { get; set; }
    public int Soldiers { get; set; }
}