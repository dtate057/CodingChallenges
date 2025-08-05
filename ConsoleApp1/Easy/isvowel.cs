using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class isvowel
    {
    public static string isvowelprog(char chars)
    {

        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        if (vowels.Contains(chars))
        {
            return "Vowel";
        }
        else
            return "Consonant";
    }
    static void goat()
    {
        char input = 'n';
        Console.WriteLine(isvowelprog(input));
    }
    }

