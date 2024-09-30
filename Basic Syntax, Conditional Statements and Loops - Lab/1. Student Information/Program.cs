string name = Console.ReadLine();
int.TryParse(Console.ReadLine(), out int age);
double.TryParse(Console.ReadLine(), out double grade);

Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
