string key = Console.ReadLine();

string input = string.Empty;

while ((input = Console.ReadLine()) != "Generate")
{
    string[] commandsInfo = input.Split(">>>");
    string command = commandsInfo[0];

    switch (command)
    {
        case "Contains":
            string substring = commandsInfo[1];
            if (key.Contains(substring))
            {
                Console.WriteLine($"{key} contains {substring}.");
                Console.WriteLine($"{key} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
            break;
        case "Flip":
            string type = commandsInfo[1];
            int startIndex = int.Parse(commandsInfo[2]);
            int endIndex = int.Parse(commandsInfo[3]);
            string oldString = key.Substring(startIndex, endIndex - startIndex);


            if (type == "Upper")
            {
                string newString = oldString.ToUpper();
                key = key.Replace(oldString, newString);
                Console.WriteLine(key);
            }
            else if (type == "Lower")
            {
                string newString = oldString.ToLower();
                key = key.Replace(oldString, newString);
                Console.WriteLine(key);
            }
            break;
        case "Slice":
            int start = int.Parse(commandsInfo[1]);
            int end = int.Parse(commandsInfo[2]);
            key = key.Remove(start, end - start);
            Console.WriteLine(key);
            break;
    }
}

Console.WriteLine($"Your activation key is: {key}");
