string[] input = Console.ReadLine().Split();
string first = input[0];
string second = input[1];
int sum = 0;

string bigString = string.Empty;
string smallString = string.Empty;

if (first.Length > second.Length) 
{ 
    bigString = first;
    smallString = second;
}
else
{
    bigString = second;
    smallString = first;
}

for (int i = 0; i < smallString.Length; i++) 
{
        sum += first[i] * second[i];
}

for (int i = smallString.Length; i < bigString.Length; i++)
{ 
    sum += bigString[i]; 
}

Console.WriteLine(sum);


