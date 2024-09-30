namespace _03._Memory_Game
{
    /*
1 1 2 2 3 3 4 4 5 5 
1 0
-1 0
1 0 
1 0 
1 0 
End

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            int count = 0;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                int[] index = input.Split().Select(int.Parse).ToArray();

                int firstIndex = index[0];
                int secondIndex = index[1];
                count++;

                if (IsFirstIndex(firstIndex, list) && IsSecondIndex(secondIndex, list) && firstIndex != secondIndex)
                {
                    if (list[firstIndex] == list[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {list[firstIndex]}!");
                        int highIndex = Math.Max(firstIndex, secondIndex);
                        int lowIndex = Math.Min(firstIndex, secondIndex);
                        list.RemoveAt(highIndex);
                        list.RemoveAt(lowIndex);

                        if (list.Count == 0) 
                        { 
                            break;
                        }
                    }
                    else if (list[firstIndex] != list[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    //може да създадем нов лист с 2 нови елемента и да го InsertRange(startIndex, newlist)
                    string addCount = "-" + count.ToString() + "a";
                    list.Insert(list.Count/2, addCount);
                    list.Insert(list.Count / 2, addCount);
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine($"You have won in {count} turns!");
            }
            else 
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", list));
            }
        }

        static bool IsFirstIndex(int firstIndex, List<string> list)
        {
            return firstIndex >= 0 && firstIndex < list.Count;
        }
        static bool IsSecondIndex(int secondIndex, List<string> list)
        {
            return secondIndex >= 0 && secondIndex < list.Count;
        }

    }
}