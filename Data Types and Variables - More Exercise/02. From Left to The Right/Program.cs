int lines = int.Parse(Console.ReadLine());

for (int i = 0;  i < lines; i++)
{
    string leftNum = string.Empty;
    string rightNum = string.Empty;
    long leftNumber = 0;
    string input = Console.ReadLine();

    for (int j = 0; j < input.Length; j++)
    {
        if (input[j] != 32)
        {
            leftNum += input[j];
        }
        else 
        {
            leftNumber = long.Parse(leftNum);
            break;
        }
    }
    for (int j = input.Length-1; j >=0; j--) 
    {
        if (input[j] != 32)
        {
            rightNum += input[j];
        }
        else { break; }
    }
    rightNum = new string(rightNum.Reverse().ToArray());
    long rightNumber = long.Parse(rightNum);

    if ( leftNumber > rightNumber)
    {
        long sum = 0;
        for (int j = 0; j < leftNum.Length; j++) 
        {
            if (leftNum[j] == '-')
            {
                continue;
            }
            else
            {
                sum += long.Parse(leftNum[j].ToString());
            }
        }
        Console.WriteLine(sum);
    }
    else
    {
        long sum = 0;
        for (int j = 0; j < rightNum.Length; j++)
        {
            if (rightNum[j] == '-')
            {
                continue;
            }
            else
            { 
                sum += long.Parse((rightNumber.ToString())[j].ToString());
            }
        }
        Console.WriteLine(sum);
    }
}