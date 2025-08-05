public class TwoArraysAreEqualProg
{
    public static bool TwoArraysAreEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
            return false;
        Array.Sort(arr1);
        Array.Sort(arr2);
        for (int i = 0; i < arr1.Length;i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        return true;
    }
    static void hulk()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 6, 1, 2 };
        Console.WriteLine(TwoArraysAreEqual(arr1, arr2));
    }
}