//Tortuga||345000||1250

string input = string.Empty;
List<Town> towns = new List<Town>();


while ((input = Console.ReadLine()) != "Sail")
{
    string[] tokens = input.Split("||").ToArray();
    string name = tokens[0];
    int people = int.Parse(tokens[1]);
    int gold = int.Parse(tokens[2]);


   // bool IsNewTown = towns.Any(x => x.Name == name);
    Town currentTown = towns.FirstOrDefault(x => x.Name == name);

    if(currentTown == null)
  //  if (!IsNewTown)
    {
        Town town = new Town(name, people, gold);
        towns.Add(town);
    }
    else
    {
        currentTown.Increase(people, gold);
        //currentTwon.PeopleInTown += people;
        //currentTwon.GoldInTown += gold;
    }
}

while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split("=>").ToArray();
    string command = tokens[0];
    string name = tokens[1];
    Town currentTown = towns.FirstOrDefault(x => x.Name == name);

    if (command == "Plunder")
    {
        int people = int.Parse(tokens[2]);
        int gold = int.Parse(tokens[3]);
        currentTown.Plunder(people, gold);
        Console.WriteLine($"{currentTown.Name} plundered! {gold} gold stolen, {people} citizens killed.");

        if (currentTown.GoldInTown == 0 || currentTown.PeopleInTown == 0)
        {
            towns.Remove(currentTown);
            Console.WriteLine($"{currentTown.Name} has been wiped off the map!");
        }
    }
    else if (command == "Prosper")
    {
        int gold = int.Parse(tokens[2]);
        if (gold >= 0)
        {
            currentTown.Prosper(gold);
            Console.WriteLine($"{gold} gold added to the city treasury. {name} now has {currentTown.GoldInTown} gold.");
        }
        else
        {
            Console.WriteLine("Gold added cannot be a negative number!");
        }
    }
}

if (towns.Count == 0)
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}
else
{
    Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
    towns.ForEach(x => Console.WriteLine($"{x.Name} -> Population: {x.PeopleInTown} citizens, Gold: {x.GoldInTown} kg"));
}







class Town
{
    public Town(string name, int people, int gold)
    {
        Name = name;
        PeopleInTown = people;
        GoldInTown = gold;
    }
    public string Name { get; set; }
    public int PeopleInTown { get; set; }

    public int GoldInTown { get; set; }

    public void Plunder(int people, int gold)
    {
        PeopleInTown -= people;
        GoldInTown -= gold;
    }

    public void Prosper(int gold)
    {
        GoldInTown += gold;
    }

    public void Increase(int poople, int gold)
    {
        PeopleInTown += poople;
        GoldInTown += gold;
    }
}