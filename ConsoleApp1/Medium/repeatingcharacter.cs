public class FirstRepeatingChar
{
    public static char firstRepeatingChar(string str)
    {
        HashSet<char> chars = new HashSet<char>();
        foreach(var character in str)
        {
            if (chars.Contains(character))
            {
                return character;
            }
            else
                chars.Add(character);
        }
        return '-';
    }
    static void mary()
    {
        string str = "xyz";
        Console.WriteLine(firstRepeatingChar(str));

    }
}
