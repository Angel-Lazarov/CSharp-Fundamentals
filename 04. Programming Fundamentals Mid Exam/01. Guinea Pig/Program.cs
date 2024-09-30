namespace _01._Guinea_Pig
{
    public class Program
    {
        public static void Main()
        { //14:14 - 14:34
          //04. Programming Fundamentals Mid Exam - 01. Guinea Pig

            float foodMonth = float.Parse(Console.ReadLine());
            float hayMonth = float.Parse(Console.ReadLine());
            float coverMonth = float.Parse(Console.ReadLine());
            float animalWeight = float.Parse(Console.ReadLine());
            bool isEnough = true;


            for (int day = 1; day <= 30; day++)
            {
                foodMonth -= 0.3f;
                if (day % 2 == 0)
                {
                    hayMonth -= foodMonth * 0.05f;
                }
                if (day % 3 == 0)
                {
                    coverMonth -= animalWeight / 3;
                }

                if (foodMonth <= 0 || hayMonth <= 0 || coverMonth <= 0)
                {
                    isEnough = false;
                    break;
                }
            }

            if (isEnough)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodMonth:f2}, Hay: {hayMonth:f2}, Cover: {coverMonth:f2}.");
            }
            else
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }


        }
    }
}