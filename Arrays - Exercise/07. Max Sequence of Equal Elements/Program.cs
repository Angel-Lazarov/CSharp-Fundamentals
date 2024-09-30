int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int topBroi = 0;
int topElement = 0;
int broi = 1;
int element = 0;                                                   // 2 1 1 2 3 3 2 2 2 1 
                                                                   // 0 1 2 3 4 5 6 7 8 9 index
for (int i = 0; i < array.Length; i++)                             // 1 1 1 2 3 1 3 3
{
        if (i < array.Length -1 && array[i] == array[i + 1])
        {
            broi++;
            if (topBroi < broi)
            {
                topBroi = broi;
                topElement = array[i];
            }
        }
        else
        {
            broi = 1;
            element = 0;
        }
}
for (int i = 0; i < topBroi; i++) 
{ Console.Write(topElement +" "); }