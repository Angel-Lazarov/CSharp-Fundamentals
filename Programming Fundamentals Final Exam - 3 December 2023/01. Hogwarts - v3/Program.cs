namespace _01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();
 
            string input = Console.ReadLine();
 
            while (input != "Abracadabra")
            {
                string[] commandInfo = input.Split();
 
                if (commandInfo[0] == "Abjuration")
                {
                    spell = spell.ToUpper();
                    Console.WriteLine(spell);
                }
                else if (commandInfo[0] == "Necromancy")
                {
                    spell = spell.ToLower();
                    Console.WriteLine(spell);
                }
                else if (commandInfo[0] == "Illusion")
                {
                    int index = int.Parse(commandInfo[1]);
                    char letter = char.Parse(commandInfo[2]);
 
                    if (index >= 0 && index < spell.Length)
                    {
                        spell = spell.Remove(index, 1).Insert(index, letter.ToString());
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (commandInfo[0] == "Divination")
                {
                    string firstSubstring = commandInfo[1];
                    string secondSubstring = commandInfo[2];
 
                    if (spell.Contains(firstSubstring))
                    {
                        spell = spell.Replace(firstSubstring, secondSubstring);
                        Console.WriteLine(spell);
                    }
                }
                else if (commandInfo[0] == "Alteration")
                {
                    string substringRemove = commandInfo[1];
 
                    if (spell.Contains(substringRemove))
                    {
                        spell = spell.Replace(substringRemove, string.Empty);
                        Console.WriteLine(spell);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
 
                input = Console.ReadLine();
            }
        }
    }
}