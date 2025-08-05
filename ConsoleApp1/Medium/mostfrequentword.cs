public class MostFrequestWordProg
{
    public static string MostFrequentWord(string sentence)
    {
        Dictionary<string, int> wordFreq = new Dictionary<string, int>();
        foreach(string word in sentence.ToLower().Split(' '))
        {
            if(wordFreq.ContainsKey(word))
            {
                wordFreq[word]++;
            }
            else
            {
                wordFreq[word] = 1;
            }
        }
        return wordFreq.OrderByDescending(kv => kv.Value)
            .Select(kv => kv.Key)
            .First();

    }
    static void clinic()
    {
        string input = "the cat and the dog";
        Console.WriteLine(MostFrequentWord(input));
    }
}