public class Frequencey
{
    public static List<string> FrequenceyCheck(string input)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        List<string> result = new List<string>();
        foreach(var ch in input)
        {
        if(frequency.ContainsKey(ch))
            {
                frequency[ch]++;
            }
        else
            {
                frequency[ch] = 1;
            }
        }
       foreach(var kv in frequency)
        {
            result.Add($"{kv.Key}:{kv.Value}");
        }
        return result;
    }
    static void bat()
    {
        string input = "hello";
        Console.WriteLine(string.Join(", ", FrequenceyCheck(input)));
    }
}
