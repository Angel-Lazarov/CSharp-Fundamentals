using System.ComponentModel;

List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
string input = string.Empty;

while ((input=Console.ReadLine())!="End")
{
    string[] command = input.Split();

    if (command[0] == "Add")
    {
        int number = int.Parse(command[1]);
        ints.Add(number);
    }
    else if (command[0] == "Insert")
    {
        int number = int.Parse(command[1]);
        int index = int.Parse(command[2]);

        if (index >= 0 && index < ints.Count)
        {
            ints.Insert(index, number);
        }
        else 
        { 
            Console.WriteLine($"Invalid index"); 
        }
    }
    else if (command[0] == "Remove")
    {
        int index = int.Parse(command[1]);
        if (index >= 0 && index < ints.Count)
        {
            ints.RemoveAt(index); 
        }
        else
        {
            Console.WriteLine($"Invalid index");
        }
    }
    else if (command[0] == "Shift") 
    {
        string derection = command[1];
        int count = int.Parse(command[2]);
        
        if (derection == "left") 
        {   // { 1, 2, 3, 4}
            for (int i = 0; i < count; i++)
            {
                ints.Add(ints[0]);
                ints.RemoveAt(0);
            }
        }
        else if (derection == "right") 
        {
            for (int i = 0; i < count; i++)
            {
                ints.Insert(0, ints[ints.Count - 1]);
                ints.RemoveAt(ints.Count - 1);
            }
        }
    }
}
Console.WriteLine(string.Join(" ", ints));
