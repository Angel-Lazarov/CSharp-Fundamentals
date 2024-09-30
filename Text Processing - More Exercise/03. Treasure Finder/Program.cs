using System.Text;

int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
string message = string.Empty;
int keyStart = 0;


while ((message = Console.ReadLine()) != "find")
{
    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < message.Length; i++)
    {
        if (key.Length <= message.Length)
        {
            keyStart = i;
        }

        if (i >= key.Length)
        {
            keyStart = Math.Abs(i % key.Length);
            //if (i >= key.Length) 
            //{
            //    keyStart = Math.Abs(key.Length - i);
            //}
        }

        char decryptedChar = (char)(message[i] - key[keyStart]);

        sb.Append(decryptedChar);
    }
    Console.WriteLine(ExtractMessage(sb.ToString())); ;
}
//type will be between the symbol '&' and the coordinates will be between the symbols '<' and '>

static string ExtractMessage(string text)
{

    int typeStartIndex = text.IndexOf('&') + 1;
    int typeEndIndex = text.LastIndexOf('&');
    string type = text.Substring(typeStartIndex, typeEndIndex - typeStartIndex);

    int coordinatsStartIndex = text.IndexOf('<') + 1;
    int coordinatsEndIndex = text.IndexOf('>');
    string coordinats = text.Substring(coordinatsStartIndex, coordinatsEndIndex - coordinatsStartIndex);




    return $"Found {type} at {coordinats}";
}