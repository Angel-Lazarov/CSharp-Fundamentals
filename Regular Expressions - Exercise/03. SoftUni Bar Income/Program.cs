using System.Text.RegularExpressions;

List<Order> orders = new List<Order>();

//string pattern = @"%(?<customerName>[A-Z][a-z]+)%<(?<productName>[A-Z][a-z]+)>\w*\|(?<count>\d+)\|(?:\w{0}|[a-z]+)(?<price>\d+\.\d+|\d+)\$";
string pattern = @"%(?<customerName>[A-Z][a-z]+)%[^|$%.]*<(?<productName>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d+)\$";
decimal totalIncome = 0;

string input = string.Empty;
while ((input = Console.ReadLine()) != "end of shift")
{
    MatchCollection orderTokens = Regex.Matches(input, pattern);
    foreach (Match token in orderTokens)
    {
        string customerName = token.Groups["customerName"].Value;
        string productName = token.Groups["productName"].Value;
        int count = int.Parse(token.Groups["count"].Value);
        decimal price = decimal.Parse(token.Groups["price"].Value);

        Order order = new Order(customerName, productName, count, price);
        orders.Add(order);
        decimal total = order.TotalPrice();

        Console.WriteLine($"{customerName}: {productName} - {total:F2}");
        totalIncome += total;
    }
}

Console.WriteLine($"Total income: {totalIncome:F2}");
class Order
{
    public Order(string customer, string product, int count, decimal price)
    {
        Customer = customer;
        Product = product;
        Count = count;
        Price = price;
    }
    public string Customer { get; set; }

    public string Product { get; set; }

    public int Count { get; set; }

    public decimal Price { get; set; }

    public decimal TotalPrice()
    {
        return Count * Price;
    }
}
