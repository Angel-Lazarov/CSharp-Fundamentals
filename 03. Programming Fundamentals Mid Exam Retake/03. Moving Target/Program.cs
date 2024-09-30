namespace _03._Moving_Target
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        { // 16:27 - 17:45

            // 03. Programming Fundamentals Mid Exam Retake - 03. Moving Target

            List<int> target = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                string commandInfo = command[0];
                int index = int.Parse(command[1]);


                switch (commandInfo)
                {
                    case "Shoot":
                        int power = int.Parse(command[2]);

                        if (index >= 0 && index < target.Count) //ако съществува елемент тук
                        {
                            target[index] -= power;
                            if (target[index] <= 0)
                            {
                                target.RemoveAt(index);
                            }
                        }
                        break;

                    case "Add":
                        int strength = int.Parse(command[2]);
                        if (index >= 0 && index < target.Count) //ако съществува елемент тук
                        {
                            target.Insert(index, strength);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;

                    case "Strike":
                        int radius = int.Parse(command[2]);
                        //target.RemoveRange(int index, int count);
                        int startRange = index - radius;
                        int endRange = index + radius;
                        int count = radius * 2 + 1;

                        if (startRange >= 0 && endRange < target.Count)
                        {
                            target.RemoveRange(startRange, count);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join("|", target));
        }
    }
}