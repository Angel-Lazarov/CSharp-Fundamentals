//Data Types and Variables - More Exercise - 03. Floating Equality
decimal.TryParse(Console.ReadLine(), out decimal first);
decimal.TryParse(Console.ReadLine(), out decimal second);

decimal difference = Math.Abs(first - second);
decimal eps = 0.000001m;

if (difference >= eps)
{ Console.WriteLine("False"); }
else if (difference < eps)
{ Console.WriteLine("True"); }