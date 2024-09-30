//foreach (var item in Console.ReadLine().Split().Where(x => x.Length % 2 == 0))
//{
//    Console.WriteLine(item);
//}

Console.WriteLine(string.Join("\n", (Console.ReadLine().Split().Where(x => x.Length % 2 == 0))));