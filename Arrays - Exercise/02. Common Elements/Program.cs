string[] firstArray = Console.ReadLine().Split().ToArray();
string[] secondArray = Console.ReadLine().Split().ToArray();

//for (int i = 0; i < secondArray.Length; i++) 
//{
//   for (int j = 0; j < firstArray.Length; j++)

//        if (secondArray[i] == firstArray[j])
//    {
//        Console.Write(secondArray[i] +" ");
//    }
//}
for (int i = 0; i < secondArray.Length; i++)
{
    if (firstArray.Contains(secondArray[i])) 
    {
        Console.Write(secondArray[i] + " ");
    }
}