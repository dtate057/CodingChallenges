using System.Text;

public class RLEProg
{
    public static string RLE(string str1)
    {
        StringBuilder stringBuilder = new StringBuilder();
        int count = 1;
        for(int i = 1; i< str1.Length;i++)
        {
            if (str1[i-1] == str1[i])
            {
                count++;
            }
            else
            {
                stringBuilder.Append(str1[i - 1]);
                stringBuilder.Append(count);
                count = 1;
            }
        }
        stringBuilder.Append(str1[^1]);
        stringBuilder.Append(count);
        return stringBuilder.ToString();
    }
static void black()
{
    string str1 = "aaaabb";
    Console.WriteLine(RLE(str1));
}
}
