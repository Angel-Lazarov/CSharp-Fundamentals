string[] array = Console.ReadLine()
    .Split()
    .ToArray();
string[] reversed = array.Reverse().ToArray();
Console.WriteLine(string.Join(" ", reversed));