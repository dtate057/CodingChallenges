public class RotateArrProg
{
    public static int[] rotateArray(int[] arr, int k)
    {
        int n = arr.Length;
        if (n == 0 || k % n == 0)
        {
            return arr;
        }
        k = k % n;
        int[] result = new int[n];
        Array.Copy(arr, n - k, result, 0, k);
        Array.Copy(arr, 0, result, k, n - k);
        return result;
    }
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 2;
        Console.WriteLine(string.Join(", ", rotateArray(arr, k)));
    }
}