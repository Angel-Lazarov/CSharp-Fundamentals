using System.Diagnostics;
using System.Globalization;

string input = string.Empty;

List<Vehicle> vehicles = new List<Vehicle>();
TextInfo ti = CultureInfo.CurrentCulture.TextInfo;







while ((input = Console.ReadLine()) != "End")
{
    string[] vehicleInfo = input.Split();
    string type = ti.ToTitleCase(vehicleInfo[0]);
    Vehicle vehicle = new Vehicle(type, vehicleInfo[1], vehicleInfo[2], int.Parse(vehicleInfo[3]));

    vehicles.Add(vehicle);
    // vehicle.GetType().Name  ;  
}

while ((input = Console.ReadLine()) != "Close the Catalogue")
{
    string command = input;

    Vehicle curent = vehicles.Find(vehicle => vehicle.Model == command);
    if (curent != null)
    {
        Console.WriteLine(curent);
    }
}

double averageHpCar = 0;

if (vehicles.Any(x => x.Type == "Car"))
{
    List<Vehicle> cars = vehicles.Where((vehicle) => vehicle.Type == "Car").ToList();
    averageHpCar = cars.Average(car => car.Horsepower);
    Console.WriteLine($"Cars have average horsepower of: {averageHpCar:F2}.");
}
else 
{
    Console.WriteLine("Cars have average horsepower of: 0.00."); 
}

double averageHpTruck = 0;
if (vehicles.Any(x => x.Type == "Truck"))
{
    List<Vehicle> trucks = vehicles.Where(vehicle => vehicle.Type == "Truck").ToList();
    averageHpTruck = trucks.Average(truck => truck.Horsepower);
    Console.WriteLine($"Trucks have average horsepower of: {averageHpTruck:F2}.");
}
else 
{
    Console.WriteLine("Trucks have average horsepower of: 0.00.");
}

class Vehicle
{
    public Vehicle(string type, string model, string color, int hp)
    {
        Type = type;
        Model = model;
        Color = color;
        Horsepower = hp;
    }

    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }

    public override string ToString()
    {
        return $"Type: {Type}\n" +
               $"Model: {Model}\n" +
               $"Color: {Color}\n" +
               $"Horsepower: {Horsepower}";
    }

}