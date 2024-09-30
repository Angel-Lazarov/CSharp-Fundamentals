namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Math.Abs(int.Parse(Console.ReadLine()));
            int b = Math.Abs(int.Parse(Console.ReadLine()));
            
            long factorialA = FindFactorial(a);
            long factorialB = FindFactorial(b);
            decimal result = (decimal)factorialA / factorialB;
            Console.WriteLine($"{result:F2}");
        }

        static long FindFactorial(int n)
        {
            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}