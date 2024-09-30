
string spell = Console.ReadLine();

string input = string.Empty;

while ((input = Console.ReadLine()) != "Abracadabra")
{
    string[] commandInfo = input.Split();
    string command = commandInfo[0];

    if (command == "Abjuration")
    {
        spell = spell.ToUpper();
        Console.WriteLine(spell);
    }
    else if (command == "Necromancy")
    {
        spell = spell.ToLower();
        Console.WriteLine(spell);
    }
    else if (command == "Illusion")
    {
        int index = int.Parse(commandInfo[1]);
        string letter = commandInfo[2];
        char newChar = char.Parse(letter);

        if (index >= 0 && index < spell.Length)
        {
            char oldChar = spell[index];
            spell = spell.Replace(oldChar, newChar);
            Console.WriteLine("Done!");
        }
        else
        {
            Console.WriteLine("The spell was too weak.");
        }
    }
    else if (command == "Divination") //ok - подмени стария стринг с новия
    {
        string first = commandInfo[1];
        string second = commandInfo[2];
        if (spell.Contains(first))
        {
            spell = spell.Replace(first, second);
            Console.WriteLine(spell);
        }
    }
    else if (command == "Alteration") // премахни substring-a
    {
        string subs = commandInfo[1];
        //int indexSubs = spell.IndexOf(subs, StringComparison.InvariantCultureIgnoreCase);

        //   if (indexSubs != -1)
        if (spell.Contains(subs))
        {
            int indexSubs = spell.IndexOf(subs);
            spell = spell.Remove(indexSubs, subs.Length);
            Console.WriteLine(spell);
        }
    }
    else
    {
        Console.WriteLine("The spell did not work!");
    }
}

/*
A7ci0

SoftUni sa ebahti gadnite, dolni pederasite!
Illusion 4 *
Illusion 65 -
Illusion -5 +
Alteration dolni
Alteration ,
Alteration ite





Abracadabra




Illusion 1 c
Illusion 4 o
 

TR1GG3R

Necromancy
Illusion 8 m
Illusion 9 n
Abracadabra


SwordMaster
Target Target Target
Abjuration
Necromancy
Alteration master
Abracadabra

qwertQWERwe78we90weTY43536
Divination WE ---
        //Console.Write(string.Join(", ", key));


 */