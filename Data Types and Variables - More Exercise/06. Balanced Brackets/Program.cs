//Data Types and Variables - More Exercise - 06. Balanced Brackets
int lines = int.Parse(Console.ReadLine());
int openingBraket = 0;
int closingBraket = 0;

for (int i = 1; i <= lines; i++)
{
    string input = Console.ReadLine();

    if (input == ")" && openingBraket == 0) 
    {
        closingBraket++;
        break;
    }
    else if (input == "(")
    {
        openingBraket++;
        if (openingBraket == 2)
        { 
            break;
        }
    }
    else if (input == ")")
    {
        closingBraket++;
        if (closingBraket == 2) 
        {
            break;
        }
    }

    if (openingBraket == 1 && closingBraket == 1) 
    {
        openingBraket = 0; 
        closingBraket = 0;
    }
}

if (openingBraket != closingBraket)
{
    Console.WriteLine("UNBALANCED");
}
else
{ 
    Console.WriteLine("BALANCED");
}
