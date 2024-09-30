string targets = Console.ReadLine();

string input = string.Empty;

while ((input = Console.ReadLine()) != "Travel")
{
    string[] commandInfo = input.Split(":");
    string command = commandInfo[0];

    if (command == "Add Stop")
    {
        int index = int.Parse(commandInfo[1]);
        string city = commandInfo[2];

        if (index >= 0 && index < targets.Length)
        {
            targets = targets.Insert(index, city);
            Console.WriteLine(targets);
        }
        else
        {
            Console.WriteLine(targets);
        }
    }
    else if (command == "Remove Stop")
    {
        int startIndex = int.Parse(commandInfo[1]);
        int endIndex = int.Parse(commandInfo[2]);

        if ((startIndex >= 0 && startIndex < targets.Length) && (endIndex >= 0 && endIndex < targets.Length))
        {
            targets = targets.Remove(startIndex, endIndex - startIndex + 1);
            Console.WriteLine(targets);
        }
        else
        {
            Console.WriteLine(targets);
        }
    }
    else if (command == "Switch")
    {
        string oldString = commandInfo[1];
        string newString = commandInfo[2];

        if (targets.Contains(oldString))
        {
            targets = targets.Replace(oldString, newString);
            Console.WriteLine(targets);
        }
        else
        {
            Console.WriteLine(targets);
        }
    }
}
Console.WriteLine($"Ready for world tour! Planned stops: {targets}");