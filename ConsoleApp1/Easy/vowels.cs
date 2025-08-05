using System.Collections.Specialized;

public class Vowels
{
    public static int vowels(string input)
    {
        //make all characters lower case
        input = input.ToLower();
        //make array
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        //keep count
        int count = 0;
        foreach(var c in input)
        {
            if (Array.Exists(vowels, v => v == c))
                count++;
        }
        return count;
    }
    static void vowel()
    {
        string input = "Hello World";
        Console.WriteLine(vowels(input));
    }
}
