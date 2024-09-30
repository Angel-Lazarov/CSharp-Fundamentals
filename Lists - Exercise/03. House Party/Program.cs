int n = int.Parse(Console.ReadLine());
List<string> list = new List<string>();

for (int i = 0; i < n; i++) 
{
    string[] input = Console.ReadLine().Split();
    //George is not going!
    if (input.Contains("not"))
    {
        if (!list.Contains(input[0]))
        {
            Console.WriteLine($"{input[0]} is not in the list!");
        }
        else 
        {
            list.Remove(input[0]);
        }
    }
    else 
    {
        if (!list.Contains(input[0]))
        {
            list.Add(input[0]);
        }
        else 
        {
            Console.WriteLine($"{input[0]} is already in the list!");
        }
    }
}
for (int i = 0; i < list.Count; i++) 
{
    Console.WriteLine(list[i]);
}