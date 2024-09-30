public class Program
{
    public static void Main()
    {
        //Objects and Classes - Exercise - 01. Advertisement Message

        int n = int.Parse(Console.ReadLine());

        List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
        List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        List<string> autors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        for (int i = 0; i < n; i++)
        {
            Random random = new Random();
            int phrase = random.Next(0, phrases.Count);
            int even = random.Next(0, events.Count);
            int author = random.Next(0, autors.Count);
            int city = random.Next(0, cities.Count);

            Console.WriteLine($"{phrases[phrase]} {events[even]} {autors[author]} – {cities[city]}.");
        }
    }
}
