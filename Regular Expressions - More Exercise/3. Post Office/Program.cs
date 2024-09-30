using System.Text.RegularExpressions;

string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

List<Word> output = new List<Word>();

//"AOTP"  ------------Capitals------------
string capitalLettersInput = input[0];
string capitalPatern = @"(?:([\#\$\%\*\&])(?<capitalLetters>[A-Z]+)\1)";


foreach (Match match in Regex.Matches(capitalLettersInput, capitalPatern))
{
    string capitalLetters = match.Groups["capitalLetters"].Value;

    foreach (char ch in capitalLetters)
    {
        Word word = new Word(ch);
        output.Add(word);
    }
}

//----------------Length--------------------------
string legthsInput = input[1];
string lengthPattern = @"(?<asciInt>\d{2}):(?<length>\d{2})";

foreach (Match match in Regex.Matches(legthsInput, lengthPattern))
{
    int asciInt = int.Parse(match.Groups["asciInt"].Value);
    int length = int.Parse(match.Groups["length"].Value);

    foreach (Word word in output)
    {
        if (word.CapitalLetter == asciInt) 
        {
            word.WordLength = length+1;
        }
    }
}


//-----------------------words----------------------
string wordsInput = input[2];
string wordsPattern = @"(?<words>\b[A-Z][!-~]+\b)";

foreach (Match match in Regex.Matches(wordsInput, wordsPattern))
{
    string wordsOutput = match.Groups["words"].Value;

    foreach (Word word in output)
    {
        if (word.CapitalLetter == wordsOutput[0] && word.WordLength == wordsOutput.Length)
        {
            word.WordBody = wordsOutput;
        }
    }
}

output.ForEach(x=>Console.WriteLine(x.WordBody));

//-----------------------------------------------
class Word
{
    public Word(char capitalLetter)
    {
        CapitalLetter = capitalLetter;
    }
    public char CapitalLetter { get; set; }
    public int WordLength { get; set; }

    public string WordBody { get; set; }
}

/*
Urgent"Message.TO$#POAML#|readData79:05:79:0!2reme80:03--23:11{79:05}tak{65:11ar}!77:!23--)77:05ACCSS76:05ad|Remedy Por Ostream :Istream Post sOffices Office Of Ankh-Morpork MR.LIPWIG Mister Lipwig
*/