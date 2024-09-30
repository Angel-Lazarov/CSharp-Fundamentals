int[] field= new int[int.Parse(Console.ReadLine())]; //създаваме поле с дадените размери
int[] startingPosition = Console.ReadLine().Split().Select(int.Parse).ToArray(); //дават се позициите на калинките

//----------поставя калинките на полето-------.
for (int i = 0; i < startingPosition.Length; i++)
{
    if (startingPosition[i] < 0 || startingPosition[i] > field.Length - 1)
    {//Ако ви бъде даден индекс на калинка, който е извън полето, нищо не се случва.-------
        continue;
    }
    else
    {
        field[startingPosition[i]] = 1;
    }
}

while (true) 
{
    string command = Console.ReadLine();
    if (command == "end") { break; }
    else 
    {
        //----------получаване на командата за летене---------------
        string[] input = command.Split().ToArray();

        int currentBugIndex = int.Parse(input[0]);
        if (currentBugIndex < 0 || currentBugIndex > field.Length - 1)
        { //Ако ви бъде даден индекс на калинка, който е извън полето, нищо не се случва
            continue; 
        }

        int flyLength = int.Parse(input[2]);

        string direction = input[1];
        if (direction == "left")
        {
            flyLength *= -1;
        }
        //----------------------------------------------------------

              //ако има калинка тук    
        if (field[currentBugIndex] == 1)
        {
            int move = currentBugIndex + flyLength;

            if (move < field.Length && move >= 0)
            {
                for (int i = 0; i < field.Length; i++)
                {
                    if (field[move] == 1)
                    {
                        move += flyLength;
                        if (move > field.Length - 1)
                        {
                            field[currentBugIndex] = 0;
                            break;
                        }
                    }

                    if (field[move] != 1)
                    {
                        field[move] = 1;
                        field[currentBugIndex] = 0;
                        break;
                    }
                }
            }
            else
            {
                field[currentBugIndex] = 0;
            }
        }
    }
}
Console.WriteLine(string.Join(" ", field).ToArray());
