int lines = int.Parse(Console.ReadLine());
int[] first = new int[lines];
int[] second = new int[lines];

first[0] = 1; //Startup row is always equal to "1"
Console.WriteLine(first[0]);

for (int r = 1; r < first.Length; r++)
{
    second[0] = 1; //Every 1st value in the row is always equal to "1"
    Console.Write($"{second[0]} ");

    for (int c = 1; c <= r; c++)
    {
        second[c] = first[c - 1] + first[c];
        Console.Write($"{second[c]} ");
    }

    for (int j = 0; j < lines; j++)
    {
        first[j] = second[j];
    }
    Console.WriteLine();
}
//--------------------------------------------------------
//int lines = int.Parse(Console.ReadLine());
//int[] row = new int[lines];
//int[] current = new int[lines];
//row[0] = 1; //Startup row is always equal to "1"
//Console.WriteLine(row[0]);
//for (int r = 1; r < lines; r++)
//{
//    for (int c = 0; c <= r; c++)
//    {
//        if (c == 0)
//        {
//            current[c] = 1;
//        }
//        else
//        {
//            current[c] = row[c - 1] + row[c];
//        }
//        Console.Write($"{current[c]} ");
//    }
//    for (int j = 0; j < lines; j++)
//    {
//        row[j] = current[j];
//    }
//    Console.WriteLine();
//}