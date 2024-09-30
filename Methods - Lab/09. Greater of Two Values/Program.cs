namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                if (GetMax(a, b) > 0) 
                {
                    Console.WriteLine(a); 
                }
                else 
                {
                    Console.WriteLine(b); 
                }
            }
        }
        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
        static char GetMax(char a, char b)
        {
            return a > b ? a : b;
        }
        static int GetMax(string a, string b) 
        {
        int result = a.CompareTo(b);
            return result;
        }
    }
}