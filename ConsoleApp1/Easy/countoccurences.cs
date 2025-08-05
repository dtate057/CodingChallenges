using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class countoccurences
    {
    public static int occurences(string input,char character)
    {
        int count = 0;
        for(int i = 0;i < input.Length;i++)
        {
            if (input[i] == character)
            {
                count++;
            }
        }
        return count;
    }
    static void cut()
    {
        string input = "helllllo";
        char character = 'l';
        Console.WriteLine($"{occurences(input, character)}");
    }
}
