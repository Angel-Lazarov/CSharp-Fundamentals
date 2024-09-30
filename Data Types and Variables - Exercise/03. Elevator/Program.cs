int numberOfPeople = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());
//int courses = (int)Math.Ceiling((double)numberOfPeople / capacity);
int courses = numberOfPeople / capacity;
if (numberOfPeople % capacity != 0) 
{
    courses++;
}

Console.WriteLine(courses);