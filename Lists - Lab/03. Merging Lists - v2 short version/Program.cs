List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> result = new List<int>(); 

int minLength = Math.Min(firstList.Count, secondList.Count);

for (int i = 0; i < minLength; i++) 
{
    result.Add(firstList[i]);
    result.Add(secondList[i]);
}

if (firstList.Count > secondList.Count)
{
    for (int i = minLength; i < firstList.Count; i++)
    {
        result.Add(firstList[i]);
    }
}
else if (firstList.Count < secondList.Count)
{
    for (int i = minLength; i < secondList.Count; i++)
    {
        result.Add(secondList[i]);
    }
}

Console.WriteLine(string.Join(" ", result));
