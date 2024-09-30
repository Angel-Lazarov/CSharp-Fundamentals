//Data Types and Variables - More Exercise - 05. Decrypting Message
int key = int.Parse(Console.ReadLine());
int lines = int.Parse(Console.ReadLine());
string decrypted = string.Empty;

for (int i = 0; i < lines; i++)
{
    char encrypted = char.Parse(Console.ReadLine());
    decrypted += (char)(encrypted + key);
}
Console.WriteLine(decrypted);