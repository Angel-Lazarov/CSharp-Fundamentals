using System.Text;

string text = Console.ReadLine();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < text.Length; i++)
{
    sb.Append((char)(text[i] + 3));
}
Console.WriteLine(sb);

//----------------------

//string text = Console.ReadLine();

//for (int i = 0; i < text.Length; i++)
//{
//    Console.Write((char)(text[i] + 3));
//}

//------------------------------

//string text = Console.ReadLine();
//string result = string.Empty;
//for (int i = 0; i < text.Length; i++)
//{
//    result += (char)(text[i] + 3);
//}
//Console.WriteLine(result);

//---------------------------------