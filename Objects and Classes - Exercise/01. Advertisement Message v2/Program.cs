public class Program
{
    public static void Main()
    {
        //Objects and Classes - Exercise - 01. Advertisement Message

        int n = int.Parse(Console.ReadLine());

        Advertis addv = new Advertis();

        
        addv.Phrases = new [] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
        addv.Even = new[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        addv.Author = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        addv.City = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
         
            int index = random.Next(addv.Phrases.Length);
            string phrase = addv.Phrases[index];

            index = random.Next(addv.Even.Length);
            string even = addv.Even[index];

            index = random.Next(addv.Author.Length);
            string author = addv.Author[index];

            index = random.Next(addv.City.Length);
            string city = addv.City[index];

            Console.WriteLine($"{phrase} {even} {author} – {city}.");
        }
    }
}
class Advertis
{
    public string[] Phrases {get; set;}
    public string[] Even { get; set; }
    public string[] Author { get; set; }
    public string[] City { get; set; }

}