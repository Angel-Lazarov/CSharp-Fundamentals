//int n = int.Parse(Console.ReadLine());
//int sum = 0;
//int broi = 0;

//for (int i = 1; i > 0; i++)
//{
//    if (i % 2 != 0)
//    {
//        if (broi == n)
//        {
//            break;
//        }
//        else
//        {
//            Console.WriteLine(i);
//            broi++;
//            sum += i;
//        }
//    }
//}
//Console.WriteLine("Sum: " + sum);

int n = int.Parse(Console.ReadLine());
int sum = 0;
int broi = 0;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{2*i-1}");
    sum += 2 * i - 1;
}
Console.WriteLine("Sum: " + sum);

