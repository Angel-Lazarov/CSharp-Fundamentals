namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            PrintSmallestNumber(a, b ,c);
        }
        static void PrintSmallestNumber(int a, int b, int c)
        {
            int smallest = 0;
            if (a <= b) 
            { 
                if (a <= c) 
                { 
                    smallest = a;
                } 
                else
                { 
                    smallest = c; 
                }
            }
            else if (b <= a)
            { 
                if (b <= c)
                { 
                    smallest = b;
                }
                else
                {
                    smallest = c;
                }
            }
            else if (c <= a) 
            {
                if (c <= b)
                { 
                    smallest = c;
                }
                else 
                { 
                    smallest = b;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}