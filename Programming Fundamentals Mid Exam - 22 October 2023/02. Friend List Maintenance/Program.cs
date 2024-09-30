using System.Xml.Linq;

namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split(", ").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Report")
            {
                string[] command = input.Split();
                string commandName = command[0];

                if (commandName == "Blacklist")
                {
                    string name = command[1];

                    if (contacts.Contains(name))
                    {
                        int nameIndex = contacts.IndexOf(name);
                        contacts[nameIndex] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                    }
                    else 
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }

                else if (commandName == "Error")
                {
                    int index = int.Parse(command[1]);

                    if ((index >= 0 && index < contacts.Count)
                        && (contacts[index] != "Blacklisted") 
                        && contacts[index] != "Lost")
                    {
                        string currentName = contacts[index];
                        contacts[index] = "Lost";
                        Console.WriteLine($"{currentName} was lost due to an error.");
                    }
                }

                else if (commandName == "Change") 
                {
                    int index = int.Parse(command[1]);
                    string newName = command[2];

                    if (index >= 0 && index < contacts.Count) 
                    {
                        string currentName = contacts[index];
                        contacts[index] = newName;
                        
                        Console.WriteLine($"{currentName} changed his username to {newName}.");
                    }
                }
            }

            int blacklisted = 0;
            int lost = 0;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i] == "Blacklisted")
                {
                    blacklisted++;
                }
                else if (contacts[i] == "Lost") 
                {
                    lost++;
                }
            }

            Console.WriteLine($"Blacklisted names: {blacklisted}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(string.Join(" ", contacts));
        }
    }
}


