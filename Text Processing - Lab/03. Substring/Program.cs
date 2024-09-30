string banWord = Console.ReadLine();
string text = Console.ReadLine();

while (text.Contains(banWord))
{
    int index = text.IndexOf(banWord);
    int length = banWord.Length;

    text = text.Remove(index, length);
}

Console.WriteLine(text);