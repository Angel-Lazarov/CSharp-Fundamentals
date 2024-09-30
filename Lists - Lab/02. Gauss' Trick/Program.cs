namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            //1 2 3 4 5 6

            for (int i = 0; i <  numbers.Count / 2; i++)
            {
                int sum = numbers[i] + numbers[numbers.Count - 1 - i];
                result.Add(sum);

            }

            if (numbers.Count % 2 != 0) 
            {
                result.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}