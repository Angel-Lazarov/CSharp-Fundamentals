namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myEnergy = int.Parse(Console.ReadLine());

            string command = string.Empty;
            int wonBattles = 0;
            bool notEnoughEnergy = false;

            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distanceToEnemy = int.Parse(command);

                if (myEnergy >= distanceToEnemy)
                {
                    wonBattles++;
                    myEnergy -= distanceToEnemy;

                    if (wonBattles % 3 == 0)
                    {
                        myEnergy += wonBattles;
                    }
                }
                else
                {
                    break;
                }
            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {myEnergy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {myEnergy} energy");
            }


        }
    }
}