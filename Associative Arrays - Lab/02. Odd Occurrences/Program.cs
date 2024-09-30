string[] words = Console.ReadLine().ToLower().Split();

Dictionary <string, int> counts= new Dictionary<string, int>();

foreach (string word in words)
{
    if (counts.ContainsKey(word))
    {
        counts[word]++;
    }
    else 
    {
    counts.Add(word, 1);
    }
}

List<string> result = counts.Where(x=>x.Value % 2 !=0).Select(x=>x.Key).ToList();
Console.WriteLine(string.Join(" ", result ));

//foreach (var count in counts.Where(x=>x.Value % 2 != 0))
//{
//    Console.Write(count.Key + " ");

//}
