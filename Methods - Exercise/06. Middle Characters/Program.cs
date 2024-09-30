namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string midlleChar = string.Empty;

            midlleChar = FindMiddle(input);

            Console.WriteLine(midlleChar);
        }

        static string FindMiddle(string input)
        {
            string midlleChar;
            if (input.Length % 2 == 0)
            {
                midlleChar = input[input.Length / 2 - 1].ToString() + input[input.Length / 2];
            }
            else
            {
                midlleChar = input[input.Length / 2].ToString();
            }
            return midlleChar;
        }
    }
}