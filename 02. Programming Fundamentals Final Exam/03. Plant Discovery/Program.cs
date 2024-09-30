//22:48 - 23:45
int count = int.Parse(Console.ReadLine());

List<Plant> plants = new List<Plant>();


for (int i = 0; i < count; i++)
{
    string[] plantInfo = Console.ReadLine().Split("<->");

    string plantName = plantInfo[0];
    int plantRatity = int.Parse(plantInfo[1]);

    Plant plant = new Plant();
    plant.Name = plantName;
    plant.Rarity = plantRatity;

    if (plants.Contains(plant))
    {
        plant.Rarity = plantRatity;
        continue;
    }
    plants.Add(plant);
}

string input = string.Empty;

while ((input = Console.ReadLine()) != "Exhibition")
{
    string[] commandInfo = input.Split(":");
    string command = commandInfo[0];
    string[] plantInfo = commandInfo[1].Split("-", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
    string plantName = plantInfo[0];

    Plant plant = plants.FirstOrDefault(x => x.Name == plantName);
     
    if (plant == null)
    {
        Console.WriteLine("error");
        continue;
    }
     
    if (command == "Rate")
    {
        int plantRating = int.Parse(plantInfo[1]);

        plant.Raitings.Add(plantRating);
    }

    else if (command == "Update")
    {
        int newRarity = int.Parse(plantInfo[1]);

        plant.Rarity = newRarity;
    }
    else if (command == "Reset")
    {
        plant.Raitings.Clear();
    }
}

Console.WriteLine("Plants for the exhibition:");
foreach (Plant plant in plants)
{
    double avarageRating = 0;

    if (plant.Raitings.Count == 0)
    {
        avarageRating = plant.Raitings.Sum();
    }
    else
    {
        avarageRating = (double)plant.Raitings.Sum() / plant.Raitings.Count;
    }

    Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {avarageRating:F2}");
}



class Plant
{
    public Plant()
    {
        Raitings = new List<int>();
    }
    public string Name { get; set; }

    public int Rarity { get; set; }

    public List<int> Raitings { get; set; }

}