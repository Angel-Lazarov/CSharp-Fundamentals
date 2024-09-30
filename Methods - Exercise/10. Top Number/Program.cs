namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string numberAsString = new string(i.ToString());  //234

                //---------------------------------------------------------------
                // 1)  Its sum of digits is divisible by 8, e.g. 8, 17, 88
                int sumOfDigits = SumOfDigits(numberAsString);
                bool isDivisible = DivisableCheck(sumOfDigits);

                // 2)	Holds at least one odd digit, e.g. 232, 707, 87578
                bool hasOddDigit = OddCheck(numberAsString);
                //---------------------------------------------------------------

                if (isDivisible && hasOddDigit)
                {
                    Console.WriteLine(numberAsString);
                }
            }
        }

        static bool OddCheck(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool DivisableCheck(int sumOfDigits)
        {
            if (sumOfDigits % 8 == 0)
            {
                return  true;
            }

            return false;
        }

        static int SumOfDigits(string input)
        {
            int currentSumOfDigits = 0;
            for (int i = 0; i < input.Length; i++)
            {
                currentSumOfDigits += int.Parse(input[i].ToString());
            }

            return currentSumOfDigits;
        }
    }
}