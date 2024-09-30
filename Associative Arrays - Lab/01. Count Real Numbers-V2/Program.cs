int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

Dictionary<int, int> nums = new Dictionary<int, int>();

foreach (int i in input) 
{
    if (!nums.ContainsKey(i))
    {
        nums.Add(i, 0);
    }
    nums[i] += 1;
}

//nums = nums.OrderBy(x => x.Key).ToDictionary(x=>x.Key, x=>x.Value);

foreach (var number in nums.OrderBy(x=>x.Key)) 
//foreach (var number in nums) 
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}