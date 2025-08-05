using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LongestWordProg
{
    public static string LongestWord(string input)
    {
if(input == null)
        {
            return "";
        }
        return input.Split(' ')
                    .OrderByDescending(word => word.Length)
                    
                    .First();
    }
    static void jumps()
    {
        string input = "The quick brown fox jumps over the lazy dog";
        Console.WriteLine(LongestWord(input));
    }
}