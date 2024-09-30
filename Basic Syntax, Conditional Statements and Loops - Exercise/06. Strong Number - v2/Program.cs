int number = int.Parse(Console.ReadLine());
int copy = number;
int sum = 0;

while (copy > 0) 
{
    int digit = copy % 10;
    copy = copy / 10;
    int facturiel = 1;

    for (int i = 1; i <= digit; i++) 
    {
        facturiel *= i;
    }  
    sum += facturiel;
}
if (number == sum) { Console.WriteLine("yes"); }
else { Console.WriteLine("no"); }   