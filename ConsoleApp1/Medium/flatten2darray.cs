public class Flatten2DArrayProg
{
    public static int[] Flatten2DArray(int[][] matrix)
    {
        List<int> flatList = new List<int>();
        foreach (int[] row in matrix)
        {
            foreach (var element in row)
            {
                flatList.Add(element);
            }
        }
        return flatList.ToArray();
    }
    static void drake()
    {
        int[][] input = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6 }
            };
        int[] result = Flatten2DArray(input);
        Console.WriteLine(string.Join(", ", result));
    }
}