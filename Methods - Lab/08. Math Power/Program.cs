namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double result = GetPower(firstNumber, secondNumber);
            Console.WriteLine(result);
        }

        static double GetPower(double digit, int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= digit;
            }
            return result;
        }
    }
}