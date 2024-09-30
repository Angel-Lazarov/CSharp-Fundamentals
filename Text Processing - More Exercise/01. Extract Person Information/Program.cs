int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{ 
    string input = Console.ReadLine();

    int startIndexName = input.IndexOf('@') +1;
    int endIndexName = input.IndexOf('|');

    int startIndexAge = input.IndexOf('#')+1;
    int endIndexAge = input.IndexOf('*');

    string name = input.Substring(startIndexName, endIndexName - startIndexName);
    string age = input.Substring(startIndexAge, endIndexAge - startIndexAge);

    if (name is not null && age is not null) 
    {
        Console.WriteLine($"{name} is {age} years old.");
    }
}