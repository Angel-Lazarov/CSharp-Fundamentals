decimal britishPounds = decimal.Parse(Console.ReadLine());
decimal usDollars = britishPounds * 1.31m;
Console.WriteLine($"{usDollars:F3}");
