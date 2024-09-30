public class Program
{
    public static void Main()
    {
        //Lists - Exercise - 05. Bomb Numbers

        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string[] bomb = Console.ReadLine().Split(); // [ 4 2 ]
        int bombNumber = int.Parse(bomb[0]);

        int bombPower = int.Parse(bomb[1]);
        // index   0 1 2  3  4 5 6 7
        // left -> 1 2 2 (4) 2 2 2 9  <-right

        while (numbers.Contains(bombNumber))
        {
            int bombIndex = numbers.IndexOf(bombNumber); //Finds bombNumber Index
                                                         //    i=    3    - 1=2  2 >= 3  - 2 =1
            for (int i = bombIndex - 1; i >= bombIndex - bombPower; i--)
            {
                if (i >= 0 && i < numbers.Count)
                {
                    numbers.RemoveAt(i);
                }
            }
            //Console.WriteLine(string.Join(" ", numbers));

            // index   	0  1 2				  0  1
            // left -> (5) 1 1  <-right ->>> (5) 1

            bombIndex = numbers.IndexOf(bombNumber); // Refind bombNumber Index

            //            i=   0 + 2 = 2               2 > 0 
            for (int index = bombIndex + bombPower; index > bombIndex; index--)
            {
                if (index >= 0 && index < numbers.Count)
                {
                    numbers.RemoveAt(index);
                }
            }
            //Console.WriteLine(string.Join(" ", numbers));

            numbers.Remove(bombNumber);

        }
        //	Console.WriteLine(string.Join(" ", numbers));
        //	Console.WriteLine(numbers.Count());
        Console.WriteLine(numbers.Sum());
    }
}