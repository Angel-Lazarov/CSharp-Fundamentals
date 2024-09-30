namespace _03._Calculations
{
    internal class Program
    {
        static void Main()
        {
            string operant = Console.ReadLine();
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            switch (operant)
            {
                case "add":
                    Add(number1, number2);
                    break;
                case "multiply":
                    Multiply(number1, number2);
                    break;
                case "subtract":
                    Subtract(number1, number2);
                    break;
                case "divide":
                    Divide(number1, number2);
                    break;
            }
        }
        static void Add(double a, double b)
        {
            Console.WriteLine(a+b);
        }
        static void Multiply(double a, double b)
        {
            Console.WriteLine(a * b);
        }
        static void Subtract(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        static void Divide(double a, double b)
        {
            Console.WriteLine(a / b);
        }
    }
}
