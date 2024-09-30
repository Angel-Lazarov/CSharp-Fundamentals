
int.TryParse(Console.ReadLine(), out int n);

Family family = new Family();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string name = input[0];
    int age = int.Parse(input[1]);

    Person person = new Person()
    {
        Name = name,
        Age = age
    };
   family.AddMember(person);
}

Person oldest = family.GetOldestMember();
Console.WriteLine($"{oldest.Name} {oldest.Age}");



class Person 
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Family 
{
    public Family()
    {
        Persons = new List<Person>();
    }

    public List<Person> Persons { get; set; }


    public void AddMember(Person member)
    {
       Persons.Add(member);
    }

    public Person GetOldestMember()
    {
        return Persons.OrderByDescending(p => p.Age).First();
    }
}