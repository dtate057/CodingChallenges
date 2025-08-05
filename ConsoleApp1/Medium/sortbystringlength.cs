public class SortByStrLengthProg
{
    public static string[] SortByLength(string[] strings)
    {
        Dictionary<string, int> stringsandlengths = new Dictionary<string, int>();
        foreach(var word in strings)
            {
                stringsandlengths[word] = word.Length;
        }
       var sorted = stringsandlengths.OrderBy(sl => sl.Value)
            .Select(sl => sl.Key)
            .ToArray();
        return sorted;
    }
    static void tarzan()
    {
        string[] array = { "apple", "cat", "bannana", "to" };
        Console.WriteLine(string.Join(", ",SortByLength(array)));
    }
}