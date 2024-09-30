int count = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> synonyms= new Dictionary<string, List<string>>();  


for (int i = 0; i < count; i++) 
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!synonyms.ContainsKey(word))
    {
        synonyms.Add(word, new List<string>());
        synonyms[word].Add(synonym);
    }
    else 
    {
        synonyms[word].Add(synonym);
    }
}
foreach (var synonym in synonyms)
{
    Console.WriteLine($"{synonym.Key} - {string.Join(", ", synonym.Value)}");
}