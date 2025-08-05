using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Replacespaceswithdash
{
    public static string replaceSpace(string input)
    {
        string newString = input.Replace(' ', '-');
        return newString;
    }
    static void replace()
    {
        string input = "Hello World";
        Console.WriteLine(replaceSpace(input));
    }
}