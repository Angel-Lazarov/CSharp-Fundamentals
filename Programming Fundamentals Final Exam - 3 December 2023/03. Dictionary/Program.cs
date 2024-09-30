string[] input = Console.ReadLine().Split(" | ");  // word:definition | word:definition

Dictionary<string, List<string>> notebook = new Dictionary<string, List<string>>();

for (int i = 0; i < input.Length; i++) 
{
    string[] word = input[i].Split(": ");

    string wordName = word[0];
    string wordDefinition = word[1];

    if (!notebook.ContainsKey(wordName))
    {

        notebook.Add(wordName, new List<string>());
        notebook[wordName].Add(wordDefinition);
    }
    else 
    {
        notebook[wordName].Add(wordDefinition);
    }
}

string[] testWords = Console.ReadLine().Split(" | ");


string command = Console.ReadLine();

if (command == "Test")
{
    foreach (string word in testWords)
    {
        if (notebook.ContainsKey(word))
        {
            //     print all its definitions
            Console.WriteLine($"{word}:");
            foreach (string definition in notebook[word])
            {
                Console.WriteLine($" -{definition}");
            }
        }
    }
}
else if (command == "Hand Over") 
{
    foreach (var (key, value) in notebook)
    {
        Console.Write($"{key} ");
    }
}
