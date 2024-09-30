string[] banWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (string word in banWords) 
{
    string filterdeString = new string('*', word.Length);
    text = text.Replace(word, filterdeString);
}
Console.WriteLine(text);
