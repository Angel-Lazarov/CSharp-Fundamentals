List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
string input = string.Empty;

while ((input = Console.ReadLine())!= "end")
{
    string[] command = input.Split();

    if (command[0] == "Delete")
    {
        int elementNumber = int.Parse(command[1]);
        ints.RemoveAll(x => x == elementNumber);

    }
    else if (command[0] == "Insert") 
    {
        int elementNumber = int.Parse(command[1]);
        int elementPosition = int.Parse(command[2]);
        ints.Insert(elementPosition, elementNumber);
    }
}
Console.WriteLine(string.Join(" ", ints));