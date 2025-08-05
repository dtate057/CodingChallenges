public class panagram
{
    public static bool panagramprog(string input)
    {
        HashSet<char> chars = new HashSet<char>();
       
        foreach(var word in input.ToLower())
        {
            if(char.IsLetter(word))
            chars.Add(word);
        }
        if (chars.Count == 26)
            return true;
        else return false;
    }
    static void clap()
    {
        string input = "The quick brown fox jumps over the lazy dog";
        Console.WriteLine(panagramprog(input));
    }
}