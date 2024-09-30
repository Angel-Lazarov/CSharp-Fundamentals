namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            List<Student> students = new List<Student>(); //тук ще пазим обектите(студентите)

            while ((input=Console.ReadLine()) != "end")
            {
                string[] studentInfo = input.Split();

                Student student = new Student(); //създаваме обект студент и му попълваме данните
                {
                    student.FirstName = studentInfo[0];
                    student.LastName = studentInfo[1];
                    student.Age = int.Parse(studentInfo[2]);
                    student.HomeTown = studentInfo[3];
                }
                students.Add(student); //добавяме студента към списъка със студенти
            }

            string city = Console.ReadLine();

            //---------------------------for begin------------------------------------------------------------
            //for (int i = 0; i < students.Count; i++) 
            //{
            //    if (students[i].HomeTown == city) 
            //    {
            //        Console.WriteLine($"{students[i].FirstName} {students[i].LastName} is {students[i].Age} years old.");
            //    }

            //}
            //-----------------------------for end-------------------------------------------------------------
            //*************************************************************************************************
            //------------------------foreach begin------------------------------------------------------------
            //foreach (Student student in students)
            //{
            //    if (student.HomeTown == city)
            //    {
            //        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            //    }
            //}
            //---------------------foreach end-----------------------------------------------------------------
            //*************************************************************************************************
            //------------------------LINQ Filter begin--------------------------------------------------------

            List<Student> filterd = students.Where(x=>x.HomeTown == city).ToList();
            foreach (Student student in filterd)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
            //------------------------LINQ Filter end----------------------------------------------------------
        }
    }

    class Student 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}