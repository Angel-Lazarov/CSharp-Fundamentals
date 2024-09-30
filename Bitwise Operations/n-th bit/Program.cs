int number = int.Parse(Console.ReadLine());
int position = int.Parse(Console.ReadLine());

int shiftedNumber = number >> position;
int lsb = shiftedNumber & 1;

Console.WriteLine(lsb);