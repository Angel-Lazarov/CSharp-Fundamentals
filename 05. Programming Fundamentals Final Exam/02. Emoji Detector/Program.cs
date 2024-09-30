using System.Text.RegularExpressions;
Dictionary<string, int> emojita = new Dictionary<string, int>();
string input = Console.ReadLine();

string pattern = @"(:{2}|\*{2})(?<emoji>[A-Z]{1}[a-z]{2,})\1";

int coolThreshhold = 1;

foreach (char ch in input)
{
    if (char.IsDigit(ch))
    {
        coolThreshhold *= int.Parse(ch.ToString());
    }
}

MatchCollection matches = Regex.Matches(input, pattern);

int validEmoji = matches.Count;

foreach (Match match in matches)
{
    string emoji = match.Groups[0].Value;
    string emojiBody = match.Groups["emoji"].Value;
    int emojiCoolnes = 0;

    foreach (char ch in emojiBody)
    {
        emojiCoolnes += ch;
    }

    if (!emojita.ContainsKey(emoji) && emojiCoolnes >= coolThreshhold) 
    { 

        emojita.Add(emoji, emojiCoolnes);
    }
}

Console.WriteLine($"Cool threshold: {coolThreshhold}");
Console.WriteLine($"{validEmoji} emojis found in the text. The cool ones are:");
foreach (var kvp in emojita)
{
    Console.WriteLine($"{kvp.Key}");
}
