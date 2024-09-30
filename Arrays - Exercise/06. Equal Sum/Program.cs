int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool notFound = true;
int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < array.Length; i++)       // 1) 2 3 (3 
{                                              //    | 
    leftSum = 0;
    rightSum = 0;

    for (int j = 0; j < i; j++)
    { 
        leftSum += array[j];
    }

    for (int k = i+1; k < array.Length; k++) 
    { 
        rightSum += array[k];
    }

    if (leftSum == rightSum)
    { 
        notFound = false;
        Console.WriteLine(i);
    }
}
if (notFound)
{ 
    Console.WriteLine("no");
}