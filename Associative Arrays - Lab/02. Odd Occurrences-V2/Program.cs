string[] input = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> kvp = new Dictionary<string, int>();

foreach (var word in input)
{
    if (!kvp.ContainsKey(word))
    {
        kvp.Add(word, 0);
    }
    kvp[word]++;
}

foreach (var item in kvp.Where(x => x.Value % 2 != 0))
{
    Console.Write($"{item.Key} ");
}

//foreach (var item in kvp)
//{
//    if (item.Value % 2 != 0)
//    {
//        Console.Write($"{item.Key} ");
//    }
//}