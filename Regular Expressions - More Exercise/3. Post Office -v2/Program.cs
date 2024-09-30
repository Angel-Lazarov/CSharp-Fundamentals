using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

string capitalLettersInput = input[0];
string capitalPatern = @"(?:([\#\$\%\*\&])(?<capitalLetters>[A-Z]+)\1)";

Match letterMatch = Regex.Match(capitalLettersInput, capitalPatern);
string capitalLetters = letterMatch.Groups["capitalLetters"].Value;

foreach (char letter in capitalLetters)
{

    int asci = letter;

    string legthsInput = input[1];
    string asciPattern = $@"{asci}:(?<length>[0-9][0-9])";

    Match asciMatch = Regex.Match(legthsInput, asciPattern);
    string match = asciMatch.Groups["length"].Value;
    int length = int.Parse(match);

    string wordsInput = input[2];
    string wordsPattern = $@"(?<=\s|^){letter}[^\s]{{{length}}}(?=\s|$)";  //??????????????????????????????

    Match wordMatch = Regex.Match(wordsInput, wordsPattern);

    string wordOut = wordMatch.Value;

    Console.WriteLine(wordOut);
}