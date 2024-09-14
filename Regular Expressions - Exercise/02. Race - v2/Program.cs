using System.Text.RegularExpressions;

string[] names = Console.ReadLine().Split(", ");

string patternSimbols = @"[^@%!#$/\^=&?]";
string patternDigits = @"[^0-9]";
string patternLetters = @"[^A-Za-z]";


string input = string.Empty;
while ((input=Console.ReadLine())!="end of race") 
{
    string racer = string.Empty;
    int distance = 0;

    Regex regex = new Regex(patternSimbols);
    MatchCollection matches = regex.Matches(input);

    foreach (Match match in matches)
    {
            

    }

}