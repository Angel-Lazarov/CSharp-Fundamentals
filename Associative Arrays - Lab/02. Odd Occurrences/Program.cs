Console.WriteLine(string.Join(" ", Console.ReadLine()
    .Split()
    .Select(x => x.ToLower())
    .GroupBy(x => x)
    .Where(x => x.Count() % 2 == 1)
    .SelectMany(x => x)
    .Distinct()
    .ToList()));
//shutdown /s /t 138600
// 13 2310
