decimal.TryParse(Console.ReadLine(), out decimal balace); 
decimal budjet = balace;                                  
string gameName = string.Empty;

while ((gameName = Console.ReadLine())!="Game Time")
{
    decimal price = 0;

    if (gameName == "OutFall 4") { price = 39.99m; }
    else if (gameName == "CS: OG") { price = 15.99m; }
    else if (gameName == "Zplinter Zell") { price = 19.99m; }
    else if (gameName == "Honored 2") { price = 59.99m; }
    else if (gameName == "RoverWatch") { price = 29.99m; }
    else if (gameName == "RoverWatch Origins Edition") { price = 39.99m; }
    else 
    { 
        Console.WriteLine("Not Found");
        continue;
    }

    if (price <= balace)
    {
        Console.WriteLine($"Bought {gameName}");
        balace -= price; 
    }
    else
    { 
        Console.WriteLine("Too Expensive");
    }

    if (balace == 0) 
    { 
        Console.WriteLine("Out of money!");
        break; 
    }
}
if (balace != 0)
{
    Console.WriteLine($"Total spent: ${budjet - balace:F2}. Remaining: ${balace:F2}");
}
