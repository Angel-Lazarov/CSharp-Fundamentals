namespace _01._The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bisquitsPerWorkerForDay = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int otherFactoryProduction = int.Parse(Console.ReadLine());
            
            int totalProduction = 0;

            for (int i = 1; i <= 30; i++)
            {
                double bisquitsPerDay = bisquitsPerWorkerForDay * workersCount;

                if (i % 3 == 0)
                {
                   bisquitsPerDay = Math.Floor(bisquitsPerDay * 0.75);
                }
                totalProduction += (int)bisquitsPerDay;
            }

            int difference = Math.Abs(totalProduction - otherFactoryProduction);
            double percent = (double)difference / otherFactoryProduction * 100;

            Console.WriteLine($"You have produced {totalProduction} biscuits for the past month.");

            if (totalProduction > otherFactoryProduction)
            {
                Console.WriteLine($"You produce {percent:F2} percent more biscuits.");

            }
            else if (totalProduction < otherFactoryProduction)
            {
                Console.WriteLine($"You produce {percent:F2} percent less biscuits.");
            }
        }
    }
}