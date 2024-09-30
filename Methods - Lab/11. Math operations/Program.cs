namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            char operant = char.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Action(num1, operant, num2));

        }
        static double Action(double a, char op, double b)
        {
            double result = 0;
            if (op == '/')
            {
                result = a / b;
            }
            else if (op == '*')
            {
                result = a * b;
            }
            else if (op == '+')
            {
                result = a + b;
            }
            else //op == '-'
            {
                result = a - b;
            }
            return result;
        }

    }
}