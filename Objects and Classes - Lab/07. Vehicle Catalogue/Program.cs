using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

          //  List<Catalog> vehicles = new List<Catalog>();

            while ((input = Console.ReadLine()) != "end")    
            {
                string[] inputInfo = input.Split("/");
                //"{type}/{brand}/{model}/{horse power / weight}"
                //Car/Audi/A3/110
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
                    cars.Add(car);
                }
                else 
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = number;
                    trucks.Add(truck);
                }
            }

            List<Car> sortedCars = cars.OrderBy(x=> x.Brand).ToList();
            List<Truck> sortedTrucks = trucks.OrderBy(x=> x.Brand).ToList();

            if (sortedCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (sortedTrucks.Count > 0) 
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        public class Truck 
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
        }

        public class Car 
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }
        }

        //class Catalog 
        //{
        //    public Catalog() 
        //    {
        //        Car = new Car();
        //        Truck = new Truck();
        //    }
        //    public Car Car { get; set; }
        //    public Truck Truck { get; set; }
        //    public string Type { get; set; }
        //}

    }
}