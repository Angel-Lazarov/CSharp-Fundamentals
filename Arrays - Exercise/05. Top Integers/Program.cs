int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int top = array[array.Length - 1];

int[] tops = new int[1];

tops[tops.Length - 1] = array[array.Length-1];

for (int i = array.Length-2; i >=0 ; i--)
{
   
    if (array[i] > top) 
    {
        top = array[i];
        // tops = tops.Append(array[i]).ToArray();
        tops = tops.Prepend(array[i]).ToArray();    
    }
}
//tops = tops.Reverse().ToArray();
Console.WriteLine(string.Join(" ", tops));