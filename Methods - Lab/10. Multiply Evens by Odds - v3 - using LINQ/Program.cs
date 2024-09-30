string input = Console.ReadLine();

int even = input
    .ToCharArray()
    .Where(char.IsDigit)
    .Select(x => int.Parse(x.ToString()))
    .Where(x => x % 2 == 0)
    .Sum();

int odd = input    // "123"
    .ToCharArray() //['1', '2', '3'] => (стринг на char масив, за да може да
                   //проверяваме елементите 1 по 1 дали са even или odd)
    .Where(char.IsDigit) //условие дали всички елементи са цифри
    .Select(x => int.Parse(x.ToString())) //["1", "2", "3"] (всеки 1 char на string, след което parse
                                          //към int [1, 2, 3])
    .Where(x => x % 2 != 0)  //[1, 3]     //отделяме само нечетни
    .Sum(); //4                           сумираме каквито елементи са останали

Console.WriteLine(even * odd);
//---------------------------------------------
int num = input
    .ToArray()
    .Where(x => x >= 48 && x <= 57)
    .Select(x => int.Parse(x.ToString()))
    .Where(x => x % 2 != 0)
    .Sum();
Console.WriteLine(num);
//----------------------------------------------