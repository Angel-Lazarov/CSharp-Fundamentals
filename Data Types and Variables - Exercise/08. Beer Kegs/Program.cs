int number = int.Parse(Console.ReadLine());
float bestVolume = 0;
string bestModel = string.Empty;

for (int i = 0; i < number; i++)
{
    string model = Console.ReadLine();
    float radius = float.Parse(Console.ReadLine()); 
    int height = int.Parse(Console.ReadLine());
    float volume = (float)(Math.PI * Math.Pow(radius, 2) * height);
    if (volume > bestVolume) 
    {
        bestVolume = volume;
        bestModel = model;
    }
}
Console.WriteLine(bestModel);
