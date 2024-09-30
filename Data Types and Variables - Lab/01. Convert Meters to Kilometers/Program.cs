int.TryParse(Console.ReadLine(), out int meters);
double kilometers = meters / 1000d;
Console.WriteLine($"{kilometers:F2}");
