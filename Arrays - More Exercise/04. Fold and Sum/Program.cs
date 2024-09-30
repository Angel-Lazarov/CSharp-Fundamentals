//Arrays - More Exercise - 04. Fold and Sum - 1

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray(); //12

int[] sum = new int[0];

int[] firstLine = new int[0];
int[] secondLine = new int[input.Length * 3 / 4 - input.Length / 4];


//-------ляво--------
for (int i = 0; i < input.Length / 4; i++)
{
    firstLine = firstLine.Prepend(input[i]).ToArray();
}

            //     12 * 3 / 4=9      12
//------------------дясно---------------------------
for (int i = input.Length-1; i >= input.Length *3 /4; i--)
{
    firstLine = firstLine.Append(input[i]).ToArray();
}

//------------secondline-------------
for (int i = input.Length / 4; i < input.Length * 3 / 4; i++)
{
    secondLine[i - input.Length / 4] = input[i];
}

//------------------------------------------
for (int i = 0; i < secondLine.Length; i++)
{
    sum = sum.Append(firstLine[i] + secondLine[i]).ToArray();
}

Console.WriteLine(string.Join(" ", sum));

