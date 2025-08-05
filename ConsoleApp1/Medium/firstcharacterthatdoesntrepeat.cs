public class FirstCharDoesNotRepeatProg
{
    public static char? FirstCharDoesNotRepeat(string input)
    {
        Dictionary<char, int> freqCount = new Dictionary<char, int>();
        foreach(var letter in input)
        {
            if(freqCount.ContainsKey(letter))
            {
                freqCount[letter]++;
            }
            else
            {
                freqCount[letter] = 1;
            }
        }
        // Second pass: find the first character with count = 1
        foreach (char letter in input)
        {
            if (freqCount[letter] == 1)
                return letter;
        }
        return null;
    }
    static void swiss()
    {
        var input = "swiss";
        Console.WriteLine(FirstCharDoesNotRepeat(input));
    }
}