using System.Text;

List<Participant> participants = new List<Participant>();
string[] names = Console.ReadLine().Split(", ");

foreach (string name in names)
{
        participants.Add(new Participant(name));
}

string input = string.Empty;
while ((input = Console.ReadLine()) != "end of race")
{
    string racer = string.Empty;
    int distance = 0;

    foreach (char letter in input)
    {
        if (char.IsLetter(letter))
        {
            racer += letter;
        }
        else if (char.IsDigit(letter))
        {
            distance += int.Parse(letter.ToString());
        }
    }

    if (participants.ContainsKey(racer))
    {
        participants[racer].Distance+=distance;
    }
}

StringBuilder sb = new StringBuilder();
foreach (var person in participants)
{
    sb.Append($"place:{person.Key}");
}
Console.WriteLine(sb);

class Participant
{
    public Participant(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public int Distance { get; set; }
}
