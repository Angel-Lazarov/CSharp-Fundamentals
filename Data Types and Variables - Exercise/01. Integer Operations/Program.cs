int first = int.Parse(Console.ReadLine());
int.TryParse(Console.ReadLine(), out int second);
int third = int.Parse(Console.ReadLine());
int.TryParse(Console.ReadLine(), out int fourth);

int result = ((first + second) / third) * fourth;
Console.WriteLine(result);