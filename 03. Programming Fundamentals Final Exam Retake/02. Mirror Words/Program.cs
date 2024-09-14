using System;
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string patettern = @"(@|#)(?<word1>[A-Za-z]{3,})\1{2}(?<word2>[A-Za-z]{3,})\1";
int pairsFound = 0;
List<Pair> pairs = new List<Pair>();
List<string> results = new List<string>();

MatchCollection matches = Regex.Matches(input, patettern);

foreach (Match match in matches)
{
    pairsFound++;

    string word1 = match.Groups["word1"].Value;
    string word2 = match.Groups["word2"].Value;

    string reversed = new string(word2.Reverse().ToArray());

    int result = string.Compare(word1, reversed);

    if (result == 0)
    {
        Pair pair = new Pair(word1, word2);
        pairs.Add(pair);
    }
}

if (pairsFound == 0)
{
    Console.WriteLine("No word pairs found!");
    Console.WriteLine("No mirror words!");
}
else
{
    Console.WriteLine($"{pairsFound} word pairs found!");
    if (pairs.Count == 0)
    {
        Console.WriteLine("No mirror words!");
    }
    else 
    {
        foreach (Pair pair in pairs)
        {
            string result = $"{pair.WordOne} <=> {pair.WordTwo}";
            results.Add(result);
        }
        Console.WriteLine("The mirror words are:");
        Console.WriteLine(string.Join(", ", results));
    }
}


class Pair
{
    public Pair(string wordOne, string wordTwo)
    {
        WordOne = wordOne;
        WordTwo = wordTwo;
    }

    public string WordOne { get; set; }
    public string WordTwo { get; set; }
}