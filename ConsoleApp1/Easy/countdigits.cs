public class countDigitsInNumb
{
    public static void countDigits(int num)
    {
        int count = 0;
        while(num > 0)
        {
            int result = num /= 10;
            count++;

        }
        Console.WriteLine(count);
    }
    static void gator()
    {
        int num = 12345;
        countDigits(num);
    }
}
