
int.TryParse(Console.ReadLine(), out int n);

List<Employee> employees = new List<Employee>();
List<string> otdel = new List<string>();

for (int i = 0; i < n; i++)
{
    string[] emplyeeInfo = Console.ReadLine().Split();
    string name = emplyeeInfo[0];
    double salary = double.Parse(emplyeeInfo[1]);
    string department = emplyeeInfo[2];

    Employee employee = new Employee()
    {
        Name = name,
        Salary = salary,
        Department = department
    };

    employees.Add(employee);

    if (!otdel.Contains(department))
    {
        otdel.Add(department);
    }
}

double highAverage = double.MinValue;

int departmentsCount = otdel.Count;

string bestDepartment = string.Empty;

for (int i = 0; i < otdel.Count; i++)
{
    string currentOtdel = otdel[i];

    foreach (Employee worker in employees)
    {
        double sum = employees.Where(w => w.Department == currentOtdel).Sum(x => x.Salary);
        if (sum > highAverage)
        {
            highAverage = sum;
            bestDepartment = currentOtdel;
        }
    }
}

Console.WriteLine($"Highest Average Salary: {bestDepartment}");

foreach (Employee worker in employees.Where(w => w.Department == bestDepartment).OrderByDescending(x => x.Salary))
{
    Console.WriteLine($"{worker.Name} {worker.Salary:F2}");
}

class Employee
{
    public string Name { get; set; }

    public double Salary { get; set; }

    public string Department { get; set; }
}


