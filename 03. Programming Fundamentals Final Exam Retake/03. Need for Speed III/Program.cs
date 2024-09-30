//22:53 - 23:20-debug - 23:35

int n = int.Parse(Console.ReadLine());
List<Car> cars = new List<Car>();


for (int i = 0; i < n; i++)
{
    string[] carinfo = Console.ReadLine().Split("|");

    Car car = new Car(carinfo[0], int.Parse(carinfo[1]), int.Parse(carinfo[2]));
    cars.Add(car);
}

string input = string.Empty;
while ((input = Console.ReadLine()) != "Stop")
{
    string[] commandInfo = input.Split(" : ");
    string command = commandInfo[0];
    string name = commandInfo[1];

    Car car = cars.FirstOrDefault(c => c.Name == name);

    switch (command)
    {
        case "Drive":
            int distanceToDrive = int.Parse(commandInfo[2]);
            int fuelNeeded = int.Parse(commandInfo[3]);

            if (fuelNeeded > car.FuelAvailable)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                car.Mileage += distanceToDrive;
                car.FuelAvailable -= fuelNeeded;
                Console.WriteLine($"{car.Name} driven for {distanceToDrive} kilometers. {fuelNeeded} liters of fuel consumed.");

                if (car.Mileage >= 100000)
                {
                    cars.Remove(car);
                    Console.WriteLine($"Time to sell the {car.Name}!");
                }
            }
            break;
        case "Refuel":
            int fuelAdded = int.Parse(commandInfo[2]);
                       //15             //50
            if (car.FuelAvailable + fuelAdded > 75)
            {
                fuelAdded = 75 - car.FuelAvailable;
                car.FuelAvailable += fuelAdded;
                Console.WriteLine($"{car.Name} refueled with {fuelAdded} liters");
            }
            else
            {
                car.FuelAvailable += fuelAdded;
                Console.WriteLine($"{car.Name} refueled with {fuelAdded} liters");
            }


            break;
        case "Revert":
            int kilometersRevert = int.Parse(commandInfo[2]);


            if (car.Mileage - kilometersRevert < 10000)
            {
                car.Mileage = 10000;
            }
            else
            {
                car.Mileage -= kilometersRevert;
                Console.WriteLine($"{car.Name} mileage decreased by {kilometersRevert} kilometers");
            }
            break;
    }
}

cars.ForEach(x => Console.WriteLine($"{x.Name} -> Mileage: {x.Mileage} kms, Fuel in the tank: {x.FuelAvailable} lt."));



class Car
{
    public Car(string name, int mileage, int fuelAvailable)
    {
        Name = name;
        Mileage = mileage;
        FuelAvailable = fuelAvailable;
    }

    public string Name { get; set; }

    public int Mileage { get; set; }

    public int FuelAvailable { get; set; }

}