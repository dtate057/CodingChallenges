public class IsSortedProg
{
    public static bool IsSorted(int[] arr)
    {
      
        for(int i = 1;i < arr.Length;i++)
        {
            if (arr[i] < arr[i-1])
                return false;
        }
        return true;
}
    static void junk()
    {
        int[] arr = { 1, 2, 3, 4 };
        Console.WriteLine(IsSorted(arr));
    }
}
