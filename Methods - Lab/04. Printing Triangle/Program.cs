namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            UpperPart(n);
            LowerPart(n);
                   
        }
        static void UpperPart(int n) 
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static void LowerPart(int n) 
        {
            for (int k = n - 1; k >= 1; k--)
            {
                for (int l = 1; l <= k; l++)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }
        }
    }
}