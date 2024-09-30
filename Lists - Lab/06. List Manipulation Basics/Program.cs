List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string command = String.Empty;

while ((command = Console.ReadLine()) != "end")
{
   // string[] commandInfo = command.Split();
    List<string> commandInfo = command.Split().ToList();

    //switch (commandInfo[0])
    //{
    //    case "Add":
    //        int addNumber = int.Parse(commandInfo[1]);
    //        numbers.Add(addNumber);
    //        break;
    //    case "Remove":
    //        int removeNumber = int.Parse(commandInfo[1]);
    //        numbers.Remove(removeNumber);
    //        break;
    //    case "RemoveAt":
    //        int removeIndex = int.Parse(commandInfo[1]);
    //        numbers.RemoveAt(removeIndex);
    //        break;
    //    case "Insert":
    //        int InsertNumber = int.Parse(commandInfo[1]);
    //        int InsertIndex = int.Parse(commandInfo[2]);
    //        numbers.Insert(InsertIndex, InsertNumber);
    //        break;
    //}

    if (commandInfo[0] == "Add") 
    { 
        int number = int.Parse(commandInfo[1]);
        numbers.Add(number);
    }
    else if (commandInfo[0] == "Remove")
    {
        int number = int.Parse(commandInfo[1]);
        numbers.Remove(number);
    }
    else if (commandInfo[0] == "RemoveAt")
    {
        int index = int.Parse(commandInfo[1]);
        numbers.RemoveAt(index);
    }
    else if (commandInfo[0] == "Insert")
    {
        int number = int.Parse(commandInfo[1]);
        int index = int.Parse(commandInfo[2]);
        numbers.Insert(index, number);
    }
}
Console.WriteLine(string.Join(" ", numbers));