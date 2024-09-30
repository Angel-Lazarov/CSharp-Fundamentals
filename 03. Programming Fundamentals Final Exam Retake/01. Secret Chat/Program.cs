
string encryptedMessage = Console.ReadLine();

string input = string.Empty;

while ((input=Console.ReadLine()) != "Reveal")
{
    string[] command = input.Split(":|:");

    if (command[0] == "InsertSpace")
    {
        int spaceIndex = int.Parse(command[1]);
        encryptedMessage = encryptedMessage.Insert(spaceIndex, " ");
    }
    else if (command[0] == "Reverse")
    {
        string subString = command[1];
        if (encryptedMessage.Contains(subString))
        {
            int startIndex = encryptedMessage.IndexOf(subString);
            encryptedMessage = encryptedMessage.Remove(startIndex, subString.Length);
            string reversedCut = new string(subString.Reverse().ToArray());
            encryptedMessage += reversedCut;
        }
        else 
        { 
            Console.WriteLine("error");
            continue;
        }
    }
    else if (command[0] == "ChangeAll") 
    {
        string substring = command[1];
        string replacement = command[2];

        encryptedMessage = encryptedMessage.Replace(substring, replacement);
    }
    Console.WriteLine(encryptedMessage);
}

Console.WriteLine($"You have a new text message: {encryptedMessage}");