int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

foreach (int number in numbers)
{
    if (counts.ContainsKey(number))
    {
        counts[number]++;
    }
    else
    {
       counts.Add(number, 1);
    }
}

foreach (var number in counts)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}