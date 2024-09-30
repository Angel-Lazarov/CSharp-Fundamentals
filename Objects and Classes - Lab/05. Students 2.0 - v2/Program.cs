using System.Reflection.Metadata.Ecma335;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            List<Student> students = new List<Student>(); //тук ще пазим обектите(студентите)

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentInfo = input.Split();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string homeCity = studentInfo[3];   



                Student student = new Student(); //създаваме обект студент и му попълваме данните
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeCity;

                int index = IsValid(firstName, lastName, students); // ако има съществуващ му връща индекса, ако няма намере, връща -1

                if (index != -1) 
                {
                    students[index].Age = age;
                    students[index].HomeTown = homeCity;
                    continue; // след промяна на съществуващи данни прекъсва текущата итерация и продължава.
                }

                students.Add(student); //добавяме студента към списъка със студенти
            }

            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static int IsValid(string firstName, string lastName, List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].FirstName == firstName && students[i].LastName == lastName)
                {
                    return i;
                }
            }
             return -1;
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