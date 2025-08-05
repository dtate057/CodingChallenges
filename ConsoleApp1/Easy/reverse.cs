using System.Text;

public class Reverse
{
    public static string reverse(string input)
    {
        string reversedString = "";
        for(int i = input.Length -1; i >= 0; i--)
        {
            reversedString += input[i];
        }
        return reversedString;
    }
    public static void rev()
    {
        string input = "hello";
        Console.WriteLine(reverse(input));
    }
}