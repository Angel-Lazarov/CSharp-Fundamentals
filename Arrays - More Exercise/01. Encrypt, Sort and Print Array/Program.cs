int.TryParse(Console.ReadLine(), out int lines);
int[] array = new int[0];

for (int i = 0; i < lines; i++)
{
	string input = Console.ReadLine();
	int vowelsum = 0;
	int consonantsum = 0;


	for (int j = 0; j < input.Length; j++)
	{
		switch (input[j])
		{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
			//	case 'y':
			case 'A':
			case 'E':
			case 'I':
			case 'O':
			case 'U':
				//   case 'y':

				vowelsum += input[j] * input.Length;
				break;
			default:
				consonantsum += input[j] / input.Length;
				break;
		}
	}

	//    console.writeline($"{input} - {vowelsum+consonantsum}");
	array = array.Append(vowelsum + consonantsum).ToArray();
}
Array.Sort(array);
foreach (int i in array)
{
	Console.WriteLine(i);
}