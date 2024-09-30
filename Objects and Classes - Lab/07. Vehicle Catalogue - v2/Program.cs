namespace _07._Vehicle_Catalogue___v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Vehicle vehiclesCatalog = new Vehicle();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputInfo = input.Split("/");
                string type = inputInfo[0];
                string brand = inputInfo[1];
                string model = inputInfo[2];
                string number = inputInfo[3];

                if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = number;

                    vehiclesCatalog.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = number;

                    vehiclesCatalog.Trucks.Add(truck);
                }
            }
            Console.WriteLine("Cars:");
            foreach (Car car in vehiclesCatalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (Truck truck in vehiclesCatalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }

    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    public class Vehicle
    {
        public Vehicle()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

}