byte capacity = 255;
int action = int.Parse(Console.ReadLine());

for (int i = 0; i < action; i++) 
{
    int quantity = int.Parse(Console.ReadLine());

    if (capacity - quantity >= 0)
    {
        capacity -= (byte)quantity;
    }
    else { Console.WriteLine("Insufficient capacity!"); }
}
Console.WriteLine($"{255 - capacity}");