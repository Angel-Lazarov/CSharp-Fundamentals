namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int num1);
            int.TryParse(Console.ReadLine(), out int num2);
            int.TryParse(Console.ReadLine(), out int num3);

            int result = Multiply(num1, num2, num3);
            CheckResult(result);

        }
        static int Multiply(int a, int b, int c) 
        {
            return a * b * c;
        }
        static void CheckResult(int result)
        {
            if (result < 0) { Console.WriteLine("negative"); }
            else if (result > 0) { Console.WriteLine("positive"); }
            else { Console.WriteLine("zero"); }
        }
    }

}