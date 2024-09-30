
namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = string.Empty;

            int count = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);

                if (index >= 0 && index < targets.Length && targets[index] != -1) 
                {
                    int currentTarget = targets[index];
                    targets[index] = -1;
                    count++;

                    for (int i = 0; i < targets.Length; i++) 
                    {
                        if (targets[i] > currentTarget && targets[i] != -1) 
                        {
                            targets[i] -= currentTarget;
                        }
                        else if (targets[i] <= currentTarget && targets[i] != -1)
                        {
                            targets[i] += currentTarget;
                        }
                    }
                }
            }

            Console.Write($"Shot targets: {count} -> ");
            Console.WriteLine(string.Join(" ", targets));
        }
    }
}