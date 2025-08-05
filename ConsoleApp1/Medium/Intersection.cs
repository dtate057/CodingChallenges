public class Intersection
{
    public static int[] Intersect(int[] num1, int[] num2)
    {
        List<int> ints = new List<int>();       
        for(int i =0; i< num1.Length; i++)
        {
            int current = num1[i];
            for(int j = 0; j < num2.Length;j++)
            {
                if(current == num2[j])
                {
                    ints.Add(current);
                    continue;
                }
            }
        }
        return ints.ToArray();
    }
    static void Main()
    {
        int[] arr1 = { 1, 2, 4, 5, 6 };
        int[] arr2 = { 2, 3, 5, 7 };
        var intersects = string.Join(", ",Intersect(arr1, arr2));
        Console.WriteLine(intersects);
    }
}
