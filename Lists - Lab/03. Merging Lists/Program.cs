namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            if (firstList.Count > secondList.Count)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }

                for (int i = secondList.Count; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else if (firstList.Count <= secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }

                for (int i = firstList.Count; i < secondList.Count; i++) 
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}