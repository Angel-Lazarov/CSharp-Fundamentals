using System.Text.RegularExpressions;

List<Furniture> furnitures = new List<Furniture>();

string patern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.\d+|\d+)!(?<count>\d+)";

string input = string.Empty;

while ((input = Console.ReadLine()) != "Purchase")
{

    Regex regex = new Regex(patern);
    MatchCollection matches = regex.Matches(input);

    foreach (Match match in matches)
    {
        Furniture furniture = new Furniture();
        furniture.Name = match.Groups["name"].Value;
        furniture.Price = decimal.Parse(match.Groups["price"].Value);
        furniture.Quantity = int.Parse(match.Groups["count"].Value);

        furnitures.Add(furniture);
    }
}

decimal total = 0;
Console.WriteLine("Bought furniture:");

foreach (Furniture furniture in furnitures)
{
    Console.WriteLine($"{furniture.Name}");
    total += furniture.Total();
}

Console.WriteLine($"Total money spend: {total:F2}");

class Furniture
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal Total()
    {
        return Price * Quantity;
    }
}