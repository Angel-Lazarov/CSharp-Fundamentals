namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool length = PasswordLengthChecker(input);
            bool symbol = PasswordSymbolChecker(input);
            bool digit = PasswordDigitsChecker(input);


            if (length && symbol && digit)
            { 
                Console.WriteLine("Password is valid");
            }
        }
        
        static bool PasswordLengthChecker(string input)
        {
            bool valid = true;
            if (input.Length < 6 || input.Length > 10)
            {
                valid = false;
                Console.WriteLine("Password must be between 6 and 10 characters"); 
            }
            return valid;
        }

        static bool PasswordSymbolChecker(string input) 
        {
            bool valid = true;
            for (int i = 0; i < input.Length; i++)
            {                   
                if (input[i] < 48 
                    || (input[i] > 57 && input[i] < 65) 
                    || (input[i] > 90  && input[i] < 97) 
                    || input[i] > 122) 
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        static bool PasswordDigitsChecker(string input)
        {
            int digits = 0;
            bool valid = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits++;
                }
            }
            if (digits < 2)
            {
                valid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            return valid;
        }
    }
}
