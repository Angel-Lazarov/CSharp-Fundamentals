﻿string[] input = Console.ReadLine().Split().Where(x=>x.Length % 2 == 0).ToArray();
    Console.WriteLine(string.Join("\n", input));
