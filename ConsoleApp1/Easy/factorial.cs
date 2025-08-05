using System.Text;

public class factorial
{
    public static int test(int n)
    {
        int result = 1;
        for(int i = 2; i<= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static void fact()
    {
        int input = 5;
        Console.WriteLine(test(input));
    }
}