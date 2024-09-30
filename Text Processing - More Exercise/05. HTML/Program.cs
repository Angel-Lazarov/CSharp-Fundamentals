using System.Text;

StringBuilder result = new StringBuilder();

string title = Console.ReadLine();

result.AppendLine("<h1>");
result.AppendLine("\t" + title);
result.AppendLine("</h1>");

string content = Console.ReadLine();

result.AppendLine("<article>");
result.AppendLine("\t" + content);
result.AppendLine("</article>");

string comment = string.Empty;

while ((comment = Console.ReadLine()) != "end of comments")
{
    result.AppendLine("<div>");
    result.AppendLine("\t" + comment);
    result.AppendLine("</div>");
}

Console.WriteLine(result);

