List<string> strings  = Console.ReadLine().Split('|').ToList();

List<string> result = new List<string>();

string nov = string.Empty;

for (int i = strings.Count - 1; i >= 0; i--)
{
    result.Add(strings[i]);
    nov += strings[i] +" ";
}
result = nov.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

Console.WriteLine(string.Join(" ", result));