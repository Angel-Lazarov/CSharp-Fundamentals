namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string[] input = Console.ReadLine().Split().ToArray();

            int currentPosition = 0;

            while (input[0] != "Love!")
            {
                int index = int.Parse(input[1]);

                int goingTo = currentPosition + index;

                if (goingTo < houses.Length)
                {
                    currentPosition = goingTo;
                }
                else if (goingTo >= houses.Length - 1)
                {
                    currentPosition = 0;
                }

                if (houses[currentPosition] != 0)
                {
                    houses[currentPosition] -= 2;
                    isValentineDay(currentPosition, houses);
                }
                else // (houses[goingTo] == 0)
                {
                    Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
                }
                
                input = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"Cupid's last position was {currentPosition}.");

            if (houses.All(x => x == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int count = 0;
                for (int i = 0; i < houses.Length; i++)
                {
                    if (houses[i] != 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }

        static void isValentineDay(int index, int[] houses)
        {
            if (houses[index] == 0)
            {
                Console.WriteLine($"Place {index} has Valentine's day.");
            }
        }
    }
}