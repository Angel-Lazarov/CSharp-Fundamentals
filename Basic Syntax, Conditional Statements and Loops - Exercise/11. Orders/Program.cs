int orders = int.Parse(Console.ReadLine());
decimal finalSum = 0;

for (int i = 0; i < orders; i++) 
{
    decimal capsulePrice = decimal.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsuleCount = int.Parse(Console.ReadLine());

    decimal orderSum = days * capsuleCount * capsulePrice;
    Console.WriteLine($"The price for the coffee is: ${orderSum:F2}");
    finalSum += orderSum;
}
Console.WriteLine($"Total: ${finalSum:F2}");
