using System.Text;

public class DuplicatesFromStringProg
{
    public static string DuplicatesFromString(string input)
    {
        HashSet<char> chars = new HashSet<char>();
        StringBuilder stringBuilder = new StringBuilder();
        foreach(var character in input)
        {
            if (!chars.Contains(character))
            {
                chars.Add(character);
                stringBuilder.Append(character);
            }
        }
            return stringBuilder.ToString();
    }
    public static void closest()
    {
        string input = "programming";
        string output = DuplicatesFromString(input);
        Console.WriteLine("Without duplicates: " + output);  // Output: progamin
    }
}
