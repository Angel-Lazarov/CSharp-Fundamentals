namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double x1); //A1
            double.TryParse(Console.ReadLine(), out double y1); //A2
                                                                //  ===>> AB
            double.TryParse(Console.ReadLine(), out double x2); //B1
            double.TryParse(Console.ReadLine(), out double y2); //B2

            double.TryParse(Console.ReadLine(), out double x3); //C1
            double.TryParse(Console.ReadLine(), out double y3); //C2
                                                                //  ===>>CD
            double.TryParse(Console.ReadLine(), out double x4); //D1
            double.TryParse(Console.ReadLine(), out double y4); //D2

            double ab = CalculateLineLength(x1, y1, x2, y2);
            double cd = CalculateLineLength(x3, y3, x4, y4);


            if (ab > cd)
            {
                Print(x1, y1, x2, y2);
            }
            else
            {
                Print(x3, y3, x4, y4);
            }
        }

        private static double CalculateLineLength(double x1, double y1, double x2, double y2)
        {
            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);

           return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        private static void Print(double x1, double y1, double x2, double y2)
        {
            double c1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double c2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (c1 > c2)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else if (c1 <= c2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }
    }
}