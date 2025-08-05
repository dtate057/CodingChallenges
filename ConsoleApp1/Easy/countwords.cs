using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class CountWords
{
    public static int Count(string input)
    {
        string[] words = input.Split([' '], StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
    static void duck()
    {
        string input = "C# is fun to learn";
        Console.WriteLine(Count(input));
    }
}
