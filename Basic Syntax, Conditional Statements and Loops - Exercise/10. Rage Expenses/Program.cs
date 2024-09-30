//Basic Syntax, Conditional Statements and Loops - Exercise - 10. Rage Expenses
int.TryParse(Console.ReadLine(), out int lostGamesCount);

decimal.TryParse(Console.ReadLine(), out decimal headsetPrice);
decimal.TryParse(Console.ReadLine(), out decimal mousePrice);
decimal.TryParse(Console.ReadLine(), out decimal keyboardPrice);
decimal.TryParse(Console.ReadLine(), out decimal displayPrice);
int headset = 0;
int mouse = 0;
int keyboard = 0;
int display = 0;

for (int i = 1; i <= lostGamesCount; i++)
{
    if (i % 2 == 0) { headset++; }
    if (i % 3 == 0) { mouse++; }
    if (i % 2 == 0 && i % 3 == 0)
    {
        keyboard++;
        if (keyboard % 2 == 0) { display++; }
    }
}
decimal sum = headset * headsetPrice + mouse * mousePrice + keyboard * keyboardPrice + display * displayPrice;
Console.WriteLine($"Rage expenses: {sum:F2} lv.");