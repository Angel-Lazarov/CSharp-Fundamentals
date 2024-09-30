namespace _03._Calculations
{
    internal class Program
    {
        static void Main()
        {
            string operant = Console.ReadLine();
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double result = Calculation(operant, number1, number2);
            Console.WriteLine(result);
        }
        static double Calculation(string operation, double digit1, double digit2) 
        {
                double methodResult = 0;
                switch (operation)
                {
                case "add":
                    methodResult = digit1 + digit2;
                        return methodResult;
                  //  Console.WriteLine(methodResult);
                    break;
                case "multiply":
                    methodResult = digit1* digit2;
                    return methodResult;
                    //  Console.WriteLine(methodResult);
                    break;
                case "subtract":
                    methodResult = digit1 - digit2;
                    return methodResult;
                    //  Console.WriteLine(methodResult);
                    break;
                default:
                    methodResult = digit1 / digit2;
                    return methodResult;
                    //  Console.WriteLine(methodResult);
                    break;
                }
        }   
    }
}
