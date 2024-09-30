namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            //double area = GetRectangleArea(sideA, sideB);
            //Console.WriteLine(area);
            Console.WriteLine(GetRectangleArea(sideA, sideB));
        }

        static double GetRectangleArea(double a, double b) 
        {
            return a * b;
        }
    }
}