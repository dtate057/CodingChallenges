public class AvgofElements
{
    public static double avgOfNum(int[] intArray)
    {

        int sum = 0;
        for (int i = 0; i < intArray.Length; i++)
        {
            sum += intArray[i];
        }

        return (double)sum / intArray.Length;
    }
    static void turtle()
    {
        int[] intArray = { 4, 6, 8 };
        double average = avgOfNum(intArray);
        Console.WriteLine($"Average of the {intArray.Length} numbers is {average}");
    }
}
