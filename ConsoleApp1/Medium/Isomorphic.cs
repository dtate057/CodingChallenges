using System.Collections;
using System.Text;

public class IsomorphicProg
{
public static bool Isomorphic(string str,string str2)
    {
        if (str.Length != str2.Length)
            return false;
        Dictionary<char, char> str1Tostr2 = new Dictionary<char, char>();
        HashSet<char> str2chars = new HashSet<char>();
        for(int i = 0; i < str.Length;i++)
        {
            char c1 = str[i];
            char c2 = str2[i];
            if(str1Tostr2.ContainsKey(c1))
            {
                if (str1Tostr2[c1] != c2)
                    return false;
            }
            else
            {
                if (str2chars.Contains(c2))
                    return false;
            }
                str1Tostr2[c1] = c2;
            str2chars.Add(c2);
        }
        return true;

    }

    static void Iso()
    {
        string str1 = "egg";
        string str2 = "add";
        Console.WriteLine(Isomorphic(str1, str2));
    }
}