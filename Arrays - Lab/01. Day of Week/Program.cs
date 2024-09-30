//Arrays - Lab - 01. Day of Week
string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int input = int.Parse(Console.ReadLine());

if (input >=1 && input <=7) 
{
    Console.WriteLine(days[input-1]);
}
else
{
    Console.WriteLine("Invalid day!");
}
       
