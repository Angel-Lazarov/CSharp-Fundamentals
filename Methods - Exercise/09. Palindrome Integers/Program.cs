using static System.Net.Mime.MediaTypeNames;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
           
            while ((input= Console.ReadLine()) != "END")
            {
                string reversed = new string(input.Reverse().ToArray());
                bool result = CheckForPalindrome(input, reversed);
                Console.WriteLine(result);
            }
        }

        static bool CheckForPalindrome(string input, string reversed)
        {
            if (input == reversed)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
    }
}