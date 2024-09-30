namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);
            int sumEven = 0;
            int sumOdd = 0;

            while (input > 0)
            {
                int lastNum = input % 10;
                sumEven += GetSumOfEvenDigits(lastNum);
                sumOdd += GetSumOfOddDigits(lastNum);

                input = input / 10;
            }
            GetMultipleOfEvenAndOdds(sumEven, sumOdd);

        }
        static int GetSumOfEvenDigits(int lastNum) 
        {

            if (lastNum % 2 == 0)
            {
                return lastNum;
            }
            return 0;
        }

        static int GetSumOfOddDigits(int lastNum) 
        {
           
            if (lastNum % 2 != 0)
            {
                return lastNum;
            }
            return 0;
        }

        static void GetMultipleOfEvenAndOdds(int a, int b) 
        {
            Console.WriteLine(a*b);
        }
    }
}