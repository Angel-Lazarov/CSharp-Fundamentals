using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine().ToUpper();

string pattern = @"(?<letters>[!-\/:-~ ]+)(?<digit>\d*)";

MatchCollection matches = Regex.Matches(input, pattern);
int uniq = 0;
StringBuilder sb = new StringBuilder();
             //"ASD2"
foreach (Match match in matches)
{
    string letters = match.Groups["letters"].Value;
    int.TryParse(match.Groups["digit"].Value, out int digit);

    //if (digit == 0) // ако digit-а е 0, не добавяме стринга !!!
    //{
    //    sb.Append(letters);
    //}
   // else
  //  {
        for (int i = 0; i < digit; i++)
        {
            sb.Append(letters);
        }
  //  }
}
string output = sb.ToString();

string un = string.Empty;

foreach (char ch in  output)
{
    if (!un.Contains(ch)) 
    {
        un += ch;
        uniq++;
    }
}

Console.WriteLine($"Unique symbols used: {uniq}");
Console.WriteLine(output);

