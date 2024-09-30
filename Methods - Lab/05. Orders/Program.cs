namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = int.Parse(Console.ReadLine());
            
            double total = PriceCalculation(product, quantity);
            Console.WriteLine($"{total:f2}");
        }
        static double PriceCalculation(string product, double quantity)
        {
            double result = 0;

            if (product == "coffee")
            {
                result = quantity * 1.50;
            }
            else if (product == "water")
            {
                result = quantity * 1.0;
            }
            else if (product == "coke")
            {
                result = quantity * 1.4;
            }
            else if (product == "snacks")
            {
                result = quantity * 2;
            }
            return result;
        }
    }
}