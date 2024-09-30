namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                List<string> command = input.Split().ToList();

                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= list.Count)
                    {
                        endIndex = list.Count - 1;
                    }

                    MergeIndexes(list, startIndex, endIndex);
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    Divide(list, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }

        private static void Divide(List<string> list, int index, int partitions)
        {

            List<string> dividedElement = new List<string>();

            int partSize = list[index].Length / partitions;

            string newSegment = string.Empty;

            int count = 0;

            for (int i = 0; i < list[index].Length; i += partSize)
            {

                if (count == partitions - 1 && list[index].Length % partitions != 0)
                {
                    newSegment = list[index].Substring(i, partSize + 1);
                    dividedElement.Add(newSegment);
                    break;
                }

                newSegment = list[index].Substring(i, partSize);
                dividedElement.Add(newSegment);
                count++;
            }
            list.RemoveAt(index);
            list.InsertRange(index, dividedElement);
        }

        static void MergeIndexes(List<string> list, int startIndex, int endIndex)
        {
            string merged = string.Empty;

            if (startIndex > list.Count - 1)
            {
                return;
            }


            int toRemove = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                merged += list[i];
                toRemove++;
            }

            list.RemoveRange(startIndex, toRemove);
            list.Insert(startIndex, merged);
        }

    }
}