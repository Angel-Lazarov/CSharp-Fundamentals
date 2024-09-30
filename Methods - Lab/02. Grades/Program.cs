namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Checker(grade);
        }
        static void Checker(double digit)
        {
            string grade = string.Empty;
            if (digit >= 2 && digit <= 2.99)
            {
                grade = "Fail";
            }
            else if (digit >=3 && digit <=3.49)
            { 
                grade = "Poor";
            }
            else if (digit >=3.50 && digit <=4.49) 
            {
                grade = "Good";
            }
            else if (digit >=4.5 && digit <=5.49)
            {
                grade = "Very good";
            }
            else if (digit >=5.5 && digit <=6) 
            {
                grade = "Excellen"; 
            }
            Console.WriteLine(grade);
        }
    }
}