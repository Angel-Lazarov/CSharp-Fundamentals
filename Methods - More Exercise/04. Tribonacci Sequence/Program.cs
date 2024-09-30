using System.Numerics;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int num);

            BigInteger[] mass = new BigInteger[num];

            //int[] mass = new int[num]; // може и с int !!!


            if (num == 1) 
            {
                mass[0] = 1;
            }
            else if (num == 2)
            {
                mass[0] = 1;
                mass[1] = 1;

            }
            else if (num >= 3)
            {
                mass[0] = 1;
                mass[1] = 1;
                mass[2] = 2;

                for (int i = 3; i < num; i++)
                {
                    mass[i] = mass[i - 1] + mass[i - 2] + mass[i - 3];
                }
            }
            Console.WriteLine(string.Join(" ", mass));
        }
    }
}