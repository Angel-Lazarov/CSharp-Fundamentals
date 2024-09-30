string text = Console.ReadLine();
string reversedText = string.Empty;
////string reversedText = new string(text.Reverse().ToArray());
for (int i = text.Length - 1; i >= 0; i--) 
{ reversedText += text[i]; }

Console.WriteLine(reversedText);
