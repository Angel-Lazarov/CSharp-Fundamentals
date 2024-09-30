namespace _02._The_Lift
{
    public class Program
    {
        public static void Main()
        {
            // 01. Programming Fundamentals Mid Exam Retake - 02. The Lift
            // 16:56

            int waiting = int.Parse(Console.ReadLine());
            List<int> lift = Console.ReadLine().Split().Select(int.Parse).ToList();
            int freeWagonSeats = 0;
            int allSeats = lift.Count * 4;
            int seatsTaken = lift.Sum();
            int freeSeats = allSeats - seatsTaken;
            int peopleIn = 0;

            for (int wagon = 0; wagon < lift.Count; wagon++)
            {
                freeWagonSeats = 4 - lift[wagon];

                if (freeWagonSeats > 0 && waiting > 0)
                {       //    4         >    3
                    if (freeWagonSeats >= waiting)
                    {
                        peopleIn = waiting;
                    }         //    4         >    6
                    else if (freeWagonSeats < waiting)
                    { 
                        peopleIn = freeWagonSeats; 
                    }

                        if (waiting > 4) //5
                        {
                            lift[wagon] += peopleIn; // full
                            waiting -= peopleIn;
                            freeSeats -= peopleIn;
                        }
                        else if (waiting <= 4) //1
                        {
                        //    3      += 4 - lift[wagon]
                            freeSeats -= peopleIn;
                            waiting -= peopleIn;
                            lift[wagon] += peopleIn;
                        }
                }
            }

            if (waiting == 0 && freeSeats > 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (waiting > 0 && freeSeats == 0)
            {
                Console.WriteLine($"There isn't enough space! {waiting} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (freeSeats <= 0 && waiting == 0)
            {
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
/*
10
1 2 3 4 1
 */ 