int carsCount = int.Parse(Console.ReadLine());

List<Car> cars = new List<Car>();

for (int i = 0; i < carsCount; i++)
{
    string[] carInfo = Console.ReadLine().Split();
    string model = carInfo[0];
    int engineSpeed = int.Parse(carInfo[1]);
    int enginePower = int.Parse(carInfo[2]);
    int cargoWeight = int.Parse(carInfo[3]);
    string cargoType = carInfo[4];

    Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);
    cars.Add(car);
}

string comand = Console.ReadLine();

if (comand == "fragile")
{
    foreach (Car car in cars.Where(x => x.Cargo.CargoType == comand).Where(x => x.Cargo.CargoWeight < 1000))
    {
        Console.WriteLine(car.Model);
    }
}
else 
{
    foreach (Car car in cars.Where(x => x.Cargo.CargoType == comand).Where(x => x.Engine.EnginePower > 250))
    {
        Console.WriteLine(car.Model);
    }
}


class Engine 
{
    public int EngineSpeed { get; set; }
    public int EnginePower { get; set; }
}

class Cargo 
{
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }
}

class Car 
{
    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
    {
        Engine = new Engine();
        Cargo = new Cargo();
        Model = model;
        Engine.EngineSpeed = engineSpeed;
        Engine.EnginePower = enginePower;
        Cargo.CargoWeight = cargoWeight;
        Cargo.CargoType = cargoType;
    }

    public string Model { get; set; }

    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
}