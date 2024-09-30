decimal budjet = decimal.Parse(Console.ReadLine());
int.TryParse(Console.ReadLine(), out int students);
decimal.TryParse(Console.ReadLine(), out decimal saberPrice);
decimal.TryParse(Console.ReadLine(), out decimal robePrice);
decimal.TryParse(Console.ReadLine(), out decimal beltPrice);
int beltNumber = students;

for (int i = 1; i <= students; i++)
{
    if (i % 6 == 0) { beltNumber--; }
}

decimal needed = (decimal)Math.Ceiling(students * 1.1) * saberPrice + students * robePrice + beltNumber * beltPrice;

if (budjet >= needed)
{
    Console.WriteLine($"The money is enough - it would cost {needed:F2}lv.");
}
else
{
    Console.WriteLine($"John will need {needed - budjet:F2}lv more.");
}
