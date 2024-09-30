namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine()); 
            char b = char.Parse(Console.ReadLine());
                
            if (b < a) 
            {
                char temp = a;
                a = b; 
                b=temp; 
            }

            Print(a, b);
        }

        static void Print(char start, char end) 
        {
        for (int i = start+1; i < end; i++) 
            {
                Console.Write((char)i+" ");
            }
        }
    }
}