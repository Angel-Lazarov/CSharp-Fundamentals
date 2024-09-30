int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

//for (int i = 0; i < numbers.Length; i++) 
//{
//      numbers[i] = int.Parse(Console.ReadLine());
//}
//int[] reversed = numbers.Reverse().ToArray();
//Console.WriteLine(string.Join(" ", reversed));

for (int i = numbers.Length-1; i >=0; i--)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(string.Join(" ", numbers));