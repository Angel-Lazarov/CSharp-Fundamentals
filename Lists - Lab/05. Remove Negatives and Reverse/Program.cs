//------------------Begin First Way------------------------------------------
//List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Where(x => x > 0).ToList();
//------------------End Second Way------------------------------------------

//------------------Begin Second Way------------------------------------------
//List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

//for (int i = 0; i < numbers.Count; i++)
//{
//    if (numbers[i] < 0) 
//    { 
//    numbers.RemoveAt(i);
//        i=-1;
//    }
//}
//------------------End Second Way------------------------------------------

//------------------Begin Third Way------------------------------------------
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> numbers2 = new List<int>();

foreach (int item in numbers)
{
    if (item >= 0) 
    {
    numbers2.Add(item);
    }
}
numbers = numbers2;

//------------------End Third Way------------------------------------------

//------------------Begin Fourth Way------------------------------------------

//numbers.RemoveAll(n => n < 0);

//------------------End Fourth Way------------------------------------------



numbers.Reverse();

if (numbers.Count > 0)
{
    Console.WriteLine(string.Join(" ", numbers));
}
else 
{
    Console.WriteLine("empty");
}
