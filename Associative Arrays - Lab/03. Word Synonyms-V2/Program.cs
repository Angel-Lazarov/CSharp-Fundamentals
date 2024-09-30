int.TryParse(Console.ReadLine(), out int n);

Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{ 
    string word = Console.ReadLine();
    string syno = Console.ReadLine();

    if (!synonyms.ContainsKey(word)) 
    {
        synonyms[word] = new List<string>();
    }
    synonyms[word].Add(syno);
}

foreach (var item in synonyms)
{
    Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
}
