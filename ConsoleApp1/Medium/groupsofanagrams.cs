public class AnagramGroupProg
{
    public static List<List<string>> AnagramGroup(string[] words)
    {
        Dictionary<string, List<string>> anagramgroups = new Dictionary<string, List<string>>();
        foreach(var word in words)
        {
            string key = String.Concat(word.OrderBy(c => c));
            if(!anagramgroups.ContainsKey(key))
            {
                anagramgroups[key] = new List<string>();
            }
            anagramgroups[key].Add(word);
        }
        return anagramgroups.Values.ToList();
    }
    public static void bleak()
    {
        string[] input = { "bat", "tab", "tap", "pat", "cat" };
        var result = AnagramGroup(input);
        foreach(List<string> group in result)
        {
            Console.WriteLine("[{0}]", string.Join(", ", group));
        }
    }
}
