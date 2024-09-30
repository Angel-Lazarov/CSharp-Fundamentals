using System;

List<Person> persons = new List<Person>();
List<Product> listOfProducts = new List<Product>();

for (int i = 1; i <= 2; i++)
{
    if (i == 1)
    {
        string[] tokens = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries); // ["Peter=11", "George=4"]
        foreach (string token in tokens)
        {
            Person person = new Person();
            string[] info = token.Split('=', StringSplitOptions.RemoveEmptyEntries);
            person.Name = info[0];
            person.Money = double.Parse(info[1]);
            persons.Add(person);
        }
    }
    else if (i == 2)
    {
        string[] tokens = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries); // ["Bread=10", "Milk=2"]
        foreach (string token in tokens)
        {
            Product product = new Product();
            string[] info = token.Split('=', StringSplitOptions.RemoveEmptyEntries);
            product.Name = info[0];
            product.Cost = double.Parse(info[1]);
            listOfProducts.Add(product);
        }
    }
}

string comand = string.Empty;
while ((comand = Console.ReadLine()) != "END")
{
    string[] comandInfo = comand.Split();
    string name = comandInfo[0];
    string product = comandInfo[1];

    Product currentProduct = listOfProducts.FirstOrDefault(x => x.Name == product);
    Person currentPerson = persons.FirstOrDefault(p => p.Name == name);

    if (currentPerson.Money >= currentProduct.Cost)
    {
        Console.WriteLine($"{name} bought {product}");
        currentPerson.Money -= currentProduct.Cost;
        currentPerson.Products.Add(currentProduct);
    }
    else
    {
        Console.WriteLine($"{name} can't afford {product}");
    }
}

foreach (Person man in persons)
{
    if (man.Products.Count > 0)
    {
        List<string> productNames = new List<string>();

        foreach (Product product in man.Products)
        {
            productNames.Add(product.Name);
        }
        Console.WriteLine($"{man.Name} - {String.Join(", ", productNames)}");
    }
    else
    {
        Console.WriteLine($"{man.Name} - Nothing bought");
    }
}





class Product
{
    public string Name { get; set; }
    public double Cost { get; set; }
}

class Person
{
    public Person()
    {
        Products = new List<Product>();
    }

    public string Name { get; set; }

    public double Money { get; set; }

    public List<Product> Products { get; set; }

}