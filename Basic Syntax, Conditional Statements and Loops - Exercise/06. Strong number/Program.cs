int number = int.Parse(Console.ReadLine());
int sum = 0;
string numText = number.ToString();

for (int j = 0; j < numText.Length; j++)  
{
    int midleSum = 1;
    int newNumber = int.Parse(numText[j].ToString());

    if (newNumber != 0)
    {
        for (int i = 1; i <= newNumber; i++)
        {
            midleSum *= i;
        }
    }
    sum+= midleSum;
}

if (number == sum)
{
    Console.WriteLine("yes");
}
else 
{ 
    Console.WriteLine("no");
}
