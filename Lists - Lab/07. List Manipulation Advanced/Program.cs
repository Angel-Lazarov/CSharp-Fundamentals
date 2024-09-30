public class Program
{
    public static void Main()
    {
        //Lists - Lab - 07. List Manipulation Advanced

        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string command = String.Empty;
        bool isChanged = false;

        while ((command = Console.ReadLine()) != "end")
        {
            List<int> temp = new List<int>();
            string[] commandInfo = command.Split();
            switch (commandInfo[0])

            {
                case "Add":
                    int addNumber = int.Parse(commandInfo[1]);
                    numbers.Add(addNumber);
                    isChanged = true;
                    break;

                case "Remove":
                    int removeNumber = int.Parse(commandInfo[1]);
                    numbers.Remove(removeNumber);
                    isChanged = true;
                    break;

                case "RemoveAt":
                    int removeIndex = int.Parse(commandInfo[1]);
                    numbers.RemoveAt(removeIndex);
                    isChanged = true;
                    break;

                case "Insert":
                    int InsertNumber = int.Parse(commandInfo[1]);
                    int InsertIndex = int.Parse(commandInfo[2]);
                    numbers.Insert(InsertIndex, InsertNumber);
                    isChanged = true;
                    break;

                case "Contains":
                    int number = int.Parse(commandInfo[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;

                case "PrintEven":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            temp.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", temp));
                    break;

                case "PrintOdd":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            temp.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", temp));
                    break;

                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;

                case "Filter":
                    string condition = commandInfo[1];
                    int filterNumber = int.Parse(commandInfo[2]);

                    if (condition == "<")
                    {
                        temp = numbers.Where(x => x < filterNumber).ToList();
                    }
                    else if (condition == ">")
                    {
                        temp = numbers.Where(x => x > filterNumber).ToList();
                    }
                    else if (condition == ">=")
                    {
                        temp = numbers.Where(x => x >= filterNumber).ToList();
                    }
                    else if (condition == "<=")
                    {
                        temp = numbers.Where(x => x <= filterNumber).ToList();
                    }
                    Console.WriteLine(string.Join(" ", temp));

                    break;
            }
        }
        if (isChanged)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}