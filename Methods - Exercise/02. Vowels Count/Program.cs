namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main()
        {
           string input =  Console.ReadLine();

            PrintVolvesNumber(input);
        }

        static void PrintVolvesNumber(string text)
        {
            int vowels = 0;

            for (int i = 0; i < text.Length; i++) 
            {
               switch (text[i]) 
                {
                    case 'a':
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                    case 'y':
                    case 'Y':
                        vowels++;
                        break;
                }
            }
            Console.WriteLine(vowels);
        }
    }
}