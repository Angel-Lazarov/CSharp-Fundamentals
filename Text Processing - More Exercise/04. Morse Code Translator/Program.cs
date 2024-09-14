/*
Letter	Morse
A	.-
B	-...
C	-.-.
D	-..
E	.
F	..-.
G	--.
H	....
I	..
J	.---
K	-.-
L	.-..
M	--
N	-.
O	---
P	.--.
Q	--.-
R	.-.
S	...
T	-
U	..-
V	...-
W	.--
X	-..-
Y	-.--
Z	--..
 
 */

using System.Text;

string[] morseText = Console.ReadLine().Split(" | "); //разделяме текста на думи
StringBuilder translatedText = new StringBuilder();


foreach (string morseWord in morseText) // взимаме всяка дума от текста една по една
{
    string[] morseWordLetters = morseWord.Split();//

    StringBuilder currentWord = new StringBuilder();

    foreach (string morseLetter in morseWordLetters)
    {
        switch (morseLetter)
        {
            case ".-":
                currentWord.Append('A');
                break;
            case "-...":
                currentWord.Append('B');
                break;
            case "-.-.":
                currentWord.Append('C');
                break;
            case "-..":
                currentWord.Append('D');
                break;
            case ".":
                currentWord.Append('E');
                break;
            case "..-.":
                currentWord.Append('F');
                break;
            case "--.":
                currentWord.Append('G');
                break;
            case "....":
                currentWord.Append('H');
                break;
            case "..":
                currentWord.Append('I');
                break;
            case ".---":
                currentWord.Append('J');
                break;
            case "-.-":
                currentWord.Append('K');
                break;
            case ".-..":
                currentWord.Append('L');
                break;
            case "--":
                currentWord.Append('M');
                break;
            case "-.":
                currentWord.Append('N');
                break;
            case "---":
                currentWord.Append('O');
                break;
            case ".--.":
                currentWord.Append('P');
                break;
            case "--.-":
                currentWord.Append('Q');
                break;
            case ".-.":
                currentWord.Append('R');
                break;
            case "...":
                currentWord.Append('S');
                break;
            case "-":
                currentWord.Append('T');
                break;
            case "..-":
                currentWord.Append('U');
                break;
            case "...-":
                currentWord.Append('V');
                break;
            case ".--":
                currentWord.Append('W');
                break;
            case "-..-":
                currentWord.Append('X');
                break;
            case "-.--":
                currentWord.Append('Y');
                break;
            case "--..":
                currentWord.Append('Z');
                break;
        }
    }
    translatedText.Append(currentWord.ToString());
    translatedText.Append(' ');
}
Console.WriteLine(translatedText);