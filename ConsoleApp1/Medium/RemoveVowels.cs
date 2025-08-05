using System.Text;

public class RemoveVowels
{
    public static string removevowel(string input)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        StringBuilder result = new StringBuilder();
        foreach(var ch in input)
        {
if(!vowels.Contains(ch))
                {
                result.Append(ch);
            }
        }
        return result.ToString();
    }
    static void visit()
    {
        string input = "beautiful";
        Console.WriteLine(removevowel(input));
    }
}
