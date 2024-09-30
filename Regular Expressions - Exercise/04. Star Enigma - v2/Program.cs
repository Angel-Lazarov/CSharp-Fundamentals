
using System.Text;
using System.Text.RegularExpressions;

int number = int.Parse(Console.ReadLine());
List<Message> messages = new List<Message>();

string patternStar = @"[SsTtAaRr]";
string msgPattern = @"@(?<name>[A-Z][a-z]+)[^@\-,!:>]*:(?<population>\d+)[^@\-,!:>]*!(?<action>[A|D])![^@\*,!:>]*->(?<soldiers>\d+)";

for (int i = 0; i < number; i++)
{
    string encryptedMsg = Console.ReadLine();

    int decryptKey = Regex.Matches(encryptedMsg, patternStar).Count;

    StringBuilder decryptedSB = new StringBuilder();

    foreach (char letter in encryptedMsg)
    {
        char ch = (char)(letter - decryptKey);
        decryptedSB.Append(ch);
    }

    string message = decryptedSB.ToString();

    Match match = Regex.Match(message, msgPattern);

    if (!Regex.IsMatch(message, msgPattern)) 
    { continue; }

    string name = match.Groups["name"].Value;
    int population = int.Parse(match.Groups["population"].Value);
    string action = (match.Groups["action"].Value);
    int soldiers = int.Parse(match.Groups["soldiers"].Value);

    Message planet = new Message(name, population, action, soldiers);
    messages.Add(planet);

}

List<Message> filteredMsges = messages.Where(x=>x.Action == "A").OrderBy(x => x.Name).ToList();
Console.WriteLine($"Attacked planets: {filteredMsges.Count}");
filteredMsges.ForEach(x => Console.WriteLine($"-> {x.Name}"));


filteredMsges = messages.Where(x=>x.Action == "D").OrderBy(x => x.Name).ToList();
Console.WriteLine($"Destroyed planets: {filteredMsges.Count}");
filteredMsges.ForEach((x) => Console.WriteLine($"-> {x.Name}"));

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