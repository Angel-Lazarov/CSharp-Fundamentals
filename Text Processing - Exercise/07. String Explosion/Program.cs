using System.Text;

string input = Console.ReadLine();

string result = Explosion(input);
Console.WriteLine(result);

static string Explosion(string? input)
{
    StringBuilder resultString = new StringBuilder();
    int strength = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == '>')
        {
            resultString.Append(input[i]);
            strength += int.Parse(input[i + 1].ToString());
        }
        else if (strength == 0)
        {
            resultString.Append(input[i]);
        }
        else 
        {
            strength--;
        }
    }
    return resultString.ToString();
}