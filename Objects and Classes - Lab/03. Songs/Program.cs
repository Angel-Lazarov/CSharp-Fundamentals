using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;

public class Program
{
    public static void Main()
    {
        // Objects and Classes - Lab - 03. Songs

        int.TryParse(Console.ReadLine(), out int lines);

        List<ClassPesen> playList = new List<ClassPesen>();

        for (int i = 0; i < lines; i++)
        {
            string[] songInfo = Console.ReadLine().Split("_");
            string songType = songInfo[0];
            string songName = songInfo[1];
            string songTime = songInfo[2];


            //------------------------------------
            ClassPesen pesen = new ClassPesen(); // създаваме нов обект {песен}
            {
                pesen.TypeList = songType;
                pesen.Name = songName;
                pesen.Time = songTime;
            }
            //------------------------------------

            playList.Add(pesen);
        }
        string typeList = Console.ReadLine();

        if (typeList == "all")
        {
            foreach (ClassPesen pesen in playList)
            {
                Console.WriteLine(pesen.Name);
            }
        }
        else 
        {
            foreach (ClassPesen pesen in playList)
            {
                if (typeList == pesen.TypeList) 
                {
                    Console.WriteLine(pesen.Name);
                }    
            }
        }
        //List<ClassPesen> filteredPesni = playList.Where(s=>s.TypeList == typeList).ToList();

    }
}
class ClassPesen
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}