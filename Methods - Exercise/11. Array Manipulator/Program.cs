namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            //----четем масива-------
            int[] masiv = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] masiv = { 1, 2, 5, 7, 9 }; // 1 3 5 7 9
            //int[] masiv = { 1, 10, 100, 1000 }; // 1 3 5 7 9

            while ((input = Console.ReadLine()) != "end")
            {
                int digitFromInputComand = TakeDigitFromInputComand(input);
                string textComand = TakeStringFromComand(input);


                if (textComand == "exchange")
                {
                       ExchangeByIndex(masiv, digitFromInputComand);
                }
                else if (textComand == "maxeven")
                {
                     MaxEven(masiv);
                }
                else if (textComand == "maxodd")
                {
                     MaxOdd(masiv);
                }
                else if (textComand == "mineven")
                {
                     MinEven(masiv);
                }
                else if (textComand == "minodd")
                {
                     MinOdd(masiv);
                }
                else if (textComand == "firsteven")
                {
                     FirstCount(masiv, digitFromInputComand, textComand);
                }
                else if (textComand == "firstodd")
                {
                     FirstCount(masiv, digitFromInputComand, textComand);
                }
                else if (textComand == "lasteven")
                {
                    LastCount(masiv, digitFromInputComand, textComand);
                }
                else if (textComand == "lastodd")
                {
                    LastCount(masiv, digitFromInputComand, textComand);
                }



            }
            Console.WriteLine($"[{string.Join(", ", masiv)}]");
        }

        static string TakeStringFromComand(string text)
        {
            string comand = string.Join("", text.Where(char.IsLetter));
            return comand;
        }

        private static int TakeDigitFromInputComand(string text)
        {
            string number = string.Join("", text.Where(char.IsDigit));
            int.TryParse(number, out int digit);
            return digit;
        }

        private static void LastCount(int[] masiv, int count, string wish)
        {
            if (wish == "lasteven")
            {
                int[] last = new int[0];

                for (int i = 0; i < masiv.Length; i++)
                {
                    if (masiv[i] % 2 == 0) 
                    {
                    last = last.Append(masiv[i]).ToArray();
                        if (last.Length == count)
                        {
                            break;
                        }
                    }
                }

                if (count > masiv.Length)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }

                else if (count <= masiv.Length) 
                {
                    Console.WriteLine($"[{string.Join(", ", last)}]");
                }
            }
            else if (wish == "lastodd")
            {  
                int[] last = new int[0];

                for (int i = 0; i < masiv.Length; i++)
                {
                    if (masiv[i] % 2 != 0)
                    {
                        last = last.Append(masiv[i]).ToArray();
                        if (last.Length == count)
                        {
                            break;
                        }
                    }
                }

                if (count <= masiv.Length)
                {
                    Console.WriteLine($"[{string.Join(", ", last)}]");
                }
                else
                {
                    Console.WriteLine("Invalid count");
                    return;
                }
            }
        }

        static void FirstCount(int[] masiv, int count, string wish)
        {
            if (wish == "firsteven")
            {
                int[] first = new int[0];

                for (int i = 0; i < masiv.Length; i++)
                {
                    if (masiv[i] % 2 == 0)
                    {
                        first = first.Append(masiv[i]).ToArray();
                        if (first.Length == count)
                        {
                            break;
                        }
                    }
                }

                if (count <= masiv.Length)
                {
                    Console.WriteLine($"[{string.Join(", ", first)}]"); 
                }
                else
                {
                    Console.WriteLine("Invalid count");
                    return;
                }
            }
            else if (wish == "firstodd")
            {
                int[] first = new int[0];

                for (int i = 0; i < masiv.Length; i++)
                {       
                    if (masiv[i] % 2 != 0)
                    {
                        first = first.Append(masiv[i]).ToArray();
                        if (first.Length == count) 
                        {
                            break;
                        }
                    }
                }

                if (count <= masiv.Length)
                {
                    Console.WriteLine($"[{string.Join(", ", first)}]");
                }
                else
                {
                    Console.WriteLine("Invalid count");
                    return;
                }
            }
        }

        private static void MinEven(int[] masiv)
        {
            bool isFound = false;
            int bestIndex = 0;
            int minEven = int.MaxValue;
            for (int i = 0; i < masiv.Length; i++)
            {

                if (masiv[i] % 2 == 0)
                {
                    if (masiv[i] <= minEven)
                    {
                        isFound = true;
                        minEven = masiv[i];
                        bestIndex = i;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine(bestIndex);
            }
            else 
            {
                Console.WriteLine("No matches");
            }
        }

        private static void MinOdd(int[] masiv)
        {
            bool isFound = false;
            int bestIndex = 0;
            int minOdd = int.MaxValue;
            for (int i = 0; i < masiv.Length; i++)
            {

                if (masiv[i] % 2 != 0) //нечетно
                {
                    if (masiv[i] <= minOdd)
                    {
                        minOdd = masiv[i];
                        bestIndex = i;
                        isFound = true;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine(bestIndex); 
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }

        private static void MaxEven(int[] masiv)
        {
            bool isFound = false;
            int bestIndex = 0;
            int maxEven = int.MinValue;
            for (int i = 0; i < masiv.Length; i++)
            {
                
                if (masiv[i] % 2 == 0) //четно
                {
                    if (masiv[i] >= maxEven)
                    {
                        maxEven = masiv[i];
                        bestIndex = i;
                        isFound = true;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine(bestIndex); 
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void MaxOdd(int[] masiv)
        {
            bool isFound = false;
            int bestIndex = 0;
            int maxOdd = int.MinValue;
            for (int i = 0; i < masiv.Length; i++)
            {
                
                if (masiv[i] % 2 != 0) //нечетно
                {
                    if (masiv[i] >= maxOdd)
                    {
                        maxOdd = masiv[i];
                        bestIndex = i;
                        isFound= true;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine(bestIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void ExchangeByIndex(int[] masiv, int separator)
        {
            int[] tmp = new int[0];

            if (separator < masiv.Length)
            {
                for (int i = separator + 1; i < masiv.Length; i++)
                {
                    tmp = tmp.Append(masiv[i]).ToArray();
                }
                for (int i = 0; i <= separator; i++)
                {
                    tmp = tmp.Append(masiv[i]).ToArray();
                }
                for (int i = 0; i < tmp.Length; i++)
                {
                    masiv[i] = tmp[i];
                }
            }
            else 
            { 
                Console.WriteLine("Invalid index");
            }
        }
    }
}