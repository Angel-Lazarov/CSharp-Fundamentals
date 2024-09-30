
string bigNumber = Console.ReadLine();
int digit = int.Parse(Console.ReadLine());

string result = Multiplay(bigNumber, digit);
Console.WriteLine(result);

static string Multiplay(string bigNumber, int digit)
{
    if (bigNumber == "0" || digit == 0) 
    {
        return "0";
    }

    int carry = 0;
    char[] resultCharArray = new char[bigNumber.Length+1];

    for (int i = bigNumber.Length-1; i >= 0; i--) 
    {
        int result = int.Parse(bigNumber[i].ToString()) * digit + carry;
        resultCharArray[i + 1] = (char)(result % 10 + '0');
        carry = result/10;
    }

    if (carry > 0)
    {
        resultCharArray[0] = (char)(carry + '0'); 
    }

    return new string(resultCharArray).TrimStart('0');
}