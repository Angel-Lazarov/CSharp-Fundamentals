namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = Add(a, b);
            int result = Substract(c, sum);
            Console.WriteLine(result);
        }

        static int Substract(int c, int sum)
        {
            return sum - c;
        }

        static int Add(int a, int b)
        {
            return  a + b;
        }
    }
}