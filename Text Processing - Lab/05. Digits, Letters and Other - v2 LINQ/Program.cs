
string text = Console.ReadLine();

//string digits = new string(text.Where(x => char.IsDigit(x)).ToArray());
//Console.WriteLine(digits);

//string letters = new string(text.Where(x => char.IsLetter(x)).ToArray());
//Console.WriteLine(letters);

//string elements = new string(text.Where(x => !char.IsDigit(x) && !char.IsLetter(x)).ToArray());
//Console.WriteLine(elements);
//---------------------------------LINQ start---------------------------------------------------
////Console.WriteLine(new string(text.Where(x => char.IsDigit(x)).ToArray()));
////Console.WriteLine(new string(text.Where(x => char.IsLetter(x)).ToArray()));
////Console.WriteLine(new string(text.Where(x => !char.IsDigit(x) && !char.IsLetter(x)).ToArray()));
//---------------------------------LINQ end---------------------------------------------------

string digits = string.Empty;
string letters = string.Empty;
string elements = string.Empty;

for (int i = 0; i < text.Length; i++)
{
    if (char.IsDigit(text[i]))
    {
        digits += text[i];
    }
    else if (char.IsLetter(text[i]))
    {
        letters += text[i];
    }
    else
    {
        elements += text[i];
    }
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(elements);