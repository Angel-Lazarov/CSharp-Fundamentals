
using System.Net.Sockets;

double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

SortedDictionary <double, int> counts = new SortedDictionary<double, int>();

foreach (var number in numbers) 
{
    if (counts.ContainsKey(number))
    {
        counts[number] += 1;
    }
    else 
    {
    counts.Add(number, 1);
    }
}
foreach (var item in counts)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}
// shutdown /s /t 52440