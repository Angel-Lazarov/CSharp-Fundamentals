string name = Console.ReadLine();
string pass = "";
string input = string.Empty;
int fails = 0;

for (int i = name.Length-1; i >=0; i--)
{
    pass = pass + name[i];
}

while ((input = Console.ReadLine()) != pass)
{
    fails++;
    if (fails > 3) { break; }
    Console.WriteLine("Incorrect password. Try again.");
}

if (fails > 3)
{
    Console.WriteLine($"User {name} blocked!");
}
else
{
    Console.WriteLine($"User {name} logged in.");
}