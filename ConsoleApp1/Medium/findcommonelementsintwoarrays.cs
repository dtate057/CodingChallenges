public class FindeCommonEleInTwoArraysProg
{
    public static int[] FindeCommonEleInTwoArrays(int[] arr1, int[] arr2)
    {
        HashSet<int> set1 = new HashSet<int>(arr1);
        HashSet<int> set2 = new HashSet<int>(arr2);
        set1.IntersectWith(set2);
        return set1.ToArray();
            
    }
    static void wolf()
    {
        int[] arr1 = { 1, 2, 3, 4 };
        int[] arr2 = { 3, 4, 5, 6 };
        Console.WriteLine(string.Join(", ",FindeCommonEleInTwoArrays(arr1,arr2)));
    }
}