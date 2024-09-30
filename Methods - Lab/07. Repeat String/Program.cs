namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            GetRepeatedString(text, n);
            Console.WriteLine(GetRepeatedString(text, n));
        }
        static string GetRepeatedString(string text, int reoetitions) 
        {
            string result = string.Empty;
        
            for (int i = 0; i < reoetitions; i++) 
            {
                result += text;
            }
            return result;
        }
    }
}