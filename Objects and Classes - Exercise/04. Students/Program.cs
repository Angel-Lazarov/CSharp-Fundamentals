
int n = int.Parse(Console.ReadLine());
List<Student> students = new List<Student>(); 

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string firstName = input[0];
    string lastName = input[1];
    float grade = float.Parse(input[2]);

    Student student = new Student();
    student.FirstName = firstName;
    student.LastName = lastName;
    student.Grade = grade;

    students.Add(student);
}

List<Student> orderedStudents = students.OrderByDescending(student => student.Grade).ToList();
Console.WriteLine(string.Join("\n", orderedStudents));


//foreach (Student student in students.OrderByDescending(x => x.Grade))
//{
//    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
//}


class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public float Grade { get; set; }
    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:F2}";
    }
}