public class PairsToSumProg
{
    public static List<(int, int)> PairsToSum(int[] nums, int target)
    {
        HashSet<string> pairs = new HashSet<string>();
        HashSet<int> seen = new HashSet<int>();
        List<(int, int)> result = new List<(int, int)>();
        foreach(var num in nums)
        {
            int complement = target - num;
            if(seen.Contains(complement))
            {
                int min = Math.Min(complement, num);
                int max = Math.Max(complement, num);
                string keyString = $"{min},{max}";
                if(!pairs.Contains(keyString))
                {
                    result.Add((min, max));
                    pairs.Add(keyString);
                }
                seen.Add(num);
            }
        }
        return result;
    }
    static void cat()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int target = 6;
        Console.WriteLine(string.Join(", ",PairsToSum(arr, target)));
    }
}