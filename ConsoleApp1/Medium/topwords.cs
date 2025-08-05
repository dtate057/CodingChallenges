using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void top_words(string input, int n)
    {
        //lower case
        input = input.ToLower()
              .Replace("“", "\"").Replace("”", "\"")
              .Replace("’", "'").Replace("‘", "'")
              .Replace("\"", "");


        //seperate string
        var words = Regex.Matches(input, @"\b[a-z']+\b")
            .Cast<Match>()
            .Select(m => m.Value)
            .ToList();
        //count the frequency of each word
        Dictionary<string, int> freqWords = new Dictionary<string, int>();
        foreach(var word in words)
        {
            if (freqWords.ContainsKey(word))
                freqWords[word]++;
            else
                freqWords[word] = 1;
        }
        //sort the words by value then key
        var sortedWords = freqWords.OrderByDescending(kv => kv.Value)
            .ThenBy(kv => kv.Key)
            .Take(n);
        foreach(var kv in sortedWords)
        {
            Console.WriteLine($"{kv.Value} : {kv.Key}");
        }    


    }
    static void Words()
    {
        string text = @" The man sprang from his chair and paced up and down the room in uncontrollable agitation. 
                        Then, with a gesture of desperation, he tore the mask from his face and hurled it upon the ground. 
                        You are right, he cried; I am the King. Why should I attempt to conceal it?";

        top_words(text, 10);
    }
}