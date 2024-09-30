int dnaLength = int.Parse(Console.ReadLine());
int[] bestDna = new int[dnaLength];

int longestSequenceIndex = 0;
int longestSequenceLength = 0;
int bestProbeNumber = 0;
int bigesttSum = 0;

int currentProbeNumber = 0;


while (true) 
{
    string input = Console.ReadLine();
    if (input == "Clone them!")
    { 
        break;
    }
    int[] probe = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    currentProbeNumber++;
    int currentSequenceLength = 0;

    foreach (var item in probe)
    {
        if (item == 1)
        {
            currentSequenceLength++;
        }
        else if (item == 0 && currentSequenceLength > 0)
        { 
            break; 
        } 
    }

    int currentSequenceIndex = Array.IndexOf(probe, 1);
    int currentSum = probe.Sum();

    if (currentSequenceLength > longestSequenceLength ||
        currentSequenceLength == longestSequenceLength && currentSequenceIndex < longestSequenceIndex ||
        currentSequenceLength == longestSequenceLength && currentSequenceIndex == longestSequenceIndex && currentSum > bigesttSum)
    {
        longestSequenceLength = currentSequenceLength;
        longestSequenceIndex = currentSequenceIndex;
        bestDna = probe;
        bestProbeNumber = currentProbeNumber;
        bigesttSum = currentSum;
    }
}
Console.WriteLine($"Best DNA sample {bestProbeNumber} with sum: {bigesttSum}.");
Console.WriteLine(string.Join(" ", bestDna));