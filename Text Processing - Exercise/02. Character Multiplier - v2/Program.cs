string[] input = Console.ReadLine().Split();


int sum = Sum(input[0], input[1]);
Console.WriteLine(sum);

static int Sum(string first, string second)
{
    int sum = 0;

    for (int i = 0; i < Math.Max(first.Length, second.Length); i++)
    {
        if (i < first.Length && i < second.Length)
        {
            sum += first[i] * second[i];
        }
        else if (i < first.Length)
        {
            sum += first[i];
        }
        else if (i < second.Length) 
        {
            sum += second[i];
        }
    }

    return sum;
}