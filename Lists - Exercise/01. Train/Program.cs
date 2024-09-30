List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacityOfWagon = int.Parse(Console.ReadLine());
string command = string.Empty;

while ((command = Console.ReadLine()) != "end")
{
    string[] commandInfo = command.Split();
    if (commandInfo[0] == "Add")
    {
        wagons.Add(int.Parse(commandInfo[1]));
    }
    else if (commandInfo[0] != "Add") 
    {
        int incomers = int.Parse(commandInfo[0]);
        FindPlace(incomers);
    }
}

Console.WriteLine(string.Join(" ", wagons));
void FindPlace(int incomers)
{
    for (int i = 0; i < wagons.Count; i++) 
    {
        if (maxCapacityOfWagon - wagons[i] >= incomers)
        {
            wagons[i] += incomers;
            return;
        }
    }
}