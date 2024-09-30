namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Student> students = new List<Student>(); //тук ще пазим обектите(студентите)

            while ((input = Console.ReadLine()) != "end")
            {
                string[] objectInfo = input.Split();
                string firstName = objectInfo[0];
                string lastName = objectInfo[1];

                if (IsStudentExist(students, firstName, lastName))
                {
                    Student obect = GetStudent(students, firstName, lastName);
                        {
                        obect.FirstName = firstName;
                        obect.LastName = lastName;
                        obect.Age = int.Parse(objectInfo[2]);
                        obect.HomeTown = objectInfo[3];
                        }
                }
                else
                {
                    Student obect = new Student(); //създаваме обект студент и му попълваме данните
                    {
                        obect.FirstName = firstName;
                        obect.LastName = lastName;
                        obect.Age = int.Parse(objectInfo[2]);
                        obect.HomeTown = objectInfo[3];
                    }
                    students.Add(obect); //добавяме студента към списъка със студенти
                }
            }
            string town = Console.ReadLine();

            foreach (Student obect in students)
            {
                if (obect.HomeTown == town)
                {
                    Console.WriteLine($"{obect.FirstName} {obect.LastName} is {obect.Age} years old.");
                }
            }
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student found = null;

            foreach (Student obect in students) 
            {
                if (obect.FirstName == firstName && obect.LastName == lastName) 
                {
                    found = obect;
                }
            }
            return found;
        }

        static bool IsStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student obect in students)
            {
                if (obect.FirstName == firstName && obect.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
    
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}
