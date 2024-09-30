namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int.TryParse(Console.ReadLine(), out int number);
                ModifyInput(number);
            }
            else if (input == "real")
            {
                double.TryParse(Console.ReadLine(), out double number);
                ModifyInput(number);
            }
            else if (input == "string")
            {
                string text = Console.ReadLine();
                ModifyInput(text);
            }
        }

        static void ModifyInput(int number)
        {
            Console.WriteLine(number*2);
        }

        static void ModifyInput(double number)
        {
            Console.WriteLine($"{ number * 1.5:F2}");
        }

        static void ModifyInput(string text) 
        {
            Console.WriteLine("$"+text+"$");
        }
    }

}
