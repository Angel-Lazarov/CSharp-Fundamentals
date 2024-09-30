
public class Program
{
    public static void Main()
    {
        //Objects and Classes - Exercise - 02. Articles 2.0

        int n = int.Parse(Console.ReadLine());
        List<Article>  articles= new List<Article>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(", ");
            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);
            articles.Add(article);
        }

        //foreach (Article article in articles)
        //{ 
        //Console.WriteLine(article.ToString()); 
        //}

        //Console.WriteLine(string.Join(Environment.NewLine, articles));

        Console.WriteLine(string.Join("\n", articles));

    }
}
class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}