
string spell = Console.ReadLine();



string input = string.Empty;

while ((input = Console.ReadLine()) != "Abracadabra")
{
    string[] commandInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = commandInfo[0];
    string temp = string.Empty;

    switch (command)
    {
        case "Abjuration":
            temp = spell.ToUpper();
            spell = temp;
            Console.WriteLine(spell);
            break;
        case "Necromancy":
            temp = spell.ToLower();
            spell = temp;
            Console.WriteLine(spell);
            break;
        case "Illusion":
            int index = int.Parse(commandInfo[1]);
            string newLetter = commandInfo[2];
            int length = spell.Length;

            if (index >= 0 && index < length)
            {
                string oldLetter = spell[index].ToString();
                temp = spell.Replace(oldLetter, newLetter);
                spell = temp;
                Console.WriteLine("Done!");
            }
            else { Console.WriteLine("The spell was too weak."); }

            break;
        case "Divination": //ok
            string oldString = commandInfo[1];
            string newString = commandInfo[2];
            
            //if (spell.IndexOf(oldString) !=-1)
            if (spell.Contains(oldString))
            {
                temp = spell.Replace(oldString, newString);
                spell = temp;
                Console.WriteLine(spell);
            }
            break;
        case "Alteration":
            string substring = commandInfo[1];
            int startIndex = spell.IndexOf(substring);
            int substringLength = substring.Length;
            ;
            if (startIndex != -1)
            {
                temp = spell.Remove(startIndex, substringLength);
                spell = temp;
                Console.WriteLine(spell);
            }
            break;
        default:
            Console.WriteLine("The spell did not work!");
            break;
    }
}
int r = int.Parse(true);

/*
A7ci0;miotaecuioqwtreciowerlidsjvwer;kjgfkdwer
Divination wer ***

SwordMaster123345
Target Target Target
Abjuration
Necromancy
Alteration master
Abracadabra



 */