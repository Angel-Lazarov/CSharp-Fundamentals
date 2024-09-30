string[] path = Console.ReadLine().Split("\\");
string[] fileName = path[path.Length - 1].Split(".");

Console.WriteLine($"File name: {fileName[0]}");
Console.WriteLine($"File extension: {fileName[1]}");
//------------------Path Method Begin---------------------------
//string path = Console.ReadLine();
//string name = Path.GetFileNameWithoutExtension(path);
//string extension = Path.GetExtension(path).Remove(0, 1);
//Console.WriteLine($"File name: {name}");
//Console.WriteLine($"File extension: {extension}");
//--------------------Path Method End--------------------

//string path = Console.ReadLine();
//int startIndex = path.LastIndexOf('\\');
//int dotIndex = path.IndexOf('.');
//string name = path.Substring(startIndex+1, dotIndex - startIndex-1);
//string extensioan = path.Substring(dotIndex + 1);

//Console.WriteLine($"File name: {name}");
//Console.WriteLine($"File extension: {extension}");
