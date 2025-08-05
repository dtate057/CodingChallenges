using System.Text;

public class TitleCaseProg
{
    public static string TitleCase(string sentence)
    {
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for(int i = 0; i < words.Length;i++)
        {
            var word = words[i];
            if(word.Length > 0)
            {
                words[i] = char.ToUpper(word[0]) + word.Substring(1);
            }
        }
        return string.Join(" ", words);

    }
    static void badger()
    {
        string input = "c# is fun";
        Console.WriteLine(TitleCase(input));
    }
}