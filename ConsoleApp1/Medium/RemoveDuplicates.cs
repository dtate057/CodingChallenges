public class RemoveDuplicatesProg
{
    public static int[] removeDuplicates(int[] nums)
    {
        HashSet<int> result = new HashSet<int>(nums);
        return result.ToArray();

    }
    static void clan()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5 };
        var removeDups = removeDuplicates(arr);
        Console.WriteLine(string.Join(", ", removeDups));
    }
}
