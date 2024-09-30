
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

//string patern = @">>(?<name>[A-z]+)<<(?<price>\d+\.\d+|\d+)!(?<count>\d+)";
string patern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.\d+|\d+)!(?<count>\d+)";

decimal sum = 0;
string input = string.Empty;
List<string> products = new List<string>();

while ((input = Console.ReadLine()) != "Purchase")
{

    Regex regex = new Regex(patern);
    MatchCollection matches = regex.Matches(input);

    foreach (Match match in matches)
    {
        products.Add(match.Groups["name"].Value);

        int count = int.Parse(match.Groups["count"].Value);
        double price = double.Parse(match.Groups["price"].Value);

        sum += count * (decimal)price;
    }
}
Console.WriteLine("Bought furniture:");

foreach (var product in products)
{
    Console.WriteLine(product);
}

Console.WriteLine($"Total money spend: {sum:F2}");