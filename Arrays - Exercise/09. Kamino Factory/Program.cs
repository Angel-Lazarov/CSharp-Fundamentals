int dnaLength = int.Parse(Console.ReadLine());
int[] bestDna = new int[dnaLength];

int bestSequenceIndex = 0;
int bestSequenceSum = 0;
int currentProbeNumber = 0;
int bestProbeNumber = 0;
string command = string.Empty;
int bestSum = 0;


while ((command = Console.ReadLine()) != "Clone them!")
{
    int[] input = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    
    currentProbeNumber++;
    int currentSequenceSum = 0;

    for (int i = 0; i < dnaLength; i++) 
    {
       
        if (input[i] == 0 && currentSequenceSum > 0)
        {
            break;
        }
        else if (input[i] == 1)
        {
            currentSequenceSum++;
        }
    }
    int currentSequenceIndex = Array.IndexOf(input, 1);
    int currentSum = input.Sum();
    if (currentSequenceSum > bestSequenceSum
        || currentSequenceSum == bestSequenceSum && currentSequenceIndex < bestSequenceIndex
        || currentSequenceSum == bestSequenceSum && currentSequenceIndex == bestSequenceIndex && currentSum > bestSum)
    {
        bestSequenceSum = currentSequenceSum;
        bestSequenceIndex = currentSequenceIndex;
        bestDna = input;
        bestProbeNumber = currentProbeNumber;
        bestSum = currentSum;
    }
}
Console.WriteLine($"Best DNA sample {bestProbeNumber} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", bestDna));