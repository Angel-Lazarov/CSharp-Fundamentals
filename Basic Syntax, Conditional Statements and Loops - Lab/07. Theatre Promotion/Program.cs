﻿string dayType = Console.ReadLine();
int.TryParse(Console.ReadLine(), out int age);
int price = 0;

if (age >= 0 && age <= 18) 
{
    if (dayType == "Weekday") { price = 12; }
    else if (dayType == "Weekend") { price = 15; }
    else { price = 5; }
}
else if (age > 18 && age <= 64)
{
    if (dayType == "Weekday") { price = 18; }
    else if (dayType == "Weekend") { price = 20; }
    else { price = 12; }
}
else if (age > 64 && age <= 122)
{
    if (dayType == "Weekday") { price = 12; }
    else if (dayType == "Weekend") { price = 15; }
    else { price = 10; }
}
else { Console.WriteLine("Error!"); }

if (price > 0) { Console.WriteLine(price+"$"); }

