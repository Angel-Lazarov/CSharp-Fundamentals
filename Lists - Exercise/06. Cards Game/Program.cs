public class Program
{
    public static void Main()
    {
        //Lists - Exercise - 06. Cards Game
        List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
        int length = playerOne.Count;

        while (playerOne.Count > 0 && playerTwo.Count > 0)
        {
            int i = 0;
            if (playerOne[i] > playerTwo[i])
            {   //playerOne взима 
                int temp = playerTwo[i];
                playerTwo.RemoveAt(i);
                playerOne.Add(temp);

                temp = playerOne[i];
                playerOne.RemoveAt(i);
                playerOne.Add(temp);
            }
            else if (playerOne[i] < playerTwo[i])
            {  //playerTwo взима
                int temp = playerOne[i];
                playerOne.RemoveAt(i);
                playerTwo.Add(temp);

                temp = playerTwo[i];
                playerTwo.RemoveAt(i);
                playerTwo.Add(temp);
            }
            else if (playerOne[i] == playerTwo[i])
            {
                playerOne.RemoveAt(i);
                playerTwo.RemoveAt(i);
            }
        }

        //Console.WriteLine(string.Join(" ", playerOne));
        //Console.WriteLine(string.Join(" ", playerTwo));

        if (playerOne.Count > 0)
        {
            int sum = playerOne.Sum();
            Console.WriteLine($"First player wins! Sum: {sum}");
        }
        else if (playerTwo.Count > 0)
        {
            int sum = playerTwo.Sum();
            Console.WriteLine($"Second player wins! Sum: {sum}");
        }
    }
}