namespace _01._Computer_Store
{
    internal class Program
    {
        public static void Main()
        {
            // 01. Programming Fundamentals Mid Exam Retake - 01. Computer Store

            string input = Console.ReadLine();
            List<decimal> partPrices = new List<decimal>();
            decimal totalPrice = 0;

            while (true)
            {
                if (input == "special") { break; }
                else if (input == "regular") { break; }
                else
                {
                    decimal productPrice = decimal.Parse(input) * 1.2m;

                    if (productPrice > 0)
                    {
                        partPrices.Add(productPrice);
                    }
                    else
                    {
                        Console.WriteLine("Invalid price!");
                    }
                }

                input = Console.ReadLine();
            }

            decimal basePrice = partPrices.Sum() / 1.2m;
            decimal tax = partPrices.Sum() - basePrice;

            if (input == "special")
            {
                totalPrice = partPrices.Sum() - partPrices.Sum() * 0.1m;
            }
            else if (input == "regular")
            {
                totalPrice = partPrices.Sum();
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {basePrice:F2}$");
                Console.WriteLine($"Taxes: {tax:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:F2}$");
            }
        }
    }
}