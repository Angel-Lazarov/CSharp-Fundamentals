int carsCount = int.Parse(Console.ReadLine());

List<Car> cars = new List<Car>();

for (int i = 0; i < carsCount; i++)
{
    string[] carInfo = Console.ReadLine().Split();
    string model = carInfo[0];
    double fuelAmount = double.Parse(carInfo[1]);
    double fuelPerKm = double.Parse(carInfo[2]);

    Car car = new Car
    {
        Model = model,
        FuelAmount = fuelAmount,
        FuelPerKm = fuelPerKm,
        Traveled = 0
    };
    cars.Add(car);
}

string input = string.Empty;
while ((input = Console.ReadLine())!= "End")
{
    string[] comandInfo = input.Split(); 
    string comand = comandInfo[0];  
    string model = comandInfo[1];
    double distancetoDrive = double.Parse(comandInfo[2]);

    Car car = cars.Find(x=>x.Model == model);
    bool canTravel = car.Drive(distancetoDrive);

    if (canTravel) 
    {
        car.Traveled += distancetoDrive;
        double fuelConsumpted = distancetoDrive * car.FuelPerKm;
        car.FuelAmount -= fuelConsumpted;
    }
    else
    {
        Console.WriteLine("Insufficient fuel for the drive");
    }
}

foreach (Car car in cars)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Traveled}");
}

class Car 
{
    public string Model { get; set; }
    public double FuelAmount { get; set;}
    public double FuelPerKm { get; set; }
    public double Traveled { get; set; }  //All cars start at 0 kilometers traveled.

    public bool Drive(double distancetoDrive) 
    {
        if (FuelAmount / FuelPerKm < distancetoDrive)
        { return false; }

        return true;
    }
}