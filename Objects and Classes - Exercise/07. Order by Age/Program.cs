
using System.Security.Cryptography;

string input = string.Empty;

List<Person> persons = new List<Person>();

while ((input = Console.ReadLine())!="End")
{
    string[] personInfo = input.Split();

    Person person = new Person();
    person.Name = personInfo[0];
    person.Age = int.Parse(personInfo[2]);
    person.Id = personInfo[1];


    if (persons.Any(p => p.Id == personInfo[1]))
    {
        person = persons.First(x => x.Id == personInfo[1]);
        person.Name = personInfo[0];
        person.Age = int.Parse(personInfo[2]);
    }
    else 
    {
    persons.Add(person);
    }
}

foreach (Person person in persons.OrderBy(p=>p.Age))
{
    Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
}



class Person 
{
    public string Name { get; set; }
    public string Id { get; set; }
    public int Age { get; set; }
}



