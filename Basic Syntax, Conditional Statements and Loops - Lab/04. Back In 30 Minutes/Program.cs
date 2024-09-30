int.TryParse(Console.ReadLine(), out int hour);
int.TryParse(Console.ReadLine(), out int minutes);
minutes += 30;

if (minutes > 60)
{
    minutes -= 60;
    hour++;
}
if (hour > 23)
{ 
    hour = 0;
}

    Console.WriteLine($"{hour}:{minutes:D2}");
