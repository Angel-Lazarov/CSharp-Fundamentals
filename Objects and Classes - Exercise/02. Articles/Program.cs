public class Program
{
    public static void Main()
    {
        //Objects and Classes - Exercise - 02. Articles

        string[] input = Console.ReadLine().Split(", ");
        string title = input[0];
        string content = input[1];
        string author = input[2];

        Article article = new Article(title, content, author);
        

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] comandInfo = Console.ReadLine().Split(": ");
            string comand = comandInfo[0];
            string newPropertie = comandInfo[1];
            if (comand == "Edit")
            {
                article.Edit(newPropertie);
            }
            else if (comand == "ChangeAuthor")
            {
                article.ChangeAuthor(newPropertie);
            }
            else if (comand == "Rename")
            {
                article.Rename(newPropertie);
            }
        }
        // Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        Console.WriteLine(article);
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

    public void Edit(string content)
    {
        Content = content;
    }
    public void ChangeAuthor(string author)
    {
        Author = author;
    }
    public void Rename(string title)
    {
        Title = title;
    }
    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}