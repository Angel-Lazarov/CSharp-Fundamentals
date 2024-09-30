int n = int.Parse(Console.ReadLine());

//for (int i = 97; i < 97 + n; i++) 
//{
//    for (int j = 97; j < 97 +n; j++) 
//    {
//        for (int l = 97; l < 97 +n; l++)
//        {
//            Console.WriteLine($"{(char)i}{(char)j}{(char)l}");
//        }
//    }

//}
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
        for (int k = 0; k < n; k++)
		{
            char firstChar = (char)('a' + i);
            char seconChar = (char)('a' + j);
            char thirdChar = (char)('a' + k);
            Console.WriteLine($"{firstChar}{seconChar}{thirdChar}");
        }
    }
}