using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Objects and Classes - Lab - 01. Randomize Words

        string[] words = Console.ReadLine().Split().ToArray();
        Random rnd = new Random();
        for (int i = 0; i < words.Length; i++)
        {
            int randomIndex = rnd.Next(0, words.Length);

            string currentWord = words[i];
            string randomWord = words[randomIndex];

            words[i] = randomWord;
            words[randomIndex] = currentWord;
        }
        Console.WriteLine(string.Join(Environment.NewLine, words));
    }
}